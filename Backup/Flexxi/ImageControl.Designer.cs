namespace ImageFrame
{
    partial class ImageControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageControl));
            this.ImageFramePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.FlowPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSizeFit = new System.Windows.Forms.Button();
            this.buttonSizeOriginal = new System.Windows.Forms.Button();
            this.buttonZoomPlus = new System.Windows.Forms.Button();
            this.buttonZoomMinus = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.labelScale = new System.Windows.Forms.Label();
            this.checkBoxScaleProportional = new System.Windows.Forms.CheckBox();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.ScrollPanel = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ImageFramePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.FlowPanelBottom.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            this.ScrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageFramePanel
            // 
            this.ImageFramePanel.Controls.Add(this.pictureBox);
            this.ImageFramePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageFramePanel.Location = new System.Drawing.Point(0, 0);
            this.ImageFramePanel.Name = "ImageFramePanel";
            this.ImageFramePanel.Padding = new System.Windows.Forms.Padding(3);
            this.ImageFramePanel.Size = new System.Drawing.Size(526, 450);
            this.ImageFramePanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(21, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(206, 155);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FlowPanelBottom
            // 
            this.FlowPanelBottom.AutoSize = true;
            this.FlowPanelBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelBottom.Controls.Add(this.buttonSizeFit);
            this.FlowPanelBottom.Controls.Add(this.buttonSizeOriginal);
            this.FlowPanelBottom.Controls.Add(this.buttonZoomPlus);
            this.FlowPanelBottom.Controls.Add(this.buttonZoomMinus);
            this.FlowPanelBottom.Controls.Add(this.ButtonPrevious);
            this.FlowPanelBottom.Controls.Add(this.ButtonNext);
            this.FlowPanelBottom.Controls.Add(this.labelScale);
            this.FlowPanelBottom.Controls.Add(this.checkBoxScaleProportional);
            this.FlowPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowPanelBottom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FlowPanelBottom.Location = new System.Drawing.Point(0, 474);
            this.FlowPanelBottom.Name = "FlowPanelBottom";
            this.FlowPanelBottom.Size = new System.Drawing.Size(526, 44);
            this.FlowPanelBottom.TabIndex = 12;
            // 
            // buttonSizeFit
            // 
            this.buttonSizeFit.AutoSize = true;
            this.buttonSizeFit.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSizeFit.Location = new System.Drawing.Point(3, 3);
            this.buttonSizeFit.Name = "buttonSizeFit";
            this.buttonSizeFit.Size = new System.Drawing.Size(60, 38);
            this.buttonSizeFit.TabIndex = 0;
            this.buttonSizeFit.Tag = "Fit";
            this.buttonSizeFit.Text = "Fit";
            this.buttonSizeFit.UseVisualStyleBackColor = false;
            this.buttonSizeFit.Click += new System.EventHandler(this.SetScaleMode);
            // 
            // buttonSizeOriginal
            // 
            this.buttonSizeOriginal.AutoSize = true;
            this.buttonSizeOriginal.Location = new System.Drawing.Point(69, 3);
            this.buttonSizeOriginal.Name = "buttonSizeOriginal";
            this.buttonSizeOriginal.Size = new System.Drawing.Size(60, 38);
            this.buttonSizeOriginal.TabIndex = 1;
            this.buttonSizeOriginal.Tag = "Original";
            this.buttonSizeOriginal.Text = "Original";
            this.buttonSizeOriginal.UseVisualStyleBackColor = true;
            this.buttonSizeOriginal.Click += new System.EventHandler(this.SetScaleMode);
            // 
            // buttonZoomPlus
            // 
            this.buttonZoomPlus.AutoSize = true;
            this.buttonZoomPlus.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomPlus.Image")));
            this.buttonZoomPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonZoomPlus.Location = new System.Drawing.Point(135, 3);
            this.buttonZoomPlus.Name = "buttonZoomPlus";
            this.buttonZoomPlus.Size = new System.Drawing.Size(43, 38);
            this.buttonZoomPlus.TabIndex = 2;
            this.buttonZoomPlus.Tag = "+25%";
            this.buttonZoomPlus.UseVisualStyleBackColor = true;
            this.buttonZoomPlus.Click += new System.EventHandler(this.SetScaleMode);
            // 
            // buttonZoomMinus
            // 
            this.buttonZoomMinus.AutoSize = true;
            this.buttonZoomMinus.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomMinus.Image")));
            this.buttonZoomMinus.Location = new System.Drawing.Point(184, 3);
            this.buttonZoomMinus.Name = "buttonZoomMinus";
            this.buttonZoomMinus.Size = new System.Drawing.Size(43, 38);
            this.buttonZoomMinus.TabIndex = 3;
            this.buttonZoomMinus.Tag = "-25%";
            this.buttonZoomMinus.UseVisualStyleBackColor = true;
            this.buttonZoomMinus.Click += new System.EventHandler(this.SetScaleMode);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPrevious.Image")));
            this.ButtonPrevious.Location = new System.Drawing.Point(233, 3);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(43, 38);
            this.ButtonPrevious.TabIndex = 5;
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNext.Image")));
            this.ButtonNext.Location = new System.Drawing.Point(282, 3);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(43, 38);
            this.ButtonNext.TabIndex = 5;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // labelScale
            // 
            this.labelScale.Location = new System.Drawing.Point(331, 3);
            this.labelScale.Margin = new System.Windows.Forms.Padding(3);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(60, 38);
            this.labelScale.TabIndex = 1;
            this.labelScale.Text = "100%";
            this.labelScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelScale.Visible = false;
            // 
            // checkBoxScaleProportional
            // 
            this.checkBoxScaleProportional.Checked = true;
            this.checkBoxScaleProportional.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScaleProportional.Location = new System.Drawing.Point(397, 3);
            this.checkBoxScaleProportional.Name = "checkBoxScaleProportional";
            this.checkBoxScaleProportional.Size = new System.Drawing.Size(81, 38);
            this.checkBoxScaleProportional.TabIndex = 4;
            this.checkBoxScaleProportional.Text = "proportional";
            this.checkBoxScaleProportional.UseVisualStyleBackColor = true;
            this.checkBoxScaleProportional.Visible = false;
            this.checkBoxScaleProportional.CheckedChanged += new System.EventHandler(this.checkBoxScaleProportional_CheckedChanged);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.ScrollPanel);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 24);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(526, 450);
            this.ImagePanel.TabIndex = 8;
            // 
            // ScrollPanel
            // 
            this.ScrollPanel.Controls.Add(this.ImageFramePanel);
            this.ScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollPanel.Location = new System.Drawing.Point(0, 0);
            this.ScrollPanel.Name = "ScrollPanel";
            this.ScrollPanel.Size = new System.Drawing.Size(526, 450);
            this.ScrollPanel.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(526, 24);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Select a File";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.FlowPanelBottom);
            this.Controls.Add(this.NameLabel);
            this.Name = "ImageControl";
            this.Size = new System.Drawing.Size(526, 518);
            this.ImageFramePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.FlowPanelBottom.ResumeLayout(false);
            this.FlowPanelBottom.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.ScrollPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ImageFramePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelBottom;
        private System.Windows.Forms.Button buttonSizeFit;
        private System.Windows.Forms.Button buttonSizeOriginal;
        private System.Windows.Forms.Button buttonZoomPlus;
        private System.Windows.Forms.Button buttonZoomMinus;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.CheckBox checkBoxScaleProportional;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Panel ScrollPanel;
        private System.Windows.Forms.Label NameLabel;
    }
}
