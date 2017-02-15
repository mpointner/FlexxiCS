namespace ImageFrame
{
    partial class ConvertControl
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
            this.ConvertList = new System.Windows.Forms.ListBox();
            this.UpperCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConvertList
            // 
            this.ConvertList.FormattingEnabled = true;
            this.ConvertList.Location = new System.Drawing.Point(13, 13);
            this.ConvertList.Name = "ConvertList";
            this.ConvertList.Size = new System.Drawing.Size(142, 160);
            this.ConvertList.TabIndex = 1;
            this.ConvertList.SelectedValueChanged += new System.EventHandler(this.ConvertList_SelectedValueChanged);
            // 
            // UpperCase
            // 
            this.UpperCase.AutoSize = true;
            this.UpperCase.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpperCase.Location = new System.Drawing.Point(50, 191);
            this.UpperCase.Name = "UpperCase";
            this.UpperCase.Size = new System.Drawing.Size(67, 31);
            this.UpperCase.TabIndex = 2;
            this.UpperCase.Text = "Upper Case";
            this.UpperCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UpperCase.UseVisualStyleBackColor = true;
            this.UpperCase.CheckedChanged += new System.EventHandler(this.UpperCase_CheckedChanged);
            // 
            // ConvertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpperCase);
            this.Controls.Add(this.ConvertList);
            this.Name = "ConvertControl";
            this.Size = new System.Drawing.Size(168, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ConvertList;
        private System.Windows.Forms.CheckBox UpperCase;
    }
}