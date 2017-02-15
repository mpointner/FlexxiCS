namespace ImageFrame
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioPropOriginal = new System.Windows.Forms.RadioButton();
            this.Radio43 = new System.Windows.Forms.RadioButton();
            this.Radio32 = new System.Windows.Forms.RadioButton();
            this.Radio169 = new System.Windows.Forms.RadioButton();
            this.RadioIgnore = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioSizeOriginal = new System.Windows.Forms.RadioButton();
            this.Radio1024 = new System.Windows.Forms.RadioButton();
            this.Radio640 = new System.Windows.Forms.RadioButton();
            this.Radio320 = new System.Windows.Forms.RadioButton();
            this.Radio160 = new System.Windows.Forms.RadioButton();
            this.RadioOther = new System.Windows.Forms.RadioButton();
            this.ManualWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ManualHeight = new System.Windows.Forms.NumericUpDown();
            this.FlipSize = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.FlipSize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(168, 447);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(6, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proportionally";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.RadioPropOriginal);
            this.flowLayoutPanel3.Controls.Add(this.Radio43);
            this.flowLayoutPanel3.Controls.Add(this.Radio32);
            this.flowLayoutPanel3.Controls.Add(this.Radio169);
            this.flowLayoutPanel3.Controls.Add(this.RadioIgnore);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(151, 125);
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
            this.RadioPropOriginal.Tag = "1";
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
            this.Radio43.Tag = "2";
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
            this.Radio32.Tag = "3";
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
            this.Radio169.Tag = "4";
            this.Radio169.Text = "16:9";
            this.Radio169.UseVisualStyleBackColor = true;
            this.Radio169.Click += new System.EventHandler(this.RadioProp_Click);
            // 
            // RadioIgnore
            // 
            this.RadioIgnore.AutoSize = true;
            this.RadioIgnore.Location = new System.Drawing.Point(3, 95);
            this.RadioIgnore.Name = "RadioIgnore";
            this.RadioIgnore.Size = new System.Drawing.Size(55, 17);
            this.RadioIgnore.TabIndex = 4;
            this.RadioIgnore.Tag = "5";
            this.RadioIgnore.Text = "Ignore";
            this.RadioIgnore.UseVisualStyleBackColor = true;
            this.RadioIgnore.Click += new System.EventHandler(this.RadioProp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 164);
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
            this.flowLayoutPanel4.Controls.Add(this.RadioOther);
            this.flowLayoutPanel4.Controls.Add(this.ManualWidth);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.ManualHeight);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(151, 145);
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
            this.Radio160.Text = "160x120";
            this.Radio160.UseVisualStyleBackColor = true;
            this.Radio160.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // RadioOther
            // 
            this.RadioOther.AutoSize = true;
            this.RadioOther.Location = new System.Drawing.Point(3, 118);
            this.RadioOther.Name = "RadioOther";
            this.RadioOther.Size = new System.Drawing.Size(14, 13);
            this.RadioOther.TabIndex = 4;
            this.RadioOther.UseVisualStyleBackColor = true;
            this.RadioOther.Click += new System.EventHandler(this.RadioSize_Click);
            // 
            // ManualWidth
            // 
            this.ManualWidth.Location = new System.Drawing.Point(23, 118);
            this.ManualWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ManualWidth.Name = "ManualWidth";
            this.ManualWidth.Size = new System.Drawing.Size(50, 20);
            this.ManualWidth.TabIndex = 6;
            this.ManualWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ManualWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.ManualWidth.Click += new System.EventHandler(this.ManualSize_Click);
            this.ManualWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ManualSize_KeyUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(79, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ManualHeight
            // 
            this.ManualHeight.Location = new System.Drawing.Point(95, 118);
            this.ManualHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ManualHeight.Name = "ManualHeight";
            this.ManualHeight.Size = new System.Drawing.Size(50, 20);
            this.ManualHeight.TabIndex = 7;
            this.ManualHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ManualHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.ManualHeight.Click += new System.EventHandler(this.ManualSize_Click);
            this.ManualHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ManualSize_KeyUp);
            // 
            // FlipSize
            // 
            this.FlipSize.AutoSize = true;
            this.FlipSize.Checked = true;
            this.FlipSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FlipSize.Location = new System.Drawing.Point(13, 333);
            this.FlipSize.Margin = new System.Windows.Forms.Padding(10);
            this.FlipSize.Name = "FlipSize";
            this.FlipSize.Size = new System.Drawing.Size(147, 17);
            this.FlipSize.TabIndex = 2;
            this.FlipSize.Text = "Flip Size for Portai Images";
            this.FlipSize.UseVisualStyleBackColor = true;
            // 
            // ResizeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ResizeControl";
            this.Size = new System.Drawing.Size(168, 447);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton RadioPropOriginal;
        private System.Windows.Forms.RadioButton Radio43;
        private System.Windows.Forms.RadioButton Radio32;
        private System.Windows.Forms.RadioButton Radio169;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox FlipSize;
        private System.Windows.Forms.RadioButton RadioIgnore;
        private System.Windows.Forms.RadioButton Radio1024;
        private System.Windows.Forms.RadioButton Radio640;
        private System.Windows.Forms.RadioButton Radio160;
        private System.Windows.Forms.RadioButton Radio320;
        private System.Windows.Forms.RadioButton RadioOther;
        private System.Windows.Forms.NumericUpDown ManualWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ManualHeight;
        private System.Windows.Forms.RadioButton RadioSizeOriginal;
    }
}