using System.Drawing;
namespace Flexxi
{
    partial class RenameControl
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
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.OriginalName = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.Groesse = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Button();
            this.Width = new System.Windows.Forms.Button();
            this.Height = new System.Windows.Forms.Button();
            this.BDate = new System.Windows.Forms.Button();
            this.BTime = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.Button();
            this.Hour = new System.Windows.Forms.Button();
            this.Minute = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LeadingZeros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateLeadingZeros = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.groupBox3);
            this.flowLayoutPanel4.Controls.Add(this.groupBox4);
            this.flowLayoutPanel4.Controls.Add(this.groupBox1);
            this.flowLayoutPanel4.Controls.Add(this.groupBox2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(170, 589);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NameField);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name Pattern";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(6, 19);
            this.NameField.Margin = new System.Windows.Forms.Padding(10);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(156, 20);
            this.NameField.TabIndex = 0;
            this.NameField.Tag = "NoTranslate";
            this.NameField.Text = "[OriginalName]";
            this.NameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            this.NameField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameField_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel2);
            this.groupBox4.Location = new System.Drawing.Point(3, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(165, 269);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.OriginalName);
            this.flowLayoutPanel2.Controls.Add(this.Counter);
            this.flowLayoutPanel2.Controls.Add(this.Groesse);
            this.flowLayoutPanel2.Controls.Add(this.Type);
            this.flowLayoutPanel2.Controls.Add(this.Width);
            this.flowLayoutPanel2.Controls.Add(this.Height);
            this.flowLayoutPanel2.Controls.Add(this.BDate);
            this.flowLayoutPanel2.Controls.Add(this.BTime);
            this.flowLayoutPanel2.Controls.Add(this.Year);
            this.flowLayoutPanel2.Controls.Add(this.Month);
            this.flowLayoutPanel2.Controls.Add(this.Day);
            this.flowLayoutPanel2.Controls.Add(this.Hour);
            this.flowLayoutPanel2.Controls.Add(this.Minute);
            this.flowLayoutPanel2.Controls.Add(this.Second);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 252);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // OriginalName
            // 
            this.OriginalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OriginalName.Location = new System.Drawing.Point(1, 2);
            this.OriginalName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.OriginalName.Name = "OriginalName";
            this.OriginalName.Size = new System.Drawing.Size(78, 32);
            this.OriginalName.TabIndex = 2;
            this.OriginalName.Text = "OriginalName";
            this.OriginalName.UseVisualStyleBackColor = true;
            this.OriginalName.Click += new System.EventHandler(this.OriginalName_Click);
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(81, 2);
            this.Counter.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(78, 32);
            this.Counter.TabIndex = 1;
            this.Counter.Text = "Counter";
            this.Counter.UseVisualStyleBackColor = true;
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // Groesse
            // 
            this.Groesse.Location = new System.Drawing.Point(1, 38);
            this.Groesse.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Groesse.Name = "Groesse";
            this.Groesse.Size = new System.Drawing.Size(78, 32);
            this.Groesse.TabIndex = 1;
            this.Groesse.Text = "Size";
            this.Groesse.UseVisualStyleBackColor = true;
            this.Groesse.Click += new System.EventHandler(this.Size_Click);
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(81, 38);
            this.Type.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(78, 32);
            this.Type.TabIndex = 0;
            this.Type.Text = "Type";
            this.Type.UseVisualStyleBackColor = true;
            this.Type.Click += new System.EventHandler(this.Type_Click);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(1, 74);
            this.Width.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(78, 32);
            this.Width.TabIndex = 5;
            this.Width.Text = "Width";
            this.Width.UseVisualStyleBackColor = true;
            this.Width.Click += new System.EventHandler(this.Width_Click);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(81, 74);
            this.Height.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(78, 32);
            this.Height.TabIndex = 6;
            this.Height.Text = "Height";
            this.Height.UseVisualStyleBackColor = true;
            this.Height.Click += new System.EventHandler(this.Height_Click);
            // 
            // BDate
            // 
            this.BDate.Location = new System.Drawing.Point(1, 110);
            this.BDate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(78, 32);
            this.BDate.TabIndex = 3;
            this.BDate.Text = "Date";
            this.BDate.UseVisualStyleBackColor = true;
            this.BDate.Click += new System.EventHandler(this.BDate_Click);
            // 
            // BTime
            // 
            this.BTime.Location = new System.Drawing.Point(81, 110);
            this.BTime.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BTime.Name = "BTime";
            this.BTime.Size = new System.Drawing.Size(78, 32);
            this.BTime.TabIndex = 4;
            this.BTime.Text = "Time";
            this.BTime.UseVisualStyleBackColor = true;
            this.BTime.Click += new System.EventHandler(this.BTime_Click);
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(1, 146);
            this.Year.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(78, 32);
            this.Year.TabIndex = 1;
            this.Year.Text = "Year";
            this.Year.UseVisualStyleBackColor = true;
            this.Year.Click += new System.EventHandler(this.Year_Click);
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(81, 146);
            this.Month.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(78, 32);
            this.Month.TabIndex = 1;
            this.Month.Text = "Month";
            this.Month.UseVisualStyleBackColor = true;
            this.Month.Click += new System.EventHandler(this.Month_Click);
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(1, 182);
            this.Day.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(78, 32);
            this.Day.TabIndex = 1;
            this.Day.Text = "Day";
            this.Day.UseVisualStyleBackColor = true;
            this.Day.Click += new System.EventHandler(this.Day_Click);
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(81, 182);
            this.Hour.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(78, 32);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "Hour";
            this.Hour.UseVisualStyleBackColor = true;
            this.Hour.Click += new System.EventHandler(this.Hour_Click);
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(1, 218);
            this.Minute.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(78, 32);
            this.Minute.TabIndex = 1;
            this.Minute.Text = "Minute";
            this.Minute.UseVisualStyleBackColor = true;
            this.Minute.Click += new System.EventHandler(this.Minute_Click);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(81, 218);
            this.Second.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(78, 32);
            this.Second.TabIndex = 1;
            this.Second.Text = "Second";
            this.Second.UseVisualStyleBackColor = true;
            this.Second.Click += new System.EventHandler(this.Second_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 163);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counter";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.Start);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.Length);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.LeadingZeros);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.Step);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 144);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starts at";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(84, 3);
            this.Start.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 20);
            this.Start.TabIndex = 0;
            this.Start.Tag = "NoTranslate";
            this.Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Start.ValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Length";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(84, 33);
            this.Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(75, 20);
            this.Length.TabIndex = 0;
            this.Length.Tag = "NoTranslate";
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Length.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Length.ValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(75, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Leading zeros";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LeadingZeros
            // 
            this.LeadingZeros.FormattingEnabled = true;
            this.LeadingZeros.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.LeadingZeros.Location = new System.Drawing.Point(84, 63);
            this.LeadingZeros.Name = "LeadingZeros";
            this.LeadingZeros.Size = new System.Drawing.Size(75, 21);
            this.LeadingZeros.TabIndex = 4;
            this.LeadingZeros.Text = "Yes";
            this.LeadingZeros.SelectedValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(84, 93);
            this.Step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(75, 20);
            this.Step.TabIndex = 0;
            this.Step.Tag = "NoTranslate";
            this.Step.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Step.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Step.ValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(3, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.Date);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.DateLeadingZeros);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(162, 65);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Size = new System.Drawing.Size(75, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Date
            // 
            this.Date.FormattingEnabled = true;
            this.Date.Items.AddRange(new object[] {
            "Acquisition",
            "Now"});
            this.Date.Location = new System.Drawing.Point(84, 3);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(75, 21);
            this.Date.TabIndex = 4;
            this.Date.Tag = "";
            this.Date.Text = "Acquisition";
            this.Date.SelectedValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 30);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(75, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Leading zeros";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DateLeadingZeros
            // 
            this.DateLeadingZeros.FormattingEnabled = true;
            this.DateLeadingZeros.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.DateLeadingZeros.Location = new System.Drawing.Point(84, 33);
            this.DateLeadingZeros.Name = "DateLeadingZeros";
            this.DateLeadingZeros.Size = new System.Drawing.Size(75, 21);
            this.DateLeadingZeros.TabIndex = 4;
            this.DateLeadingZeros.Text = "Yes";
            this.DateLeadingZeros.SelectedValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // RenameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel4);
            this.Name = "RenameControl";
            this.Size = new System.Drawing.Size(170, 675);
            this.SizeChanged += new System.EventHandler(this.RenameControl_SizeChanged);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Type;
        private System.Windows.Forms.Button Hour;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.Button Groesse;
        private System.Windows.Forms.Button Year;
        private System.Windows.Forms.Button Month;
        private System.Windows.Forms.Button Day;
        private System.Windows.Forms.Button Minute;
        private System.Windows.Forms.Button Second;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.NumericUpDown Step;
        private System.Windows.Forms.NumericUpDown Start;
        private System.Windows.Forms.ComboBox LeadingZeros;
        private System.Windows.Forms.ComboBox DateLeadingZeros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OriginalName;
        private System.Windows.Forms.Button BDate;
        private System.Windows.Forms.Button BTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button Width;
        private System.Windows.Forms.Button Height;
    }
}