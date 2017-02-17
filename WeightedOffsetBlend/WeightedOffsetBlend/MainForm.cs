using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Numerics;
using PEPlugin;

namespace WeightedOffsetBlend
{
    public enum InterpolationType
    {
        Linear,
        Quadratic,
        Ellipse
    }

    public partial class MainForm : Form
    {
        private IPEPluginHost Host { get; }

        private Vector3 DirectionVector
        {
            get { return directionVectorBox.Value; }
            set { directionVectorBox.Value = value; }
        }

        private Vector3 CustomCentroid
        {
            get { return customCentroidBox.Value; }
            set { customCentroidBox.Value = value; }
        }

        private float ScaleValue
        {
            get { return (float)numericUpDownScale.Value; }
            set { numericUpDownScale.Value = (decimal)value; }
        }

        private bool IsInverse
        {
            get { return checkBoxInverse.Checked; }
            set { checkBoxInverse.Checked = value; }
        }

        private bool IsCustomCentroidEnabled
        {
            get { return checkBoxCustomCentroidEnabled.Checked; }
            set { checkBoxCustomCentroidEnabled.Checked = value; }
        }

        private bool IsMeasuredInXAxis
        {
            get { return checkBoxDistanceXAxis.Checked; }
            set { checkBoxDistanceXAxis.Checked = value; }
        }

        private bool IsMeasuredInYAxis
        {
            get { return checkBoxDistanceYAxis.Checked; }
            set { checkBoxDistanceYAxis.Checked = value; }
        }

        private bool IsMeasuredInZAxis
        {
            get { return checkBoxDistanceZAxis.Checked; }
            set { checkBoxDistanceZAxis.Checked = value; }
        }

        private InterpolationType InterpolationType
        {
            get
            {
                if (radioButtonLinear.Checked) return InterpolationType.Linear;
                if (radioButtonQuadratic.Checked) return InterpolationType.Quadratic;
                if (radioButtonEllipse.Checked) return InterpolationType.Ellipse;
                throw new InvalidOperationException();
            }
            set
            {
                switch (value)
                {
                    case InterpolationType.Linear:
                        radioButtonLinear.Checked = true;
                        break;
                    case InterpolationType.Quadratic:
                        radioButtonQuadratic.Checked = true;
                        break;
                    case InterpolationType.Ellipse:
                        radioButtonEllipse.Checked = true;
                        break;
                }
            }
        }

        public MainForm(IPEPluginHost host)
        {
            InitializeComponent();
            Host = host;

            // 重心利用時カスタムボックス無効化
            checkBoxCustomCentroidEnabled.CheckedChanged += (s, e) => customCentroidBox.Enabled = (s as CheckBox).Checked;
            buttonGetNormalVector.Click += (s, e) =>
            {
                // 法線ベクトル取得
                var model = Host.Connector.Pmd.GetCurrentState();
                var view = Host.Connector.View.PMDView;

                var pos = view.GetSelectedVertexIndices()
                    .Select(p => model.Vertex[p].Position)
                    .Select(p => new Vector3(p.X, p.Y, p.Z)).ToList();
                if (pos.Count != 3)
                {
                    MessageBox.Show(this, "3頂点を選択してください。", "法線ベクトル取得", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DirectionVector = Vector3.Normalize(Vector3.Cross(pos[1] - pos[0], pos[2] - pos[0]));
            };
            buttonExecute.Click += (s, e) => Execute();

            this.FormClosing += (s, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    this.Visible = false;
                }
            };

            IsCustomCentroidEnabled = true;
            IsCustomCentroidEnabled = false;
        }

        private void Execute()
        {
            var model = Host.Connector.Pmd.GetCurrentState();
            var view = Host.Connector.View.PMDView;
            var builder = Host.Builder;

            if (!IsMeasuredInXAxis && !IsMeasuredInYAxis && !IsMeasuredInZAxis)
            {
                MessageBox.Show(this, "距離を測定する軸が1つ以上必要です。", "距離測定軸");
                return;
            }

            var selectedv = view.GetSelectedVertexIndices().Select(p => model.Vertex[p]).ToList();
            if (selectedv.Count < 2) return;

            var posv = selectedv.Select(p => p.Position).Select(p => new Vector3(p.X, p.Y, p.Z)).ToList();

            Vector3 centroid;
            if (IsCustomCentroidEnabled) centroid = CustomCentroid;
            else
            {
                var gsum = posv.Aggregate(new Vector3(), (p, q) => p += q);
                centroid = Vector3.Divide(gsum, posv.Count);
            }

            var distv = posv.Select(p =>
            {
                float dist = 0;
                if (IsMeasuredInXAxis) dist += (float)Math.Pow(p.X - centroid.X, 2);
                if (IsMeasuredInYAxis) dist += (float)Math.Pow(p.Y - centroid.Y, 2);
                if (IsMeasuredInZAxis) dist += (float)Math.Pow(p.Z - centroid.Z, 2);
                return (float)Math.Sqrt(dist);
            }).ToList();
            float maxdist = distv.Max();

            for (int i = 0; i < selectedv.Count; i++)
            {
                float r = distv[i] / maxdist; // 0 <= r <= 1
                float c = 0;
                switch (InterpolationType)
                {
                    case InterpolationType.Linear:
                        c = IsInverse ? -r + 1 : r;
                        break;
                    case InterpolationType.Quadratic:
                        c = IsInverse ? -r * r + 1 : r * r;
                        break;
                    case InterpolationType.Ellipse:
                        c = IsInverse ? (float)Math.Sqrt(1 - r * r) : -(float)Math.Sqrt(1 - r * r) + 1;
                        break;
                }

                Vector3 dest = posv[i] + DirectionVector * ScaleValue * c;
                selectedv[i].Position = builder.CreateVector3(dest.X, dest.Y, dest.Z);
            }

            Host.Connector.Pmd.Update(model, PEPlugin.Pmd.UpdateObject.Vertex, -1);
            view.UpdateModel_Vertex();
            view.UpdateView();
        }
    }
}
