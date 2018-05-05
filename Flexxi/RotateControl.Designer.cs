namespace Flexxi
{
    partial class RotateControl
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
            this.None = new System.Windows.Forms.RadioButton();
            this.AutoDetect = new System.Windows.Forms.RadioButton();
            this.Manual90 = new System.Windows.Forms.RadioButton();
            this.Manual270 = new System.Windows.Forms.RadioButton();
            this.Manual180 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.None);
            this.flowLayoutPanel2.Controls.Add(this.AutoDetect);
            this.flowLayoutPanel2.Controls.Add(this.Manual90);
            this.flowLayoutPanel2.Controls.Add(this.Manual270);
            this.flowLayoutPanel2.Controls.Add(this.Manual180);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(160, 210);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Checked = true;
            this.None.Location = new System.Drawing.Point(13, 13);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(49, 17);
            this.None.TabIndex = 4;
            this.None.TabStop = true;
            this.None.Text = "none";
            this.None.UseVisualStyleBackColor = true;
            this.None.Click += new System.EventHandler(this.Radio_Click);
            // 
            // AutoDetect
            // 
            this.AutoDetect.AutoSize = true;
            this.AutoDetect.Location = new System.Drawing.Point(13, 36);
            this.AutoDetect.Name = "AutoDetect";
            this.AutoDetect.Size = new System.Drawing.Size(82, 17);
            this.AutoDetect.TabIndex = 0;
            this.AutoDetect.Text = "Auto Detect";
            this.AutoDetect.UseVisualStyleBackColor = true;
            this.AutoDetect.Click += new System.EventHandler(this.Radio_Click);
            // 
            // Manual90
            // 
            this.Manual90.AutoSize = true;
            this.Manual90.Location = new System.Drawing.Point(13, 59);
            this.Manual90.Name = "Manual90";
            this.Manual90.Size = new System.Drawing.Size(91, 17);
            this.Manual90.TabIndex = 1;
            this.Manual90.Text = "90° clockwise";
            this.Manual90.UseVisualStyleBackColor = true;
            this.Manual90.Click += new System.EventHandler(this.Radio_Click);
            // 
            // Manual270
            // 
            this.Manual270.AutoSize = true;
            this.Manual270.Location = new System.Drawing.Point(13, 82);
            this.Manual270.Name = "Manual270";
            this.Manual270.Size = new System.Drawing.Size(108, 17);
            this.Manual270.TabIndex = 3;
            this.Manual270.Text = "90° anticlockwise";
            this.Manual270.UseVisualStyleBackColor = true;
            this.Manual270.Click += new System.EventHandler(this.Radio_Click);
            // 
            // Manual180
            // 
            this.Manual180.AutoSize = true;
            this.Manual180.Location = new System.Drawing.Point(13, 105);
            this.Manual180.Name = "Manual180";
            this.Manual180.Size = new System.Drawing.Size(47, 17);
            this.Manual180.TabIndex = 2;
            this.Manual180.Tag = "NoTranslate";
            this.Manual180.Text = "180°";
            this.Manual180.UseVisualStyleBackColor = true;
            this.Manual180.Click += new System.EventHandler(this.Radio_Click);
            // 
            // RotateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "RotateControl";
            this.Size = new System.Drawing.Size(170, 447);
            this.SizeChanged += new System.EventHandler(this.RotateControl_SizeChanged);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton AutoDetect;
        private System.Windows.Forms.RadioButton Manual90;
        private System.Windows.Forms.RadioButton Manual180;
        private System.Windows.Forms.RadioButton Manual270;
        private System.Windows.Forms.RadioButton None;
    }
}