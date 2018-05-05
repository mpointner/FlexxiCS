namespace Flexxi
{
    partial class TestWindow
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
            this.testUserControl1 = new Flexxi.TestUserControl();
            this.SuspendLayout();
            // 
            // testUserControl1
            // 
            this.testUserControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.testUserControl1.Location = new System.Drawing.Point(0, 0);
            this.testUserControl1.Name = "testUserControl1";
            this.testUserControl1.Size = new System.Drawing.Size(150, 345);
            this.testUserControl1.TabIndex = 0;
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 345);
            this.Controls.Add(this.testUserControl1);
            this.Name = "TestWindow";
            this.Text = "TestWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private TestUserControl testUserControl1;
    }
}