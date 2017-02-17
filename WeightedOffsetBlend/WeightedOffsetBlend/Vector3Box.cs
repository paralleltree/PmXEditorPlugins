using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Numerics;

namespace PEPluginFormTest
{
    public partial class Vector3Box : UserControl
    {
        public Vector3 Value
        {
            get { return new Vector3((float)numericUpDownX.Value, (float)numericUpDownY.Value, (float)numericUpDownZ.Value); }
            set
            {
                numericUpDownX.Value = (decimal)value.X;
                numericUpDownY.Value = (decimal)value.Y;
                numericUpDownZ.Value = (decimal)value.Z;
            }
        }

        public Vector3Box()
        {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
            Value = Vector3.Zero;
        }
    }
}
