namespace WeightedOffsetBlend
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonGetNormalVector = new System.Windows.Forms.Button();
            this.checkBoxCustomCentroidEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxInverse = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.radioButtonQuadratic = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.customCentroidBox = new PEPluginFormTest.Vector3Box();
            this.directionVectorBox = new PEPluginFormTest.Vector3Box();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxDistanceXAxis = new System.Windows.Forms.CheckBox();
            this.checkBoxDistanceYAxis = new System.Windows.Forms.CheckBox();
            this.checkBoxDistanceZAxis = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "方向ベクトル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "スケール";
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.DecimalPlaces = 2;
            this.numericUpDownScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownScale.Location = new System.Drawing.Point(81, 66);
            this.numericUpDownScale.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(54, 19);
            this.numericUpDownScale.TabIndex = 4;
            this.numericUpDownScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "中心座標";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(34, 235);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "実行";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // buttonGetNormalVector
            // 
            this.buttonGetNormalVector.Location = new System.Drawing.Point(133, 235);
            this.buttonGetNormalVector.Name = "buttonGetNormalVector";
            this.buttonGetNormalVector.Size = new System.Drawing.Size(108, 23);
            this.buttonGetNormalVector.TabIndex = 7;
            this.buttonGetNormalVector.Text = "法線ベクトル取得";
            this.buttonGetNormalVector.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomCentroidEnabled
            // 
            this.checkBoxCustomCentroidEnabled.AutoSize = true;
            this.checkBoxCustomCentroidEnabled.Location = new System.Drawing.Point(12, 213);
            this.checkBoxCustomCentroidEnabled.Name = "checkBoxCustomCentroidEnabled";
            this.checkBoxCustomCentroidEnabled.Size = new System.Drawing.Size(197, 16);
            this.checkBoxCustomCentroidEnabled.TabIndex = 8;
            this.checkBoxCustomCentroidEnabled.Text = "重心の代わりに中心座標を指定する";
            this.checkBoxCustomCentroidEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxInverse
            // 
            this.checkBoxInverse.AutoSize = true;
            this.checkBoxInverse.Location = new System.Drawing.Point(12, 191);
            this.checkBoxInverse.Name = "checkBoxInverse";
            this.checkBoxInverse.Size = new System.Drawing.Size(179, 16);
            this.checkBoxInverse.TabIndex = 9;
            this.checkBoxInverse.Text = "重み反転(中心でオフセット最大)";
            this.checkBoxInverse.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEllipse);
            this.groupBox1.Controls.Add(this.radioButtonQuadratic);
            this.groupBox1.Controls.Add(this.radioButtonLinear);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "補完方式";
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.Checked = true;
            this.radioButtonLinear.Location = new System.Drawing.Point(12, 18);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(71, 16);
            this.radioButtonLinear.TabIndex = 0;
            this.radioButtonLinear.TabStop = true;
            this.radioButtonLinear.Text = "線形補完";
            this.radioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuadratic
            // 
            this.radioButtonQuadratic.AutoSize = true;
            this.radioButtonQuadratic.Location = new System.Drawing.Point(89, 18);
            this.radioButtonQuadratic.Name = "radioButtonQuadratic";
            this.radioButtonQuadratic.Size = new System.Drawing.Size(65, 16);
            this.radioButtonQuadratic.TabIndex = 1;
            this.radioButtonQuadratic.Text = "2次補完";
            this.radioButtonQuadratic.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(160, 18);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(71, 16);
            this.radioButtonEllipse.TabIndex = 2;
            this.radioButtonEllipse.Text = "楕円補完";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // customCentroidBox
            // 
            this.customCentroidBox.AutoSize = true;
            this.customCentroidBox.Location = new System.Drawing.Point(81, 42);
            this.customCentroidBox.MaximumSize = new System.Drawing.Size(173, 18);
            this.customCentroidBox.MinimumSize = new System.Drawing.Size(173, 18);
            this.customCentroidBox.Name = "customCentroidBox";
            this.customCentroidBox.Size = new System.Drawing.Size(173, 18);
            this.customCentroidBox.TabIndex = 3;
            // 
            // directionVectorBox
            // 
            this.directionVectorBox.AutoSize = true;
            this.directionVectorBox.Location = new System.Drawing.Point(81, 18);
            this.directionVectorBox.MaximumSize = new System.Drawing.Size(173, 18);
            this.directionVectorBox.MinimumSize = new System.Drawing.Size(173, 18);
            this.directionVectorBox.Name = "directionVectorBox";
            this.directionVectorBox.Size = new System.Drawing.Size(173, 18);
            this.directionVectorBox.TabIndex = 0;
            // 
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.checkBoxDistanceZAxis);
            this.groupBox2.Controls.Add(this.checkBoxDistanceYAxis);
            this.groupBox2.Controls.Add(this.checkBoxDistanceXAxis);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 44);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "距離測定軸";
            //
            // checkBoxDistanceXAxis
            //
            this.checkBoxDistanceXAxis.AutoSize = true;
            this.checkBoxDistanceXAxis.Checked = true;
            this.checkBoxDistanceXAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDistanceXAxis.Location = new System.Drawing.Point(12, 18);
            this.checkBoxDistanceXAxis.Name = "checkBoxDistanceXAxis";
            this.checkBoxDistanceXAxis.Size = new System.Drawing.Size(43, 16);
            this.checkBoxDistanceXAxis.TabIndex = 0;
            this.checkBoxDistanceXAxis.Text = "X軸";
            this.checkBoxDistanceXAxis.UseVisualStyleBackColor = true;
            //
            // checkBoxDistanceYAxis
            //
            this.checkBoxDistanceYAxis.AutoSize = true;
            this.checkBoxDistanceYAxis.Checked = true;
            this.checkBoxDistanceYAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDistanceYAxis.Location = new System.Drawing.Point(99, 18);
            this.checkBoxDistanceYAxis.Name = "checkBoxDistanceYAxis";
            this.checkBoxDistanceYAxis.Size = new System.Drawing.Size(43, 16);
            this.checkBoxDistanceYAxis.TabIndex = 1;
            this.checkBoxDistanceYAxis.Text = "Y軸";
            this.checkBoxDistanceYAxis.UseVisualStyleBackColor = true;
            //
            // checkBoxDistanceZAxis
            //
            this.checkBoxDistanceZAxis.AutoSize = true;
            this.checkBoxDistanceZAxis.Checked = true;
            this.checkBoxDistanceZAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDistanceZAxis.Location = new System.Drawing.Point(186, 18);
            this.checkBoxDistanceZAxis.Name = "checkBoxDistanceZAxis";
            this.checkBoxDistanceZAxis.Size = new System.Drawing.Size(43, 16);
            this.checkBoxDistanceZAxis.TabIndex = 2;
            this.checkBoxDistanceZAxis.Text = "Z軸";
            this.checkBoxDistanceZAxis.UseVisualStyleBackColor = true;
            //
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxInverse);
            this.Controls.Add(this.checkBoxCustomCentroidEnabled);
            this.Controls.Add(this.buttonGetNormalVector);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownScale);
            this.Controls.Add(this.customCentroidBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directionVectorBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "重み付きオフセット付加";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PEPluginFormTest.Vector3Box directionVectorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PEPluginFormTest.Vector3Box customCentroidBox;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonGetNormalVector;
        private System.Windows.Forms.CheckBox checkBoxCustomCentroidEnabled;
        private System.Windows.Forms.CheckBox checkBoxInverse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonQuadratic;
        private System.Windows.Forms.RadioButton radioButtonLinear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxDistanceZAxis;
        private System.Windows.Forms.CheckBox checkBoxDistanceYAxis;
        private System.Windows.Forms.CheckBox checkBoxDistanceXAxis;
    }
}