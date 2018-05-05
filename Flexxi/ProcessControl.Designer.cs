namespace Flexxi
{
    partial class ProcessControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProcessBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatusPercent = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Label();
            this.DisplayModifiedImages = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProcessBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel1.Size = new System.Drawing.Size(881, 23);
            this.panel1.TabIndex = 0;
            // 
            // ProcessBar
            // 
            this.ProcessBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessBar.Location = new System.Drawing.Point(5, 5);
            this.ProcessBar.Name = "ProcessBar";
            this.ProcessBar.Size = new System.Drawing.Size(871, 18);
            this.ProcessBar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StatusPercent);
            this.panel2.Controls.Add(this.RemainingTime);
            this.panel2.Controls.Add(this.DisplayModifiedImages);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 30);
            this.panel2.TabIndex = 1;
            this.panel2.Tag = "NoTranslate";
            // 
            // StatusPercent
            // 
            this.StatusPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusPercent.Location = new System.Drawing.Point(150, 0);
            this.StatusPercent.Name = "StatusPercent";
            this.StatusPercent.Size = new System.Drawing.Size(625, 30);
            this.StatusPercent.TabIndex = 2;
            this.StatusPercent.Tag = "NoTranslate";
            this.StatusPercent.Text = "0% (0/0)";
            this.StatusPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSize = true;
            this.RemainingTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.RemainingTime.Location = new System.Drawing.Point(775, 0);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Padding = new System.Windows.Forms.Padding(3);
            this.RemainingTime.Size = new System.Drawing.Size(106, 19);
            this.RemainingTime.TabIndex = 1;
            this.RemainingTime.Tag = "NoTranslate";
            this.RemainingTime.Text = "3 minutes remaining";
            this.RemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayModifiedImages
            // 
            this.DisplayModifiedImages.AutoSize = true;
            this.DisplayModifiedImages.Checked = true;
            this.DisplayModifiedImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayModifiedImages.Dock = System.Windows.Forms.DockStyle.Left;
            this.DisplayModifiedImages.Location = new System.Drawing.Point(0, 0);
            this.DisplayModifiedImages.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayModifiedImages.Name = "DisplayModifiedImages";
            this.DisplayModifiedImages.Padding = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.DisplayModifiedImages.Size = new System.Drawing.Size(150, 30);
            this.DisplayModifiedImages.TabIndex = 0;
            this.DisplayModifiedImages.Text = "Display modified images";
            this.DisplayModifiedImages.UseVisualStyleBackColor = true;
            // 
            // ProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProcessControl";
            this.Size = new System.Drawing.Size(881, 53);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar ProcessBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RemainingTime;
        private System.Windows.Forms.CheckBox DisplayModifiedImages;
        private System.Windows.Forms.Label StatusPercent;

    }
}
