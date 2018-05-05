namespace Flexxi
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonResize = new System.Windows.Forms.Button();
            this.ButtonRotate = new System.Windows.Forms.Button();
            this.ButtonRename = new System.Windows.Forms.Button();
            this.ButtonConvert = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonMail = new System.Windows.Forms.Button();
            this.ButtonDropbox = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.SettingsPanel.Size = new System.Drawing.Size(347, 510);
            this.SettingsPanel.TabIndex = 1;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.flowLayoutPanel2);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(350, 3);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(80, 510);
            this.MenuPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ButtonStartStop);
            this.flowLayoutPanel2.Controls.Add(this.ButtonSettings);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 409);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(80, 101);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.Enabled = false;
            this.ButtonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonStartStop.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStartStop.Image")));
            this.ButtonStartStop.Location = new System.Drawing.Point(0, 51);
            this.ButtonStartStop.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(80, 50);
            this.ButtonStartStop.TabIndex = 11;
            this.ButtonStartStop.Text = "Start";
            this.ButtonStartStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSettings.Image")));
            this.ButtonSettings.Location = new System.Drawing.Point(0, 1);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(80, 50);
            this.ButtonSettings.TabIndex = 12;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 252);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ButtonResize
            // 
            this.ButtonResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonResize.Image = ((System.Drawing.Image)(resources.GetObject("ButtonResize.Image")));
            this.ButtonResize.Location = new System.Drawing.Point(0, 0);
            this.ButtonResize.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonResize.Name = "ButtonResize";
            this.ButtonResize.Size = new System.Drawing.Size(80, 50);
            this.ButtonResize.TabIndex = 0;
            this.ButtonResize.Text = "Resize";
            this.ButtonResize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonResize.UseVisualStyleBackColor = true;
            this.ButtonResize.Click += new System.EventHandler(this.ButtonResize_Click);
            // 
            // ButtonRotate
            // 
            this.ButtonRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonRotate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRotate.Image")));
            this.ButtonRotate.Location = new System.Drawing.Point(0, 50);
            this.ButtonRotate.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRotate.Name = "ButtonRotate";
            this.ButtonRotate.Size = new System.Drawing.Size(80, 50);
            this.ButtonRotate.TabIndex = 1;
            this.ButtonRotate.Text = "Rotate";
            this.ButtonRotate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonRotate.UseVisualStyleBackColor = true;
            this.ButtonRotate.Click += new System.EventHandler(this.ButtonRotate_Click);
            // 
            // ButtonRename
            // 
            this.ButtonRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonRename.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRename.Image")));
            this.ButtonRename.Location = new System.Drawing.Point(0, 100);
            this.ButtonRename.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRename.Name = "ButtonRename";
            this.ButtonRename.Size = new System.Drawing.Size(80, 50);
            this.ButtonRename.TabIndex = 2;
            this.ButtonRename.Text = "Rename";
            this.ButtonRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonRename.UseVisualStyleBackColor = true;
            this.ButtonRename.Click += new System.EventHandler(this.ButtonRename_Click);
            // 
            // ButtonConvert
            // 
            this.ButtonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonConvert.Image = ((System.Drawing.Image)(resources.GetObject("ButtonConvert.Image")));
            this.ButtonConvert.Location = new System.Drawing.Point(0, 150);
            this.ButtonConvert.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonConvert.Name = "ButtonConvert";
            this.ButtonConvert.Size = new System.Drawing.Size(80, 50);
            this.ButtonConvert.TabIndex = 6;
            this.ButtonConvert.Text = "Convert";
            this.ButtonConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonConvert.UseVisualStyleBackColor = true;
            this.ButtonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
            this.ButtonSave.Location = new System.Drawing.Point(0, 200);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 50);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save To";
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonMail
            // 
            this.ButtonMail.Location = new System.Drawing.Point(3, 253);
            this.ButtonMail.Name = "ButtonMail";
            this.ButtonMail.Size = new System.Drawing.Size(75, 23);
            this.ButtonMail.TabIndex = 7;
            // 
            // ButtonDropbox
            // 
            this.ButtonDropbox.Location = new System.Drawing.Point(3, 282);
            this.ButtonDropbox.Name = "ButtonDropbox";
            this.ButtonDropbox.Size = new System.Drawing.Size(75, 23);
            this.ButtonDropbox.TabIndex = 8;
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
            this.Size = new System.Drawing.Size(433, 516);
            this.MenuPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button ButtonResize;
        private System.Windows.Forms.Button ButtonRotate;
        private System.Windows.Forms.Button ButtonRename;
        private System.Windows.Forms.Button ButtonConvert;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonMail;
        private System.Windows.Forms.Button ButtonDropbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.Button ButtonSettings;
    }
}
