namespace Flexxi
{
    partial class ResizeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeControl));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioSizeOriginal = new System.Windows.Forms.RadioButton();
            this.Radio1024 = new System.Windows.Forms.RadioButton();
            this.Radio640 = new System.Windows.Forms.RadioButton();
            this.Radio320 = new System.Windows.Forms.RadioButton();
            this.Radio160 = new System.Windows.Forms.RadioButton();
            this.Radio120 = new System.Windows.Forms.RadioButton();
            this.RadioOther = new System.Windows.Forms.RadioButton();
            this.ManualWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ManualHeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelResizeMode = new System.Windows.Forms.FlowLayoutPanel();
            this.radioResizeModeFit = new System.Windows.Forms.RadioButton();
            this.radioResizeModeSprain = new System.Windows.Forms.RadioButton();
            this.radioResizeModeFill = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelFillColor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonChangeFillColor = new System.Windows.Forms.Button();
            this.labelFillColor = new System.Windows.Forms.Label();
            this.flowLayoutOpacity = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDownOpacity = new System.Windows.Forms.NumericUpDown();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioMaximumQuality = new System.Windows.Forms.RadioButton();
            this.RadioReduceQuality = new System.Windows.Forms.RadioButton();
            this.numericQuality = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPropotionality = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioPropOriginal = new System.Windows.Forms.RadioButton();
            this.Radio43 = new System.Windows.Forms.RadioButton();
            this.Radio32 = new System.Windows.Forms.RadioButton();
            this.Radio169 = new System.Windows.Forms.RadioButton();
            this.FlipSize = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualHeight)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanelResizeMode.SuspendLayout();
            this.flowLayoutPanelFillColor.SuspendLayout();
            this.flowLayoutOpacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpacity)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).BeginInit();
            this.groupBoxPropotionality.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox4);
            this.flowLayoutPanel2.Controls.Add(this.groupBox3);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxPropotionality);
            this.flowLayoutPanel2.Controls.Add(this.FlipSize);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(170, 702);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.RadioSizeOriginal);
            this.flowLayoutPanel4.Controls.Add(this.Radio1024);
            this.flowLayoutPanel4.Controls.Add(this.Radio640);
            this.flowLayoutPanel4.Controls.Add(this.Radio320);
            this.flowLayoutPanel4.Controls.Add(this.Radio160);
            this.flowLayoutPanel4.Controls.Add(this.Radio120);
            this.flowLayoutPanel4.Controls.Add(this.RadioOther);
            this.flowLayoutPanel4.Controls.Add(this.ManualWidth);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.ManualHeight);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(154, 182);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // RadioSizeOriginal
            // 
            this.RadioSizeOriginal.AutoSize = true;
            this.RadioSizeOriginal.Checked = true;
            this.RadioSizeOriginal.Location = new System.Drawing.Point(3, 3);
            this.RadioSizeOriginal.Name = "RadioSizeOriginal";
            this.RadioSizeOriginal.Size = new System.Drawing.Size(60, 17);
            this.RadioSizeOriginal.TabIndex = 9;
            this.RadioSizeOriginal.TabStop = true;
            this.RadioSizeOriginal.Text = "Original";
            this.RadioSizeOriginal.UseVisualStyleBackColor = true;
            this.RadioSizeOriginal.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // Radio1024
            // 
            this.Radio1024.Location = new System.Drawing.Point(3, 26);
            this.Radio1024.Name = "Radio1024";
            this.Radio1024.Size = new System.Drawing.Size(104, 17);
            this.Radio1024.TabIndex = 0;
            this.Radio1024.Tag = "NoTranslate";
            this.Radio1024.Text = "1024x768";
            this.Radio1024.UseVisualStyleBackColor = true;
            this.Radio1024.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // Radio640
            // 
            this.Radio640.Location = new System.Drawing.Point(3, 49);
            this.Radio640.Name = "Radio640";
            this.Radio640.Size = new System.Drawing.Size(104, 17);
            this.Radio640.TabIndex = 1;
            this.Radio640.Tag = "NoTranslate";
            this.Radio640.Text = "640x480";
            this.Radio640.UseVisualStyleBackColor = true;
            this.Radio640.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // Radio320
            // 
            this.Radio320.Location = new System.Drawing.Point(3, 72);
            this.Radio320.Name = "Radio320";
            this.Radio320.Size = new System.Drawing.Size(104, 17);
            this.Radio320.TabIndex = 3;
            this.Radio320.Tag = "NoTranslate";
            this.Radio320.Text = "320x240";
            this.Radio320.UseVisualStyleBackColor = true;
            this.Radio320.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // Radio160
            // 
            this.Radio160.Location = new System.Drawing.Point(3, 95);
            this.Radio160.Name = "Radio160";
            this.Radio160.Size = new System.Drawing.Size(140, 17);
            this.Radio160.TabIndex = 2;
            this.Radio160.Tag = "NoTranslate";
            this.Radio160.Text = "160x120";
            this.Radio160.UseVisualStyleBackColor = true;
            this.Radio160.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // Radio120
            // 
            this.Radio120.Location = new System.Drawing.Point(3, 118);
            this.Radio120.Name = "Radio120";
            this.Radio120.Size = new System.Drawing.Size(140, 17);
            this.Radio120.TabIndex = 10;
            this.Radio120.Tag = "NoTranslate";
            this.Radio120.Text = "120x90";
            this.Radio120.UseVisualStyleBackColor = true;
            this.Radio120.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // RadioOther
            // 
            this.RadioOther.AutoSize = true;
            this.RadioOther.Location = new System.Drawing.Point(3, 141);
            this.RadioOther.Name = "RadioOther";
            this.RadioOther.Size = new System.Drawing.Size(14, 13);
            this.RadioOther.TabIndex = 4;
            this.RadioOther.Tag = "NoTranslate";
            this.RadioOther.UseVisualStyleBackColor = true;
            this.RadioOther.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // ManualWidth
            // 
            this.ManualWidth.Location = new System.Drawing.Point(23, 141);
            this.ManualWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ManualWidth.Name = "ManualWidth";
            this.ManualWidth.Size = new System.Drawing.Size(50, 20);
            this.ManualWidth.TabIndex = 6;
            this.ManualWidth.Tag = "NoTranslate";
            this.ManualWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ManualWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.ManualWidth.ValueChanged += new System.EventHandler(this.ManualSize_ValueChanged);
            this.ManualWidth.Click += new System.EventHandler(this.ManualSize_Click);
            this.ManualWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManualSize_KeyDown);
            this.ManualWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ManualSize_KeyUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(76, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 17);
            this.label1.TabIndex = 8;
            this.label1.Tag = "NoTranslate";
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ManualHeight
            // 
            this.ManualHeight.Location = new System.Drawing.Point(89, 141);
            this.ManualHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ManualHeight.Name = "ManualHeight";
            this.ManualHeight.Size = new System.Drawing.Size(50, 20);
            this.ManualHeight.TabIndex = 7;
            this.ManualHeight.Tag = "NoTranslate";
            this.ManualHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ManualHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.ManualHeight.ValueChanged += new System.EventHandler(this.ManualSize_ValueChanged);
            this.ManualHeight.Click += new System.EventHandler(this.ManualSize_Click);
            this.ManualHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManualSize_KeyDown);
            this.ManualHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ManualSize_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanelResizeMode);
            this.groupBox4.Location = new System.Drawing.Point(6, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 223);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resize Mode";
            // 
            // flowLayoutPanelResizeMode
            // 
            this.flowLayoutPanelResizeMode.Controls.Add(this.radioResizeModeFit);
            this.flowLayoutPanelResizeMode.Controls.Add(this.radioResizeModeSprain);
            this.flowLayoutPanelResizeMode.Controls.Add(this.radioResizeModeFill);
            this.flowLayoutPanelResizeMode.Controls.Add(this.flowLayoutPanelFillColor);
            this.flowLayoutPanelResizeMode.Controls.Add(this.flowLayoutOpacity);
            this.flowLayoutPanelResizeMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelResizeMode.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelResizeMode.Name = "flowLayoutPanelResizeMode";
            this.flowLayoutPanelResizeMode.Size = new System.Drawing.Size(154, 204);
            this.flowLayoutPanelResizeMode.TabIndex = 0;
            // 
            // radioResizeModeFit
            // 
            this.radioResizeModeFit.Checked = true;
            this.radioResizeModeFit.Image = ((System.Drawing.Image)(resources.GetObject("radioResizeModeFit.Image")));
            this.radioResizeModeFit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioResizeModeFit.Location = new System.Drawing.Point(3, 0);
            this.radioResizeModeFit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioResizeModeFit.Name = "radioResizeModeFit";
            this.radioResizeModeFit.Size = new System.Drawing.Size(150, 50);
            this.radioResizeModeFit.TabIndex = 0;
            this.radioResizeModeFit.TabStop = true;
            this.radioResizeModeFit.Text = "Fit";
            this.radioResizeModeFit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioResizeModeFit.UseVisualStyleBackColor = true;
            this.radioResizeModeFit.CheckedChanged += new System.EventHandler(this.radioResizeModeFit_CheckedChanged);
            // 
            // radioResizeModeSprain
            // 
            this.radioResizeModeSprain.Image = ((System.Drawing.Image)(resources.GetObject("radioResizeModeSprain.Image")));
            this.radioResizeModeSprain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioResizeModeSprain.Location = new System.Drawing.Point(3, 50);
            this.radioResizeModeSprain.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioResizeModeSprain.Name = "radioResizeModeSprain";
            this.radioResizeModeSprain.Size = new System.Drawing.Size(150, 50);
            this.radioResizeModeSprain.TabIndex = 1;
            this.radioResizeModeSprain.Text = "Sprain";
            this.radioResizeModeSprain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioResizeModeSprain.UseVisualStyleBackColor = true;
            this.radioResizeModeSprain.CheckedChanged += new System.EventHandler(this.radioResizeModeSprain_CheckedChanged);
            // 
            // radioResizeModeFill
            // 
            this.radioResizeModeFill.Image = ((System.Drawing.Image)(resources.GetObject("radioResizeModeFill.Image")));
            this.radioResizeModeFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioResizeModeFill.Location = new System.Drawing.Point(3, 100);
            this.radioResizeModeFill.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.radioResizeModeFill.Name = "radioResizeModeFill";
            this.radioResizeModeFill.Size = new System.Drawing.Size(150, 50);
            this.radioResizeModeFill.TabIndex = 2;
            this.radioResizeModeFill.Text = "Fill";
            this.radioResizeModeFill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioResizeModeFill.UseVisualStyleBackColor = true;
            this.radioResizeModeFill.CheckedChanged += new System.EventHandler(this.radioResizeModeFill_CheckedChanged);
            // 
            // flowLayoutPanelFillColor
            // 
            this.flowLayoutPanelFillColor.Controls.Add(this.buttonChangeFillColor);
            this.flowLayoutPanelFillColor.Controls.Add(this.labelFillColor);
            this.flowLayoutPanelFillColor.Enabled = false;
            this.flowLayoutPanelFillColor.Location = new System.Drawing.Point(20, 150);
            this.flowLayoutPanelFillColor.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.flowLayoutPanelFillColor.Name = "flowLayoutPanelFillColor";
            this.flowLayoutPanelFillColor.Size = new System.Drawing.Size(130, 23);
            this.flowLayoutPanelFillColor.TabIndex = 3;
            // 
            // buttonChangeFillColor
            // 
            this.buttonChangeFillColor.BackColor = System.Drawing.Color.Black;
            this.buttonChangeFillColor.Location = new System.Drawing.Point(0, 0);
            this.buttonChangeFillColor.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChangeFillColor.Name = "buttonChangeFillColor";
            this.buttonChangeFillColor.Size = new System.Drawing.Size(23, 23);
            this.buttonChangeFillColor.TabIndex = 1;
            this.buttonChangeFillColor.UseVisualStyleBackColor = false;
            this.buttonChangeFillColor.Click += new System.EventHandler(this.buttonChangeFillColor_Click);
            // 
            // labelFillColor
            // 
            this.labelFillColor.Location = new System.Drawing.Point(26, 5);
            this.labelFillColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelFillColor.Name = "labelFillColor";
            this.labelFillColor.Size = new System.Drawing.Size(100, 13);
            this.labelFillColor.TabIndex = 0;
            this.labelFillColor.Text = "Fill color";
            // 
            // flowLayoutOpacity
            // 
            this.flowLayoutOpacity.Controls.Add(this.numericUpDownOpacity);
            this.flowLayoutOpacity.Controls.Add(this.labelOpacity);
            this.flowLayoutOpacity.Enabled = false;
            this.flowLayoutOpacity.Location = new System.Drawing.Point(20, 173);
            this.flowLayoutOpacity.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.flowLayoutOpacity.Name = "flowLayoutOpacity";
            this.flowLayoutOpacity.Size = new System.Drawing.Size(130, 26);
            this.flowLayoutOpacity.TabIndex = 4;
            // 
            // numericUpDownOpacity
            // 
            this.numericUpDownOpacity.Location = new System.Drawing.Point(0, 3);
            this.numericUpDownOpacity.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.numericUpDownOpacity.Name = "numericUpDownOpacity";
            this.numericUpDownOpacity.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownOpacity.TabIndex = 1;
            this.numericUpDownOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownOpacity.ValueChanged += new System.EventHandler(this.numericUpDownOpacity_ValueChanged);
            // 
            // labelOpacity
            // 
            this.labelOpacity.Location = new System.Drawing.Point(41, 5);
            this.labelOpacity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(85, 13);
            this.labelOpacity.TabIndex = 0;
            this.labelOpacity.Text = "% Opacity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(6, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quality";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RadioMaximumQuality);
            this.flowLayoutPanel1.Controls.Add(this.RadioReduceQuality);
            this.flowLayoutPanel1.Controls.Add(this.numericQuality);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // RadioMaximumQuality
            // 
            this.RadioMaximumQuality.Checked = true;
            this.RadioMaximumQuality.Location = new System.Drawing.Point(3, 3);
            this.RadioMaximumQuality.Name = "RadioMaximumQuality";
            this.RadioMaximumQuality.Size = new System.Drawing.Size(140, 17);
            this.RadioMaximumQuality.TabIndex = 10;
            this.RadioMaximumQuality.TabStop = true;
            this.RadioMaximumQuality.Text = "Maximum";
            this.RadioMaximumQuality.UseVisualStyleBackColor = true;
            // 
            // RadioReduceQuality
            // 
            this.RadioReduceQuality.AutoSize = true;
            this.RadioReduceQuality.Location = new System.Drawing.Point(3, 26);
            this.RadioReduceQuality.Name = "RadioReduceQuality";
            this.RadioReduceQuality.Size = new System.Drawing.Size(14, 13);
            this.RadioReduceQuality.TabIndex = 4;
            this.RadioReduceQuality.Tag = "NoTranslate";
            this.RadioReduceQuality.UseVisualStyleBackColor = true;
            this.RadioReduceQuality.Click += new System.EventHandler(this.RadioQuality_Click);
            // 
            // numericQuality
            // 
            this.numericQuality.Location = new System.Drawing.Point(23, 23);
            this.numericQuality.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.numericQuality.Name = "numericQuality";
            this.numericQuality.Size = new System.Drawing.Size(50, 20);
            this.numericQuality.TabIndex = 6;
            this.numericQuality.Tag = "NoTranslate";
            this.numericQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericQuality.ValueChanged += new System.EventHandler(this.numericQuality_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(79, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 17);
            this.label2.TabIndex = 8;
            this.label2.Tag = "NoTranslate";
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBoxPropotionality
            // 
            this.groupBoxPropotionality.Controls.Add(this.flowLayoutPanel3);
            this.groupBoxPropotionality.Location = new System.Drawing.Point(6, 519);
            this.groupBoxPropotionality.Name = "groupBoxPropotionality";
            this.groupBoxPropotionality.Size = new System.Drawing.Size(160, 120);
            this.groupBoxPropotionality.TabIndex = 0;
            this.groupBoxPropotionality.TabStop = false;
            this.groupBoxPropotionality.Text = "Aspect Ratio";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.RadioPropOriginal);
            this.flowLayoutPanel3.Controls.Add(this.Radio43);
            this.flowLayoutPanel3.Controls.Add(this.Radio32);
            this.flowLayoutPanel3.Controls.Add(this.Radio169);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(154, 101);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // RadioPropOriginal
            // 
            this.RadioPropOriginal.AutoSize = true;
            this.RadioPropOriginal.Checked = true;
            this.RadioPropOriginal.Location = new System.Drawing.Point(3, 3);
            this.RadioPropOriginal.Name = "RadioPropOriginal";
            this.RadioPropOriginal.Size = new System.Drawing.Size(60, 17);
            this.RadioPropOriginal.TabIndex = 0;
            this.RadioPropOriginal.TabStop = true;
            this.RadioPropOriginal.Tag = "";
            this.RadioPropOriginal.Text = "Original";
            this.RadioPropOriginal.UseVisualStyleBackColor = true;
            this.RadioPropOriginal.Click += new System.EventHandler(this.RadioProp_Click);
            // 
            // Radio43
            // 
            this.Radio43.AutoSize = true;
            this.Radio43.Location = new System.Drawing.Point(3, 26);
            this.Radio43.Name = "Radio43";
            this.Radio43.Size = new System.Drawing.Size(40, 17);
            this.Radio43.TabIndex = 1;
            this.Radio43.Tag = "NoTranslate";
            this.Radio43.Text = "4:3";
            this.Radio43.UseVisualStyleBackColor = true;
            this.Radio43.Click += new System.EventHandler(this.RadioProp_Click);
            // 
            // Radio32
            // 
            this.Radio32.AutoSize = true;
            this.Radio32.Location = new System.Drawing.Point(3, 49);
            this.Radio32.Name = "Radio32";
            this.Radio32.Size = new System.Drawing.Size(40, 17);
            this.Radio32.TabIndex = 2;
            this.Radio32.Tag = "NoTranslate";
            this.Radio32.Text = "3:2";
            this.Radio32.UseVisualStyleBackColor = true;
            this.Radio32.Click += new System.EventHandler(this.RadioProp_Click);
            // 
            // Radio169
            // 
            this.Radio169.AutoSize = true;
            this.Radio169.Location = new System.Drawing.Point(3, 72);
            this.Radio169.Name = "Radio169";
            this.Radio169.Size = new System.Drawing.Size(46, 17);
            this.Radio169.TabIndex = 3;
            this.Radio169.Tag = "NoTranslate";
            this.Radio169.Text = "16:9";
            this.Radio169.UseVisualStyleBackColor = true;
            this.Radio169.Click += new System.EventHandler(this.RadioProp_Click);
            // 
            // FlipSize
            // 
            this.FlipSize.Checked = true;
            this.FlipSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FlipSize.Location = new System.Drawing.Point(8, 647);
            this.FlipSize.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.FlipSize.Name = "FlipSize";
            this.FlipSize.Size = new System.Drawing.Size(160, 40);
            this.FlipSize.TabIndex = 2;
            this.FlipSize.Text = "Switch Size and Aspect Ratio for Portrait Images";
            this.FlipSize.UseVisualStyleBackColor = true;
            this.FlipSize.CheckedChanged += new System.EventHandler(this.FlipSize_CheckedChanged);
            // 
            // ResizeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ResizeControl";
            this.Size = new System.Drawing.Size(170, 705);
            this.SizeChanged += new System.EventHandler(this.ResizeControl_SizeChanged);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualHeight)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanelResizeMode.ResumeLayout(false);
            this.flowLayoutPanelFillColor.ResumeLayout(false);
            this.flowLayoutOpacity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpacity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuality)).EndInit();
            this.groupBoxPropotionality.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxPropotionality;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton RadioPropOriginal;
        private System.Windows.Forms.RadioButton Radio43;
        private System.Windows.Forms.RadioButton Radio32;
        private System.Windows.Forms.RadioButton Radio169;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox FlipSize;
        private System.Windows.Forms.RadioButton Radio1024;
        private System.Windows.Forms.RadioButton Radio640;
        private System.Windows.Forms.RadioButton Radio160;
        private System.Windows.Forms.RadioButton Radio320;
        private System.Windows.Forms.RadioButton RadioOther;
        private System.Windows.Forms.NumericUpDown ManualWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ManualHeight;
        private System.Windows.Forms.RadioButton RadioSizeOriginal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RadioReduceQuality;
        private System.Windows.Forms.NumericUpDown numericQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioMaximumQuality;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelResizeMode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioResizeModeFit;
        private System.Windows.Forms.RadioButton radioResizeModeSprain;
        private System.Windows.Forms.RadioButton radioResizeModeFill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFillColor;
        private System.Windows.Forms.Label labelFillColor;
        private System.Windows.Forms.Button buttonChangeFillColor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutOpacity;
        private System.Windows.Forms.NumericUpDown numericUpDownOpacity;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.RadioButton Radio120;
    }
}