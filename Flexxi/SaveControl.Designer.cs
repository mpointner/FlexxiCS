namespace Flexxi
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
            this.groupBoxImages = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DontSave = new System.Windows.Forms.RadioButton();
            this.UseOriginalFolder = new System.Windows.Forms.RadioButton();
            this.CreateSubfolder = new System.Windows.Forms.RadioButton();
            this.PanelSubfolder = new System.Windows.Forms.FlowLayoutPanel();
            this.SubfolderTextBox = new System.Windows.Forms.TextBox();
            this.UseCustomFolder = new System.Windows.Forms.RadioButton();
            this.PanelCustomFolder = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomFolderPath = new System.Windows.Forms.TextBox();
            this.CustomFolderBrowse = new System.Windows.Forms.Button();
            this.groupBoxOtherFiles = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.OtherFilesIgnore = new System.Windows.Forms.RadioButton();
            this.OtherFilesCopy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.DirectoriesIgnore = new System.Windows.Forms.RadioButton();
            this.DirectoriesCopy = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxImages.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.PanelSubfolder.SuspendLayout();
            this.PanelCustomFolder.SuspendLayout();
            this.groupBoxOtherFiles.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxImages);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxOtherFiles);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 412);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxImages
            // 
            this.groupBoxImages.Controls.Add(this.flowLayoutPanel2);
            this.groupBoxImages.Location = new System.Drawing.Point(3, 3);
            this.groupBoxImages.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBoxImages.Name = "groupBoxImages";
            this.groupBoxImages.Size = new System.Drawing.Size(165, 250);
            this.groupBoxImages.TabIndex = 8;
            this.groupBoxImages.TabStop = false;
            this.groupBoxImages.Text = "Save Options";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.DontSave);
            this.flowLayoutPanel2.Controls.Add(this.UseOriginalFolder);
            this.flowLayoutPanel2.Controls.Add(this.CreateSubfolder);
            this.flowLayoutPanel2.Controls.Add(this.PanelSubfolder);
            this.flowLayoutPanel2.Controls.Add(this.UseCustomFolder);
            this.flowLayoutPanel2.Controls.Add(this.PanelCustomFolder);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(159, 231);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // DontSave
            // 
            this.DontSave.AutoSize = true;
            this.DontSave.Location = new System.Drawing.Point(3, 3);
            this.DontSave.Name = "DontSave";
            this.DontSave.Size = new System.Drawing.Size(79, 17);
            this.DontSave.TabIndex = 6;
            this.DontSave.Text = "Don´t Save";
            this.DontSave.UseVisualStyleBackColor = true;
            this.DontSave.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // UseOriginalFolder
            // 
            this.UseOriginalFolder.AutoSize = true;
            this.UseOriginalFolder.Location = new System.Drawing.Point(3, 26);
            this.UseOriginalFolder.Name = "UseOriginalFolder";
            this.UseOriginalFolder.Size = new System.Drawing.Size(114, 17);
            this.UseOriginalFolder.TabIndex = 0;
            this.UseOriginalFolder.Text = "Use Original Folder";
            this.UseOriginalFolder.UseVisualStyleBackColor = true;
            this.UseOriginalFolder.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // CreateSubfolder
            // 
            this.CreateSubfolder.AutoSize = true;
            this.CreateSubfolder.Checked = true;
            this.CreateSubfolder.Location = new System.Drawing.Point(3, 49);
            this.CreateSubfolder.Name = "CreateSubfolder";
            this.CreateSubfolder.Size = new System.Drawing.Size(104, 17);
            this.CreateSubfolder.TabIndex = 2;
            this.CreateSubfolder.TabStop = true;
            this.CreateSubfolder.Text = "Create Subfolder";
            this.CreateSubfolder.UseVisualStyleBackColor = true;
            this.CreateSubfolder.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // PanelSubfolder
            // 
            this.PanelSubfolder.AutoSize = true;
            this.PanelSubfolder.Controls.Add(this.SubfolderTextBox);
            this.PanelSubfolder.Enabled = false;
            this.PanelSubfolder.Location = new System.Drawing.Point(23, 72);
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
            this.SubfolderTextBox.Leave += new System.EventHandler(this.SubfolderTextBox_Leave);
            // 
            // UseCustomFolder
            // 
            this.UseCustomFolder.Location = new System.Drawing.Point(3, 104);
            this.UseCustomFolder.MaximumSize = new System.Drawing.Size(140, 50);
            this.UseCustomFolder.MinimumSize = new System.Drawing.Size(140, 17);
            this.UseCustomFolder.Name = "UseCustomFolder";
            this.UseCustomFolder.Size = new System.Drawing.Size(140, 17);
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
            this.PanelCustomFolder.Location = new System.Drawing.Point(23, 127);
            this.PanelCustomFolder.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.PanelCustomFolder.Name = "PanelCustomFolder";
            this.PanelCustomFolder.Size = new System.Drawing.Size(122, 55);
            this.PanelCustomFolder.TabIndex = 5;
            this.PanelCustomFolder.Leave += new System.EventHandler(this.PanelCustomFolder_Leave);
            // 
            // CustomFolderPath
            // 
            this.CustomFolderPath.Location = new System.Drawing.Point(3, 3);
            this.CustomFolderPath.Name = "CustomFolderPath";
            this.CustomFolderPath.Size = new System.Drawing.Size(116, 20);
            this.CustomFolderPath.TabIndex = 0;
            this.CustomFolderPath.Tag = "NoTranslate";
            // 
            // CustomFolderBrowse
            // 
            this.CustomFolderBrowse.Location = new System.Drawing.Point(45, 29);
            this.CustomFolderBrowse.Name = "CustomFolderBrowse";
            this.CustomFolderBrowse.Size = new System.Drawing.Size(74, 23);
            this.CustomFolderBrowse.TabIndex = 1;
            this.CustomFolderBrowse.Text = "Browse";
            this.CustomFolderBrowse.UseVisualStyleBackColor = true;
            this.CustomFolderBrowse.Click += new System.EventHandler(this.CustomFolderBrowse_Click);
            // 
            // groupBoxOtherFiles
            // 
            this.groupBoxOtherFiles.AutoSize = true;
            this.groupBoxOtherFiles.Controls.Add(this.flowLayoutPanel3);
            this.groupBoxOtherFiles.Location = new System.Drawing.Point(3, 259);
            this.groupBoxOtherFiles.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBoxOtherFiles.MaximumSize = new System.Drawing.Size(165, 120);
            this.groupBoxOtherFiles.MinimumSize = new System.Drawing.Size(165, 60);
            this.groupBoxOtherFiles.Name = "groupBoxOtherFiles";
            this.groupBoxOtherFiles.Size = new System.Drawing.Size(165, 65);
            this.groupBoxOtherFiles.TabIndex = 7;
            this.groupBoxOtherFiles.TabStop = false;
            this.groupBoxOtherFiles.Text = "Other Files than Images";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.OtherFilesIgnore);
            this.flowLayoutPanel3.Controls.Add(this.OtherFilesCopy);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(159, 100);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(159, 41);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(159, 46);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // OtherFilesIgnore
            // 
            this.OtherFilesIgnore.AutoSize = true;
            this.OtherFilesIgnore.Location = new System.Drawing.Point(3, 3);
            this.OtherFilesIgnore.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.OtherFilesIgnore.Name = "OtherFilesIgnore";
            this.OtherFilesIgnore.Size = new System.Drawing.Size(55, 17);
            this.OtherFilesIgnore.TabIndex = 6;
            this.OtherFilesIgnore.Text = "Ignore";
            this.OtherFilesIgnore.UseVisualStyleBackColor = true;
            // 
            // OtherFilesCopy
            // 
            this.OtherFilesCopy.AutoSize = true;
            this.OtherFilesCopy.Checked = true;
            this.OtherFilesCopy.Location = new System.Drawing.Point(3, 26);
            this.OtherFilesCopy.Name = "OtherFilesCopy";
            this.OtherFilesCopy.Size = new System.Drawing.Size(49, 17);
            this.OtherFilesCopy.TabIndex = 0;
            this.OtherFilesCopy.TabStop = true;
            this.OtherFilesCopy.Text = "Copy";
            this.OtherFilesCopy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel4);
            this.groupBox1.Location = new System.Drawing.Point(3, 330);
            this.groupBox1.MaximumSize = new System.Drawing.Size(165, 100);
            this.groupBox1.MinimumSize = new System.Drawing.Size(165, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 65);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.DirectoriesIgnore);
            this.flowLayoutPanel4.Controls.Add(this.DirectoriesCopy);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel4.MaximumSize = new System.Drawing.Size(159, 100);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(159, 38);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(159, 46);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // DirectoriesIgnore
            // 
            this.DirectoriesIgnore.AutoSize = true;
            this.DirectoriesIgnore.Location = new System.Drawing.Point(3, 3);
            this.DirectoriesIgnore.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.DirectoriesIgnore.Name = "DirectoriesIgnore";
            this.DirectoriesIgnore.Size = new System.Drawing.Size(55, 17);
            this.DirectoriesIgnore.TabIndex = 6;
            this.DirectoriesIgnore.Text = "Ignore";
            this.DirectoriesIgnore.UseVisualStyleBackColor = true;
            // 
            // DirectoriesCopy
            // 
            this.DirectoriesCopy.AutoSize = true;
            this.DirectoriesCopy.Checked = true;
            this.DirectoriesCopy.Location = new System.Drawing.Point(3, 26);
            this.DirectoriesCopy.Name = "DirectoriesCopy";
            this.DirectoriesCopy.Size = new System.Drawing.Size(49, 17);
            this.DirectoriesCopy.TabIndex = 0;
            this.DirectoriesCopy.TabStop = true;
            this.DirectoriesCopy.Text = "Copy";
            this.DirectoriesCopy.UseVisualStyleBackColor = true;
            // 
            // SaveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SaveControl";
            this.Size = new System.Drawing.Size(170, 477);
            this.SizeChanged += new System.EventHandler(this.SaveControl_SizeChanged);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxImages.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.PanelSubfolder.ResumeLayout(false);
            this.PanelSubfolder.PerformLayout();
            this.PanelCustomFolder.ResumeLayout(false);
            this.PanelCustomFolder.PerformLayout();
            this.groupBoxOtherFiles.ResumeLayout(false);
            this.groupBoxOtherFiles.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton UseOriginalFolder;
        private System.Windows.Forms.RadioButton CreateSubfolder;
        private System.Windows.Forms.FlowLayoutPanel PanelSubfolder;
        private System.Windows.Forms.TextBox SubfolderTextBox;
        private System.Windows.Forms.RadioButton UseCustomFolder;
        private System.Windows.Forms.FlowLayoutPanel PanelCustomFolder;
        private System.Windows.Forms.TextBox CustomFolderPath;
        private System.Windows.Forms.Button CustomFolderBrowse;
        private System.Windows.Forms.RadioButton DontSave;
        private System.Windows.Forms.GroupBox groupBoxImages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxOtherFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton OtherFilesIgnore;
        private System.Windows.Forms.RadioButton OtherFilesCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton DirectoriesIgnore;
        private System.Windows.Forms.RadioButton DirectoriesCopy;
    }
}
