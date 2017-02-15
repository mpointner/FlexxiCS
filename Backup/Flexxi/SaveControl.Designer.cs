namespace ImageFrame
{
    partial class SaveControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DontSave = new System.Windows.Forms.RadioButton();
            this.UseOriginalFolder = new System.Windows.Forms.RadioButton();
            this.PanelUseOriginalFolder = new System.Windows.Forms.FlowLayoutPanel();
            this.OverwriteOriginal = new System.Windows.Forms.RadioButton();
            this.CreateCopy = new System.Windows.Forms.RadioButton();
            this.CreateSubfolder = new System.Windows.Forms.RadioButton();
            this.PanelSubfolder = new System.Windows.Forms.FlowLayoutPanel();
            this.SubfolderTextBox = new System.Windows.Forms.TextBox();
            this.UseCustomFolder = new System.Windows.Forms.RadioButton();
            this.PanelCustomFolder = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomFolderPath = new System.Windows.Forms.TextBox();
            this.CustomFolderBrowse = new System.Windows.Forms.Button();
            this.ButtonPrompt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelUseOriginalFolder.SuspendLayout();
            this.PanelSubfolder.SuspendLayout();
            this.PanelCustomFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DontSave);
            this.flowLayoutPanel1.Controls.Add(this.UseOriginalFolder);
            this.flowLayoutPanel1.Controls.Add(this.PanelUseOriginalFolder);
            this.flowLayoutPanel1.Controls.Add(this.CreateSubfolder);
            this.flowLayoutPanel1.Controls.Add(this.PanelSubfolder);
            this.flowLayoutPanel1.Controls.Add(this.UseCustomFolder);
            this.flowLayoutPanel1.Controls.Add(this.PanelCustomFolder);
            this.flowLayoutPanel1.Controls.Add(this.ButtonPrompt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 447);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // DontSave
            // 
            this.DontSave.AutoSize = true;
            this.DontSave.Checked = true;
            this.DontSave.Location = new System.Drawing.Point(13, 13);
            this.DontSave.Name = "DontSave";
            this.DontSave.Size = new System.Drawing.Size(79, 17);
            this.DontSave.TabIndex = 6;
            this.DontSave.TabStop = true;
            this.DontSave.Text = "Don´t Save";
            this.DontSave.UseVisualStyleBackColor = true;
            this.DontSave.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // UseOriginalFolder
            // 
            this.UseOriginalFolder.AutoSize = true;
            this.UseOriginalFolder.Location = new System.Drawing.Point(13, 36);
            this.UseOriginalFolder.Name = "UseOriginalFolder";
            this.UseOriginalFolder.Size = new System.Drawing.Size(114, 17);
            this.UseOriginalFolder.TabIndex = 0;
            this.UseOriginalFolder.Text = "Use Original Folder";
            this.UseOriginalFolder.UseVisualStyleBackColor = true;
            this.UseOriginalFolder.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // PanelUseOriginalFolder
            // 
            this.PanelUseOriginalFolder.AutoSize = true;
            this.PanelUseOriginalFolder.Controls.Add(this.OverwriteOriginal);
            this.PanelUseOriginalFolder.Controls.Add(this.CreateCopy);
            this.PanelUseOriginalFolder.Enabled = false;
            this.PanelUseOriginalFolder.Location = new System.Drawing.Point(33, 59);
            this.PanelUseOriginalFolder.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.PanelUseOriginalFolder.Name = "PanelUseOriginalFolder";
            this.PanelUseOriginalFolder.Size = new System.Drawing.Size(100, 46);
            this.PanelUseOriginalFolder.TabIndex = 1;
            // 
            // OverwriteOriginal
            // 
            this.OverwriteOriginal.AutoSize = true;
            this.OverwriteOriginal.Location = new System.Drawing.Point(3, 3);
            this.OverwriteOriginal.Name = "OverwriteOriginal";
            this.OverwriteOriginal.Size = new System.Drawing.Size(94, 17);
            this.OverwriteOriginal.TabIndex = 0;
            this.OverwriteOriginal.Text = "Overwrite Files";
            this.OverwriteOriginal.UseVisualStyleBackColor = true;
            // 
            // CreateCopy
            // 
            this.CreateCopy.AutoSize = true;
            this.CreateCopy.Checked = true;
            this.CreateCopy.Location = new System.Drawing.Point(3, 26);
            this.CreateCopy.Name = "CreateCopy";
            this.CreateCopy.Size = new System.Drawing.Size(83, 17);
            this.CreateCopy.TabIndex = 1;
            this.CreateCopy.TabStop = true;
            this.CreateCopy.Text = "Create Copy";
            this.CreateCopy.UseVisualStyleBackColor = true;
            // 
            // CreateSubfolder
            // 
            this.CreateSubfolder.AutoSize = true;
            this.CreateSubfolder.Location = new System.Drawing.Point(13, 111);
            this.CreateSubfolder.Name = "CreateSubfolder";
            this.CreateSubfolder.Size = new System.Drawing.Size(104, 17);
            this.CreateSubfolder.TabIndex = 2;
            this.CreateSubfolder.Text = "Create Subfolder";
            this.CreateSubfolder.UseVisualStyleBackColor = true;
            this.CreateSubfolder.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // PanelSubfolder
            // 
            this.PanelSubfolder.AutoSize = true;
            this.PanelSubfolder.Controls.Add(this.SubfolderTextBox);
            this.PanelSubfolder.Enabled = false;
            this.PanelSubfolder.Location = new System.Drawing.Point(33, 134);
            this.PanelSubfolder.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.PanelSubfolder.Name = "PanelSubfolder";
            this.PanelSubfolder.Size = new System.Drawing.Size(122, 26);
            this.PanelSubfolder.TabIndex = 3;
            // 
            // SubfolderTextBox
            // 
            this.SubfolderTextBox.Location = new System.Drawing.Point(3, 3);
            this.SubfolderTextBox.Name = "SubfolderTextBox";
            this.SubfolderTextBox.Size = new System.Drawing.Size(116, 20);
            this.SubfolderTextBox.TabIndex = 0;
            this.SubfolderTextBox.Text = "Resized";
            // 
            // UseCustomFolder
            // 
            this.UseCustomFolder.AutoSize = true;
            this.UseCustomFolder.Location = new System.Drawing.Point(13, 166);
            this.UseCustomFolder.Name = "UseCustomFolder";
            this.UseCustomFolder.Size = new System.Drawing.Size(114, 17);
            this.UseCustomFolder.TabIndex = 4;
            this.UseCustomFolder.Text = "Use Custom Folder";
            this.UseCustomFolder.UseVisualStyleBackColor = true;
            this.UseCustomFolder.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // PanelCustomFolder
            // 
            this.PanelCustomFolder.AutoSize = true;
            this.PanelCustomFolder.Controls.Add(this.CustomFolderPath);
            this.PanelCustomFolder.Controls.Add(this.CustomFolderBrowse);
            this.PanelCustomFolder.Enabled = false;
            this.PanelCustomFolder.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelCustomFolder.Location = new System.Drawing.Point(33, 189);
            this.PanelCustomFolder.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.PanelCustomFolder.Name = "PanelCustomFolder";
            this.PanelCustomFolder.Size = new System.Drawing.Size(122, 55);
            this.PanelCustomFolder.TabIndex = 5;
            // 
            // CustomFolderPath
            // 
            this.CustomFolderPath.Location = new System.Drawing.Point(3, 3);
            this.CustomFolderPath.Name = "CustomFolderPath";
            this.CustomFolderPath.Size = new System.Drawing.Size(116, 20);
            this.CustomFolderPath.TabIndex = 0;
            // 
            // CustomFolderBrowse
            // 
            this.CustomFolderBrowse.Location = new System.Drawing.Point(61, 29);
            this.CustomFolderBrowse.Name = "CustomFolderBrowse";
            this.CustomFolderBrowse.Size = new System.Drawing.Size(58, 23);
            this.CustomFolderBrowse.TabIndex = 1;
            this.CustomFolderBrowse.Text = "Browse";
            this.CustomFolderBrowse.UseVisualStyleBackColor = true;
            this.CustomFolderBrowse.Click += new System.EventHandler(this.CustomFolderBrowse_Click);
            // 
            // ButtonPrompt
            // 
            this.ButtonPrompt.Location = new System.Drawing.Point(13, 250);
            this.ButtonPrompt.Name = "ButtonPrompt";
            this.ButtonPrompt.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrompt.TabIndex = 7;
            this.ButtonPrompt.Text = "Prompt";
            this.ButtonPrompt.UseVisualStyleBackColor = true;
            this.ButtonPrompt.Visible = false;
            this.ButtonPrompt.Click += new System.EventHandler(this.ButtonPrompt_Click);
            // 
            // SaveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SaveControl";
            this.Size = new System.Drawing.Size(168, 447);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.PanelUseOriginalFolder.ResumeLayout(false);
            this.PanelUseOriginalFolder.PerformLayout();
            this.PanelSubfolder.ResumeLayout(false);
            this.PanelSubfolder.PerformLayout();
            this.PanelCustomFolder.ResumeLayout(false);
            this.PanelCustomFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton UseOriginalFolder;
        private System.Windows.Forms.FlowLayoutPanel PanelUseOriginalFolder;
        private System.Windows.Forms.RadioButton OverwriteOriginal;
        private System.Windows.Forms.RadioButton CreateCopy;
        private System.Windows.Forms.RadioButton CreateSubfolder;
        private System.Windows.Forms.FlowLayoutPanel PanelSubfolder;
        private System.Windows.Forms.TextBox SubfolderTextBox;
        private System.Windows.Forms.RadioButton UseCustomFolder;
        private System.Windows.Forms.FlowLayoutPanel PanelCustomFolder;
        private System.Windows.Forms.TextBox CustomFolderPath;
        private System.Windows.Forms.Button CustomFolderBrowse;
        private System.Windows.Forms.RadioButton DontSave;
        private System.Windows.Forms.Button ButtonPrompt;
    }
}
