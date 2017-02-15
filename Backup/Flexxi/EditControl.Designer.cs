namespace ImageFrame
{
    partial class EditControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditControl));
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.ButtonResize = new System.Windows.Forms.Button();
            this.ButtonRotate = new System.Windows.Forms.Button();
            this.ButtonRename = new System.Windows.Forms.Button();
            this.ButtonConvert = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonMail = new System.Windows.Forms.Button();
            this.ButtonDropbox = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SendToCheckBox = new System.Windows.Forms.CheckBox();
            this.DragNDropCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.AutoSize = true;
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 3);
            this.SettingsPanel.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(219, 510);
            this.SettingsPanel.TabIndex = 1;
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonStartStop.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStartStop.Image")));
            this.ButtonStartStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonStartStop.Location = new System.Drawing.Point(0, 470);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(70, 40);
            this.ButtonStartStop.TabIndex = 2;
            this.ButtonStartStop.Text = "Start";
            this.ButtonStartStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // ButtonResize
            // 
            this.ButtonResize.Image = ((System.Drawing.Image)(resources.GetObject("ButtonResize.Image")));
            this.ButtonResize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonResize.Location = new System.Drawing.Point(0, 0);
            this.ButtonResize.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ButtonResize.Name = "ButtonResize";
            this.ButtonResize.Size = new System.Drawing.Size(70, 40);
            this.ButtonResize.TabIndex = 0;
            this.ButtonResize.Text = "Resize";
            this.ButtonResize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonResize.UseVisualStyleBackColor = true;
            this.ButtonResize.Click += new System.EventHandler(this.ButtonResize_Click);
            // 
            // ButtonRotate
            // 
            this.ButtonRotate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRotate.Image")));
            this.ButtonRotate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonRotate.Location = new System.Drawing.Point(0, 46);
            this.ButtonRotate.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ButtonRotate.Name = "ButtonRotate";
            this.ButtonRotate.Size = new System.Drawing.Size(70, 40);
            this.ButtonRotate.TabIndex = 1;
            this.ButtonRotate.Text = "Rotate";
            this.ButtonRotate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonRotate.UseVisualStyleBackColor = true;
            this.ButtonRotate.Click += new System.EventHandler(this.ButtonRotate_Click);
            // 
            // ButtonRename
            // 
            this.ButtonRename.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRename.Image")));
            this.ButtonRename.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonRename.Location = new System.Drawing.Point(0, 92);
            this.ButtonRename.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ButtonRename.Name = "ButtonRename";
            this.ButtonRename.Size = new System.Drawing.Size(70, 40);
            this.ButtonRename.TabIndex = 2;
            this.ButtonRename.Text = "Rename";
            this.ButtonRename.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonRename.UseVisualStyleBackColor = true;
            this.ButtonRename.Click += new System.EventHandler(this.ButtonRename_Click);
            // 
            // ButtonConvert
            // 
            this.ButtonConvert.Image = ((System.Drawing.Image)(resources.GetObject("ButtonConvert.Image")));
            this.ButtonConvert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonConvert.Location = new System.Drawing.Point(0, 138);
            this.ButtonConvert.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ButtonConvert.Name = "ButtonConvert";
            this.ButtonConvert.Size = new System.Drawing.Size(70, 40);
            this.ButtonConvert.TabIndex = 6;
            this.ButtonConvert.Text = "Convert";
            this.ButtonConvert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonConvert.UseVisualStyleBackColor = true;
            this.ButtonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSave.Location = new System.Drawing.Point(0, 184);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(70, 40);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save To";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonMail
            // 
            this.ButtonMail.Enabled = false;
            this.ButtonMail.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMail.Image")));
            this.ButtonMail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonMail.Location = new System.Drawing.Point(0, 230);
            this.ButtonMail.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ButtonMail.Name = "ButtonMail";
            this.ButtonMail.Size = new System.Drawing.Size(70, 40);
            this.ButtonMail.TabIndex = 5;
            this.ButtonMail.Text = "Mail";
            this.ButtonMail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonMail.UseVisualStyleBackColor = true;
            this.ButtonMail.Visible = false;
            this.ButtonMail.Click += new System.EventHandler(this.ButtonMail_Click);
            // 
            // ButtonDropbox
            // 
            this.ButtonDropbox.Enabled = false;
            this.ButtonDropbox.Location = new System.Drawing.Point(0, 276);
            this.ButtonDropbox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ButtonDropbox.Name = "ButtonDropbox";
            this.ButtonDropbox.Size = new System.Drawing.Size(70, 40);
            this.ButtonDropbox.TabIndex = 4;
            this.ButtonDropbox.Text = "Dropbox";
            this.ButtonDropbox.UseVisualStyleBackColor = true;
            this.ButtonDropbox.Visible = false;
            this.ButtonDropbox.Click += new System.EventHandler(this.ButtonDropbox_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ButtonResize);
            this.flowLayoutPanel1.Controls.Add(this.ButtonRotate);
            this.flowLayoutPanel1.Controls.Add(this.ButtonRename);
            this.flowLayoutPanel1.Controls.Add(this.ButtonConvert);
            this.flowLayoutPanel1.Controls.Add(this.ButtonSave);
            this.flowLayoutPanel1.Controls.Add(this.ButtonMail);
            this.flowLayoutPanel1.Controls.Add(this.ButtonDropbox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(70, 321);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.DragNDropCheckBox);
            this.MenuPanel.Controls.Add(this.SendToCheckBox);
            this.MenuPanel.Controls.Add(this.ButtonStartStop);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(222, 3);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(70, 510);
            this.MenuPanel.TabIndex = 0;
            // 
            // SendToCheckBox
            // 
            this.SendToCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SendToCheckBox.Checked = true;
            this.SendToCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SendToCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendToCheckBox.Location = new System.Drawing.Point(0, 418);
            this.SendToCheckBox.Name = "SendToCheckBox";
            this.SendToCheckBox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SendToCheckBox.Size = new System.Drawing.Size(70, 52);
            this.SendToCheckBox.TabIndex = 7;
            this.SendToCheckBox.Text = "Send to activated";
            this.SendToCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendToCheckBox.UseVisualStyleBackColor = true;
            this.SendToCheckBox.Click += new System.EventHandler(this.SendToCheckBox_Click);
            // 
            // DragNDropCheckBox
            // 
            this.DragNDropCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DragNDropCheckBox.Checked = true;
            this.DragNDropCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DragNDropCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DragNDropCheckBox.Location = new System.Drawing.Point(0, 370);
            this.DragNDropCheckBox.Name = "DragNDropCheckBox";
            this.DragNDropCheckBox.Size = new System.Drawing.Size(70, 48);
            this.DragNDropCheckBox.TabIndex = 8;
            this.DragNDropCheckBox.Text = "Drag\'n Drop activated";
            this.DragNDropCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DragNDropCheckBox.UseVisualStyleBackColor = true;
            this.DragNDropCheckBox.CheckedChanged += new System.EventHandler(this.DragNDropCheckBox_CheckedChanged);
            // 
            // EditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "EditControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(295, 516);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.Button ButtonResize;
        private System.Windows.Forms.Button ButtonRotate;
        private System.Windows.Forms.Button ButtonRename;
        private System.Windows.Forms.Button ButtonConvert;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonMail;
        private System.Windows.Forms.Button ButtonDropbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.CheckBox SendToCheckBox;
        private System.Windows.Forms.CheckBox DragNDropCheckBox;
    }
}
