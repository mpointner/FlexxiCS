namespace Flexxi
{
    partial class SettingsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.flowLayoutPanelSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.DragNDropCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SendToCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelReportError = new System.Windows.Forms.Label();
            this.textBoxReportError = new System.Windows.Forms.TextBox();
            this.buttonReportErrorSubmit = new System.Windows.Forms.Button();
            this.SkipError = new System.Windows.Forms.CheckBox();
            this.SkipErrorRead = new System.Windows.Forms.CheckBox();
            this.SkipErrorWrite = new System.Windows.Forms.CheckBox();
            this.SkipErrorExists = new System.Windows.Forms.CheckBox();
            this.SkipErrorOverwrite = new System.Windows.Forms.RadioButton();
            this.SkipErrorChange = new System.Windows.Forms.RadioButton();
            this.processControl1 = new Flexxi.ProcessControl();
            this.flowLayoutPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSettings
            // 
            this.flowLayoutPanelSettings.Controls.Add(this.labelVersion);
            this.flowLayoutPanelSettings.Controls.Add(this.languageLabel);
            this.flowLayoutPanelSettings.Controls.Add(this.ComboBoxLanguage);
            this.flowLayoutPanelSettings.Controls.Add(this.DragNDropCheckBox);
            this.flowLayoutPanelSettings.Controls.Add(this.pictureBox1);
            this.flowLayoutPanelSettings.Controls.Add(this.SendToCheckBox);
            this.flowLayoutPanelSettings.Controls.Add(this.pictureBox2);
            this.flowLayoutPanelSettings.Controls.Add(this.labelReportError);
            this.flowLayoutPanelSettings.Controls.Add(this.textBoxReportError);
            this.flowLayoutPanelSettings.Controls.Add(this.buttonReportErrorSubmit);
            this.flowLayoutPanelSettings.Controls.Add(this.SkipError);
            this.flowLayoutPanelSettings.Controls.Add(this.SkipErrorRead);
            this.flowLayoutPanelSettings.Controls.Add(this.SkipErrorWrite);
            this.flowLayoutPanelSettings.Controls.Add(this.SkipErrorExists);
            this.flowLayoutPanelSettings.Controls.Add(this.SkipErrorOverwrite);
            this.flowLayoutPanelSettings.Controls.Add(this.SkipErrorChange);
            this.flowLayoutPanelSettings.Controls.Add(this.processControl1);
            this.flowLayoutPanelSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSettings.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSettings.Name = "flowLayoutPanelSettings";
            this.flowLayoutPanelSettings.Size = new System.Drawing.Size(170, 751);
            this.flowLayoutPanelSettings.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(3, 3);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(167, 13);
            this.labelVersion.TabIndex = 28;
            this.labelVersion.Tag = "NoTranslate";
            this.labelVersion.Text = "Version: In Development";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(3, 24);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(55, 13);
            this.languageLabel.TabIndex = 27;
            this.languageLabel.Text = "Language";
            // 
            // ComboBoxLanguage
            // 
            this.ComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLanguage.FormattingEnabled = true;
            this.ComboBoxLanguage.Location = new System.Drawing.Point(3, 43);
            this.ComboBoxLanguage.Name = "ComboBoxLanguage";
            this.ComboBoxLanguage.Size = new System.Drawing.Size(162, 21);
            this.ComboBoxLanguage.TabIndex = 26;
            this.ComboBoxLanguage.Tag = "NoTranslate";
            this.ComboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguage_SelectedIndexChanged);
            // 
            // DragNDropCheckBox
            // 
            this.DragNDropCheckBox.Checked = true;
            this.DragNDropCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DragNDropCheckBox.Location = new System.Drawing.Point(3, 70);
            this.DragNDropCheckBox.Name = "DragNDropCheckBox";
            this.DragNDropCheckBox.Padding = new System.Windows.Forms.Padding(5);
            this.DragNDropCheckBox.Size = new System.Drawing.Size(162, 30);
            this.DragNDropCheckBox.TabIndex = 11;
            this.DragNDropCheckBox.Text = "Drag\'n Drop activated";
            this.DragNDropCheckBox.UseVisualStyleBackColor = true;
            this.DragNDropCheckBox.CheckedChanged += new System.EventHandler(this.DragNDropCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(19, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 75);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SendToCheckBox
            // 
            this.SendToCheckBox.Checked = true;
            this.SendToCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SendToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendToCheckBox.Location = new System.Drawing.Point(3, 187);
            this.SendToCheckBox.Name = "SendToCheckBox";
            this.SendToCheckBox.Padding = new System.Windows.Forms.Padding(5);
            this.SendToCheckBox.Size = new System.Drawing.Size(162, 30);
            this.SendToCheckBox.TabIndex = 10;
            this.SendToCheckBox.Text = "Send to activated";
            this.SendToCheckBox.UseVisualStyleBackColor = true;
            this.SendToCheckBox.CheckedChanged += new System.EventHandler(this.SendToCheckBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 223);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(19, 3, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 75);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // labelReportError
            // 
            this.labelReportError.Location = new System.Drawing.Point(3, 311);
            this.labelReportError.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelReportError.Name = "labelReportError";
            this.labelReportError.Size = new System.Drawing.Size(162, 13);
            this.labelReportError.TabIndex = 29;
            this.labelReportError.Text = "Report Error";
            // 
            // textBoxReportError
            // 
            this.textBoxReportError.Location = new System.Drawing.Point(3, 327);
            this.textBoxReportError.Multiline = true;
            this.textBoxReportError.Name = "textBoxReportError";
            this.textBoxReportError.Size = new System.Drawing.Size(162, 92);
            this.textBoxReportError.TabIndex = 30;
            this.textBoxReportError.TextChanged += new System.EventHandler(this.textBoxReportError_TextChanged);
            // 
            // buttonReportErrorSubmit
            // 
            this.buttonReportErrorSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportErrorSubmit.Enabled = false;
            this.buttonReportErrorSubmit.Location = new System.Drawing.Point(91, 425);
            this.buttonReportErrorSubmit.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonReportErrorSubmit.Name = "buttonReportErrorSubmit";
            this.buttonReportErrorSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReportErrorSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonReportErrorSubmit.TabIndex = 31;
            this.buttonReportErrorSubmit.Text = "Submit";
            this.buttonReportErrorSubmit.UseVisualStyleBackColor = true;
            this.buttonReportErrorSubmit.Click += new System.EventHandler(this.buttonReportErrorSubmit_Click);
            // 
            // SkipError
            // 
            this.SkipError.Location = new System.Drawing.Point(3, 454);
            this.SkipError.Name = "SkipError";
            this.SkipError.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.SkipError.Size = new System.Drawing.Size(162, 30);
            this.SkipError.TabIndex = 12;
            this.SkipError.Text = "Skip errors and warnings";
            this.SkipError.UseVisualStyleBackColor = true;
            this.SkipError.CheckedChanged += new System.EventHandler(this.SkipErrorCheckBox_CheckedChanged);
            // 
            // SkipErrorRead
            // 
            this.SkipErrorRead.BackColor = System.Drawing.SystemColors.Control;
            this.SkipErrorRead.Checked = true;
            this.SkipErrorRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkipErrorRead.Enabled = false;
            this.SkipErrorRead.Location = new System.Drawing.Point(27, 490);
            this.SkipErrorRead.Margin = new System.Windows.Forms.Padding(27, 3, 3, 3);
            this.SkipErrorRead.MaximumSize = new System.Drawing.Size(138, 63);
            this.SkipErrorRead.MinimumSize = new System.Drawing.Size(119, 17);
            this.SkipErrorRead.Name = "SkipErrorRead";
            this.SkipErrorRead.Size = new System.Drawing.Size(138, 30);
            this.SkipErrorRead.TabIndex = 15;
            this.SkipErrorRead.Text = "If files can´t be read";
            this.SkipErrorRead.UseVisualStyleBackColor = false;
            // 
            // SkipErrorWrite
            // 
            this.SkipErrorWrite.Checked = true;
            this.SkipErrorWrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkipErrorWrite.Enabled = false;
            this.SkipErrorWrite.Location = new System.Drawing.Point(27, 526);
            this.SkipErrorWrite.Margin = new System.Windows.Forms.Padding(27, 3, 3, 3);
            this.SkipErrorWrite.Name = "SkipErrorWrite";
            this.SkipErrorWrite.Size = new System.Drawing.Size(138, 30);
            this.SkipErrorWrite.TabIndex = 25;
            this.SkipErrorWrite.Text = "If files can´t be writen";
            this.SkipErrorWrite.UseVisualStyleBackColor = true;
            // 
            // SkipErrorExists
            // 
            this.SkipErrorExists.Checked = true;
            this.SkipErrorExists.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkipErrorExists.Enabled = false;
            this.SkipErrorExists.Location = new System.Drawing.Point(27, 562);
            this.SkipErrorExists.Margin = new System.Windows.Forms.Padding(27, 3, 3, 3);
            this.SkipErrorExists.Name = "SkipErrorExists";
            this.SkipErrorExists.Size = new System.Drawing.Size(138, 30);
            this.SkipErrorExists.TabIndex = 16;
            this.SkipErrorExists.Text = "If destination file exists";
            this.SkipErrorExists.UseVisualStyleBackColor = true;
            this.SkipErrorExists.CheckedChanged += new System.EventHandler(this.SkipErrorExists_CheckedChanged);
            // 
            // SkipErrorOverwrite
            // 
            this.SkipErrorOverwrite.Checked = true;
            this.SkipErrorOverwrite.Enabled = false;
            this.SkipErrorOverwrite.Location = new System.Drawing.Point(45, 598);
            this.SkipErrorOverwrite.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this.SkipErrorOverwrite.Name = "SkipErrorOverwrite";
            this.SkipErrorOverwrite.Size = new System.Drawing.Size(120, 30);
            this.SkipErrorOverwrite.TabIndex = 17;
            this.SkipErrorOverwrite.TabStop = true;
            this.SkipErrorOverwrite.Text = "always overwrite";
            this.SkipErrorOverwrite.UseVisualStyleBackColor = true;
            // 
            // SkipErrorChange
            // 
            this.SkipErrorChange.BackColor = System.Drawing.SystemColors.Control;
            this.SkipErrorChange.Enabled = false;
            this.flowLayoutPanelSettings.SetFlowBreak(this.SkipErrorChange, true);
            this.SkipErrorChange.Location = new System.Drawing.Point(45, 634);
            this.SkipErrorChange.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this.SkipErrorChange.Name = "SkipErrorChange";
            this.SkipErrorChange.Size = new System.Drawing.Size(120, 30);
            this.SkipErrorChange.TabIndex = 18;
            this.SkipErrorChange.Text = "always change name";
            this.SkipErrorChange.UseVisualStyleBackColor = false;
            // 
            // processControl1
            // 
            this.processControl1.Location = new System.Drawing.Point(176, 3);
            this.processControl1.Name = "processControl1";
            this.processControl1.Size = new System.Drawing.Size(881, 53);
            this.processControl1.TabIndex = 34;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanelSettings);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(170, 827);
            this.SizeChanged += new System.EventHandler(this.SettingsControl_SizeChanged);
            this.flowLayoutPanelSettings.ResumeLayout(false);
            this.flowLayoutPanelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSettings;
        private System.Windows.Forms.CheckBox SkipError;
        private System.Windows.Forms.CheckBox DragNDropCheckBox;
        private System.Windows.Forms.CheckBox SendToCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox SkipErrorRead;
        private System.Windows.Forms.CheckBox SkipErrorExists;
        private System.Windows.Forms.RadioButton SkipErrorOverwrite;
        private System.Windows.Forms.RadioButton SkipErrorChange;
        private System.Windows.Forms.CheckBox SkipErrorWrite;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelReportError;
        private System.Windows.Forms.TextBox textBoxReportError;
        private System.Windows.Forms.Button buttonReportErrorSubmit;
        private ProcessControl processControl1;
    }
}
