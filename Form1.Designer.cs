namespace task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxBefore = new PictureBox();
            pictureBoxAfter = new PictureBox();
            buttonLoad = new Button();
            buttonInv = new Button();
            buttonGamma = new Button();
            buttonEdge = new Button();
            buttonSharp = new Button();
            buttonGauss = new Button();
            buttonBlur = new Button();
            buttonEmboss = new Button();
            buttonSave = new Button();
            buttonBrightDown = new Button();
            buttonBrightUp = new Button();
            buttonCtrUp = new Button();
            buttonGenerateMatrix = new Button();
            tableLayoutPanelKernel = new TableLayoutPanel();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            buttonFactor = new Button();
            textBoxFactor = new TextBox();
            numericUpDownOffset = new NumericUpDown();
            buttonCustomApply = new Button();
            buttonCustomSave = new Button();
            textBoxCustomName = new TextBox();
            comboBoxFilterPick = new ComboBox();
            buttonLoadFilter = new Button();
            groupBoxCustom = new GroupBox();
            numericUpDownAnchorY = new NumericUpDown();
            numericUpDownAnchorX = new NumericUpDown();
            labelAnchor = new Label();
            labelOffset = new Label();
            labelFactor = new Label();
            labelLoad = new Label();
            labelHeight = new Label();
            labelWidth = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBefore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAfter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOffset).BeginInit();
            groupBoxCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnchorY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnchorX).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBefore
            // 
            pictureBoxBefore.BackColor = SystemColors.GradientActiveCaption;
            pictureBoxBefore.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxBefore.Location = new Point(12, 12);
            pictureBoxBefore.Name = "pictureBoxBefore";
            pictureBoxBefore.Size = new Size(341, 280);
            pictureBoxBefore.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBefore.TabIndex = 0;
            pictureBoxBefore.TabStop = false;
            // 
            // pictureBoxAfter
            // 
            pictureBoxAfter.BackColor = SystemColors.GradientInactiveCaption;
            pictureBoxAfter.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAfter.Location = new Point(395, 12);
            pictureBoxAfter.Name = "pictureBoxAfter";
            pictureBoxAfter.Size = new Size(341, 280);
            pictureBoxAfter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAfter.TabIndex = 1;
            pictureBoxAfter.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(12, 312);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(140, 29);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "Load image";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonInv
            // 
            buttonInv.Location = new Point(158, 312);
            buttonInv.Name = "buttonInv";
            buttonInv.Size = new Size(140, 60);
            buttonInv.TabIndex = 3;
            buttonInv.Text = "Inversion";
            buttonInv.UseVisualStyleBackColor = true;
            buttonInv.Click += buttonInv_Click;
            // 
            // buttonGamma
            // 
            buttonGamma.Location = new Point(596, 312);
            buttonGamma.Name = "buttonGamma";
            buttonGamma.Size = new Size(140, 60);
            buttonGamma.TabIndex = 6;
            buttonGamma.Text = "Gamma correction";
            buttonGamma.UseVisualStyleBackColor = true;
            buttonGamma.Click += buttonGamma_Click;
            // 
            // buttonEdge
            // 
            buttonEdge.Location = new Point(450, 378);
            buttonEdge.Name = "buttonEdge";
            buttonEdge.Size = new Size(140, 60);
            buttonEdge.TabIndex = 10;
            buttonEdge.Text = "Edge detection";
            buttonEdge.UseVisualStyleBackColor = true;
            buttonEdge.Click += buttonEdge_Click;
            // 
            // buttonSharp
            // 
            buttonSharp.Location = new Point(304, 378);
            buttonSharp.Name = "buttonSharp";
            buttonSharp.Size = new Size(140, 60);
            buttonSharp.TabIndex = 9;
            buttonSharp.Text = "Sharpening";
            buttonSharp.UseVisualStyleBackColor = true;
            buttonSharp.Click += buttonSharp_Click;
            // 
            // buttonGauss
            // 
            buttonGauss.Location = new Point(158, 378);
            buttonGauss.Name = "buttonGauss";
            buttonGauss.Size = new Size(140, 60);
            buttonGauss.TabIndex = 8;
            buttonGauss.Text = "Gaussian blur";
            buttonGauss.UseVisualStyleBackColor = true;
            buttonGauss.Click += buttonGauss_Click;
            // 
            // buttonBlur
            // 
            buttonBlur.Location = new Point(12, 378);
            buttonBlur.Name = "buttonBlur";
            buttonBlur.Size = new Size(140, 60);
            buttonBlur.TabIndex = 7;
            buttonBlur.Text = "Blur";
            buttonBlur.UseVisualStyleBackColor = true;
            buttonBlur.Click += buttonBlur_Click;
            // 
            // buttonEmboss
            // 
            buttonEmboss.Location = new Point(596, 378);
            buttonEmboss.Name = "buttonEmboss";
            buttonEmboss.Size = new Size(140, 60);
            buttonEmboss.TabIndex = 11;
            buttonEmboss.Text = "Emboss";
            buttonEmboss.UseVisualStyleBackColor = true;
            buttonEmboss.Click += buttonEmboss_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 344);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(140, 28);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save image";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonBrightDown
            // 
            buttonBrightDown.Location = new Point(304, 344);
            buttonBrightDown.Name = "buttonBrightDown";
            buttonBrightDown.Size = new Size(140, 28);
            buttonBrightDown.TabIndex = 14;
            buttonBrightDown.Text = "Brightness down";
            buttonBrightDown.UseVisualStyleBackColor = true;
            buttonBrightDown.Click += buttonBrightDown_Click;
            // 
            // buttonBrightUp
            // 
            buttonBrightUp.Location = new Point(304, 312);
            buttonBrightUp.Name = "buttonBrightUp";
            buttonBrightUp.Size = new Size(140, 28);
            buttonBrightUp.TabIndex = 13;
            buttonBrightUp.Text = "Brightness up";
            buttonBrightUp.UseVisualStyleBackColor = true;
            buttonBrightUp.Click += buttonBrightUp_Click;
            // 
            // buttonCtrUp
            // 
            buttonCtrUp.Location = new Point(450, 312);
            buttonCtrUp.Name = "buttonCtrUp";
            buttonCtrUp.Size = new Size(140, 60);
            buttonCtrUp.TabIndex = 15;
            buttonCtrUp.Text = "Contrast enhacement";
            buttonCtrUp.UseVisualStyleBackColor = true;
            buttonCtrUp.Click += buttonCtrUp_Click;
            // 
            // buttonGenerateMatrix
            // 
            buttonGenerateMatrix.Location = new Point(6, 100);
            buttonGenerateMatrix.Margin = new Padding(3, 2, 3, 2);
            buttonGenerateMatrix.Name = "buttonGenerateMatrix";
            buttonGenerateMatrix.Size = new Size(125, 22);
            buttonGenerateMatrix.TabIndex = 18;
            buttonGenerateMatrix.Text = "Generate matrix";
            buttonGenerateMatrix.UseVisualStyleBackColor = true;
            buttonGenerateMatrix.Click += buttonGenerateMatrix_Click;
            // 
            // tableLayoutPanelKernel
            // 
            tableLayoutPanelKernel.ColumnCount = 1;
            tableLayoutPanelKernel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelKernel.Location = new Point(6, 126);
            tableLayoutPanelKernel.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelKernel.Name = "tableLayoutPanelKernel";
            tableLayoutPanelKernel.RowCount = 1;
            tableLayoutPanelKernel.RowStyles.Add(new RowStyle());
            tableLayoutPanelKernel.Size = new Size(331, 260);
            tableLayoutPanelKernel.TabIndex = 19;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownWidth.Location = new Point(88, 48);
            numericUpDownWidth.Margin = new Padding(3, 2, 3, 2);
            numericUpDownWidth.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDownWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.ReadOnly = true;
            numericUpDownWidth.Size = new Size(46, 23);
            numericUpDownWidth.TabIndex = 20;
            numericUpDownWidth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownHeight.Location = new Point(88, 73);
            numericUpDownHeight.Margin = new Padding(3, 2, 3, 2);
            numericUpDownHeight.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.ReadOnly = true;
            numericUpDownHeight.Size = new Size(46, 23);
            numericUpDownHeight.TabIndex = 21;
            numericUpDownHeight.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // buttonFactor
            // 
            buttonFactor.Location = new Point(233, 50);
            buttonFactor.Margin = new Padding(3, 2, 3, 2);
            buttonFactor.Name = "buttonFactor";
            buttonFactor.Size = new Size(82, 22);
            buttonFactor.TabIndex = 23;
            buttonFactor.Text = "Automatic factor";
            buttonFactor.UseVisualStyleBackColor = true;
            buttonFactor.Click += buttonFactor_Click;
            // 
            // textBoxFactor
            // 
            textBoxFactor.Location = new Point(196, 49);
            textBoxFactor.Margin = new Padding(3, 2, 3, 2);
            textBoxFactor.Name = "textBoxFactor";
            textBoxFactor.Size = new Size(31, 23);
            textBoxFactor.TabIndex = 24;
            textBoxFactor.Text = "1";
            textBoxFactor.MouseLeave += textBoxFactor_MouseLeave;
            // 
            // numericUpDownOffset
            // 
            numericUpDownOffset.Location = new Point(196, 77);
            numericUpDownOffset.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownOffset.Name = "numericUpDownOffset";
            numericUpDownOffset.Size = new Size(53, 23);
            numericUpDownOffset.TabIndex = 25;
            // 
            // buttonCustomApply
            // 
            buttonCustomApply.Location = new Point(218, 391);
            buttonCustomApply.Name = "buttonCustomApply";
            buttonCustomApply.Size = new Size(116, 29);
            buttonCustomApply.TabIndex = 26;
            buttonCustomApply.Text = "Apply custom filter";
            buttonCustomApply.UseVisualStyleBackColor = true;
            buttonCustomApply.Click += buttonCustomApply_Click;
            // 
            // buttonCustomSave
            // 
            buttonCustomSave.Location = new Point(10, 391);
            buttonCustomSave.Name = "buttonCustomSave";
            buttonCustomSave.Size = new Size(116, 29);
            buttonCustomSave.TabIndex = 27;
            buttonCustomSave.Text = "Save custom filter";
            buttonCustomSave.UseVisualStyleBackColor = true;
            buttonCustomSave.Click += buttonCustomSave_Click;
            // 
            // textBoxCustomName
            // 
            textBoxCustomName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCustomName.Location = new Point(132, 395);
            textBoxCustomName.Name = "textBoxCustomName";
            textBoxCustomName.Size = new Size(80, 23);
            textBoxCustomName.TabIndex = 28;
            textBoxCustomName.Text = "Custom";
            // 
            // comboBoxFilterPick
            // 
            comboBoxFilterPick.FormattingEnabled = true;
            comboBoxFilterPick.Location = new Point(134, 22);
            comboBoxFilterPick.Name = "comboBoxFilterPick";
            comboBoxFilterPick.Size = new Size(121, 23);
            comboBoxFilterPick.TabIndex = 29;
            // 
            // buttonLoadFilter
            // 
            buttonLoadFilter.Location = new Point(262, 22);
            buttonLoadFilter.Name = "buttonLoadFilter";
            buttonLoadFilter.Size = new Size(75, 23);
            buttonLoadFilter.TabIndex = 30;
            buttonLoadFilter.Text = "Load filter";
            buttonLoadFilter.UseVisualStyleBackColor = true;
            buttonLoadFilter.Click += buttonLoadFilter_Click;
            // 
            // groupBoxCustom
            // 
            groupBoxCustom.BackColor = SystemColors.ControlLight;
            groupBoxCustom.Controls.Add(numericUpDownAnchorY);
            groupBoxCustom.Controls.Add(numericUpDownAnchorX);
            groupBoxCustom.Controls.Add(labelAnchor);
            groupBoxCustom.Controls.Add(labelOffset);
            groupBoxCustom.Controls.Add(labelFactor);
            groupBoxCustom.Controls.Add(textBoxCustomName);
            groupBoxCustom.Controls.Add(textBoxFactor);
            groupBoxCustom.Controls.Add(numericUpDownOffset);
            groupBoxCustom.Controls.Add(labelLoad);
            groupBoxCustom.Controls.Add(labelHeight);
            groupBoxCustom.Controls.Add(buttonGenerateMatrix);
            groupBoxCustom.Controls.Add(buttonLoadFilter);
            groupBoxCustom.Controls.Add(buttonFactor);
            groupBoxCustom.Controls.Add(labelWidth);
            groupBoxCustom.Controls.Add(comboBoxFilterPick);
            groupBoxCustom.Controls.Add(tableLayoutPanelKernel);
            groupBoxCustom.Controls.Add(buttonCustomSave);
            groupBoxCustom.Controls.Add(buttonCustomApply);
            groupBoxCustom.Controls.Add(numericUpDownWidth);
            groupBoxCustom.Controls.Add(numericUpDownHeight);
            groupBoxCustom.Location = new Point(769, 12);
            groupBoxCustom.Name = "groupBoxCustom";
            groupBoxCustom.Size = new Size(344, 426);
            groupBoxCustom.TabIndex = 31;
            groupBoxCustom.TabStop = false;
            groupBoxCustom.Text = "Custom Filter";
            // 
            // numericUpDownAnchorY
            // 
            numericUpDownAnchorY.Location = new Point(278, 101);
            numericUpDownAnchorY.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDownAnchorY.Name = "numericUpDownAnchorY";
            numericUpDownAnchorY.Size = new Size(39, 23);
            numericUpDownAnchorY.TabIndex = 40;
            // 
            // numericUpDownAnchorX
            // 
            numericUpDownAnchorX.Location = new Point(233, 101);
            numericUpDownAnchorX.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDownAnchorX.Name = "numericUpDownAnchorX";
            numericUpDownAnchorX.Size = new Size(39, 23);
            numericUpDownAnchorX.TabIndex = 39;
            // 
            // labelAnchor
            // 
            labelAnchor.AutoSize = true;
            labelAnchor.Location = new Point(147, 103);
            labelAnchor.Name = "labelAnchor";
            labelAnchor.Size = new Size(80, 15);
            labelAnchor.TabIndex = 38;
            labelAnchor.Text = "Anchor (X, Y):";
            // 
            // labelOffset
            // 
            labelOffset.AutoSize = true;
            labelOffset.Location = new Point(147, 79);
            labelOffset.Name = "labelOffset";
            labelOffset.Size = new Size(42, 15);
            labelOffset.TabIndex = 37;
            labelOffset.Text = "Offset:";
            // 
            // labelFactor
            // 
            labelFactor.AutoSize = true;
            labelFactor.Location = new Point(147, 52);
            labelFactor.Name = "labelFactor";
            labelFactor.Size = new Size(43, 15);
            labelFactor.TabIndex = 36;
            labelFactor.Text = "Factor:";
            // 
            // labelLoad
            // 
            labelLoad.AutoSize = true;
            labelLoad.Location = new Point(5, 25);
            labelLoad.Name = "labelLoad";
            labelLoad.Size = new Size(126, 15);
            labelLoad.TabIndex = 34;
            labelLoad.Text = "Choose a filter to load:";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(6, 75);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(80, 15);
            labelHeight.TabIndex = 33;
            labelHeight.Text = "Kernel height:";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(6, 50);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(76, 15);
            labelWidth.TabIndex = 32;
            labelWidth.Text = "Kernel width:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 450);
            Controls.Add(groupBoxCustom);
            Controls.Add(buttonCtrUp);
            Controls.Add(buttonBrightDown);
            Controls.Add(buttonBrightUp);
            Controls.Add(buttonSave);
            Controls.Add(buttonEmboss);
            Controls.Add(buttonEdge);
            Controls.Add(buttonSharp);
            Controls.Add(buttonGauss);
            Controls.Add(buttonBlur);
            Controls.Add(buttonGamma);
            Controls.Add(buttonInv);
            Controls.Add(buttonLoad);
            Controls.Add(pictureBoxBefore);
            Controls.Add(pictureBoxAfter);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Filtering App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBefore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAfter).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOffset).EndInit();
            groupBoxCustom.ResumeLayout(false);
            groupBoxCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnchorY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnchorX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBefore;
        private PictureBox pictureBoxAfter;
        private Button buttonLoad;
        private Button buttonInv;
        private Button buttonGamma;
        private Button buttonEdge;
        private Button buttonSharp;
        private Button buttonGauss;
        private Button buttonBlur;
        private Button buttonEmboss;
        private Button buttonSave;
        private Button buttonBrightDown;
        private Button buttonBrightUp;
        private Button buttonCtrUp;
        private Button buttonGenerateMatrix;
        private TableLayoutPanel tableLayoutPanelKernel;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownHeight;
        private Button buttonFactor;
        private TextBox textBoxFactor;
        private NumericUpDown numericUpDownOffset;
        private Button buttonCustomApply;
        private Button buttonCustomSave;
        private TextBox textBoxCustomName;
        private ComboBox comboBoxFilterPick;
        private Button buttonLoadFilter;
        private GroupBox groupBoxCustom;
        private Label labelHeight;
        private Label labelWidth;
        private Label labelLoad;
        private Label labelOffset;
        private Label labelFactor;
        private NumericUpDown numericUpDownAnchorY;
        private NumericUpDown numericUpDownAnchorX;
        private Label labelAnchor;
    }
}