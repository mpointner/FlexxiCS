namespace Flexxi
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConvertList = new System.Windows.Forms.ListBox();
            this.UpperCase = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ConvertList);
            this.flowLayoutPanel1.Controls.Add(this.UpperCase);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 210);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ConvertList
            // 
            this.ConvertList.FormattingEnabled = true;
            this.ConvertList.Location = new System.Drawing.Point(3, 3);
            this.ConvertList.Name = "ConvertList";
            this.ConvertList.Size = new System.Drawing.Size(154, 160);
            this.ConvertList.TabIndex = 1;
            this.ConvertList.Tag = "NoTranslate";
            this.ConvertList.SelectedValueChanged += new System.EventHandler(this.ConvertList_SelectedValueChanged);
            // 
            // UpperCase
            // 
            this.UpperCase.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpperCase.Location = new System.Drawing.Point(3, 169);
            this.UpperCase.Name = "UpperCase";
            this.UpperCase.Size = new System.Drawing.Size(154, 31);
            this.UpperCase.TabIndex = 2;
            this.UpperCase.Text = "Upper Case";
            this.UpperCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperCase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UpperCase.UseVisualStyleBackColor = true;
            this.UpperCase.CheckedChanged += new System.EventHandler(this.UpperCase_CheckedChanged);
            // 
            // ConvertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ConvertControl";
            this.Size = new System.Drawing.Size(170, 430);
            this.SizeChanged += new System.EventHandler(this.ConvertControl_SizeChanged);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ConvertList;
        private System.Windows.Forms.CheckBox UpperCase;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}