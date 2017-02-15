namespace ImageFrame
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.ImageControl = new ImageFrame.ImageControl();
            this.ProcessControl = new ImageFrame.ProcessControl();
            this.EditControl = new ImageFrame.EditControl();
            this.InputControl = new ImageFrame.InputControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // ordnerToolStripMenuItem
            // 
            this.ordnerToolStripMenuItem.Name = "ordnerToolStripMenuItem";
            this.ordnerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // dateienToolStripMenuItem
            // 
            this.dateienToolStripMenuItem.Name = "dateienToolStripMenuItem";
            this.dateienToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // selectedToolStripMenuItem1
            // 
            this.selectedToolStripMenuItem1.Name = "selectedToolStripMenuItem1";
            this.selectedToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(87, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(235, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Add";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ImageControl
            // 
            this.ImageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageControl.EditImage = null;
            this.ImageControl.Location = new System.Drawing.Point(150, 0);
            this.ImageControl.Name = "ImageControl";
            this.ImageControl.OrgImage = null;
            this.ImageControl.OrgImageExtension = "";
            this.ImageControl.OrgImageName = "";
            this.ImageControl.OrgImagePath = "";
            this.ImageControl.OrgInputFile = null;
            this.ImageControl.ScaledImage = null;
            this.ImageControl.Size = new System.Drawing.Size(518, 363);
            this.ImageControl.TabIndex = 9;
            // 
            // ProcessControl
            // 
            this.ProcessControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProcessControl.Location = new System.Drawing.Point(150, 363);
            this.ProcessControl.Name = "ProcessControl";
            this.ProcessControl.Size = new System.Drawing.Size(518, 45);
            this.ProcessControl.TabIndex = 8;
            this.ProcessControl.Visible = false;
            // 
            // EditControl
            // 
            this.EditControl.AutoSize = true;
            this.EditControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EditControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.EditControl.Location = new System.Drawing.Point(668, 0);
            this.EditControl.Name = "EditControl";
            this.EditControl.Padding = new System.Windows.Forms.Padding(3);
            this.EditControl.Size = new System.Drawing.Size(76, 408);
            this.EditControl.TabIndex = 6;
            // 
            // InputControl
            // 
            this.InputControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputControl.Location = new System.Drawing.Point(0, 0);
            this.InputControl.MaximumSize = new System.Drawing.Size(400, 10000);
            this.InputControl.MinimumSize = new System.Drawing.Size(50, 0);
            this.InputControl.Name = "InputControl";
            this.InputControl.Size = new System.Drawing.Size(150, 408);
            this.InputControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 408);
            this.Controls.Add(this.ImageControl);
            this.Controls.Add(this.ProcessControl);
            this.Controls.Add(this.EditControl);
            this.Controls.Add(this.InputControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 446);
            this.Name = "MainForm";
            this.Text = "Flexxi - The flexible Image Resizer";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private InputControl InputControl;
        private EditControl EditControl;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private ProcessControl ProcessControl;
        private ImageControl ImageControl;

    }
}

