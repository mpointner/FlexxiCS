using System.Drawing;
namespace ImageFrame
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Type = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.Groesse = new System.Windows.Forms.Button();
            this.OriginalName = new System.Windows.Forms.Button();
            this.BDate = new System.Windows.Forms.Button();
            this.BTime = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.Button();
            this.Hour = new System.Windows.Forms.Button();
            this.Minute = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.LeadingZeros = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.Step = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateLeadingZeros = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.Type);
            this.flowLayoutPanel2.Controls.Add(this.Counter);
            this.flowLayoutPanel2.Controls.Add(this.Groesse);
            this.flowLayoutPanel2.Controls.Add(this.OriginalName);
            this.flowLayoutPanel2.Controls.Add(this.BDate);
            this.flowLayoutPanel2.Controls.Add(this.BTime);
            this.flowLayoutPanel2.Controls.Add(this.Year);
            this.flowLayoutPanel2.Controls.Add(this.Month);
            this.flowLayoutPanel2.Controls.Add(this.Day);
            this.flowLayoutPanel2.Controls.Add(this.Hour);
            this.flowLayoutPanel2.Controls.Add(this.Minute);
            this.flowLayoutPanel2.Controls.Add(this.Second);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(162, 145);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(2, 2);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 2, 1, 2);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(78, 23);
            this.Type.TabIndex = 0;
            this.Type.Text = "Type";
            this.Type.UseVisualStyleBackColor = true;
            this.Type.Click += new System.EventHandler(this.Type_Click);
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(82, 2);
            this.Counter.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(78, 23);
            this.Counter.TabIndex = 1;
            this.Counter.Text = "Counter";
            this.Counter.UseVisualStyleBackColor = true;
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // Groesse
            // 
            this.Groesse.Location = new System.Drawing.Point(2, 29);
            this.Groesse.Margin = new System.Windows.Forms.Padding(2, 2, 1, 2);
            this.Groesse.Name = "Groesse";
            this.Groesse.Size = new System.Drawing.Size(78, 23);
            this.Groesse.TabIndex = 1;
            this.Groesse.Text = "Size";
            this.Groesse.UseVisualStyleBackColor = true;
            this.Groesse.Click += new System.EventHandler(this.Size_Click);
            // 
            // OriginalName
            // 
            this.OriginalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.OriginalName.Location = new System.Drawing.Point(82, 29);
            this.OriginalName.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.OriginalName.Name = "OriginalName";
            this.OriginalName.Size = new System.Drawing.Size(78, 23);
            this.OriginalName.TabIndex = 2;
            this.OriginalName.Text = "OriginalName";
            this.OriginalName.UseVisualStyleBackColor = true;
            this.OriginalName.Click += new System.EventHandler(this.OriginalName_Click);
            // 
            // BDate
            // 
            this.BDate.Location = new System.Drawing.Point(2, 56);
            this.BDate.Margin = new System.Windows.Forms.Padding(2, 2, 1, 2);
            this.BDate.Name = "BDate";
            this.BDate.Size = new System.Drawing.Size(78, 23);
            this.BDate.TabIndex = 3;
            this.BDate.Text = "Date";
            this.BDate.UseVisualStyleBackColor = true;
            this.BDate.Click += new System.EventHandler(this.BDate_Click);
            // 
            // BTime
            // 
            this.BTime.Location = new System.Drawing.Point(82, 56);
            this.BTime.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.BTime.Name = "BTime";
            this.BTime.Size = new System.Drawing.Size(78, 23);
            this.BTime.TabIndex = 4;
            this.BTime.Text = "Time";
            this.BTime.UseVisualStyleBackColor = true;
            this.BTime.Click += new System.EventHandler(this.BTime_Click);
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(2, 83);
            this.Year.Margin = new System.Windows.Forms.Padding(2);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(52, 23);
            this.Year.TabIndex = 1;
            this.Year.Text = "Year";
            this.Year.UseVisualStyleBackColor = true;
            this.Year.Click += new System.EventHandler(this.Year_Click);
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(57, 83);
            this.Month.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(48, 23);
            this.Month.TabIndex = 1;
            this.Month.Text = "Month";
            this.Month.UseVisualStyleBackColor = true;
            this.Month.Click += new System.EventHandler(this.Month_Click);
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(108, 83);
            this.Day.Margin = new System.Windows.Forms.Padding(2);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(52, 23);
            this.Day.TabIndex = 1;
            this.Day.Text = "Day";
            this.Day.UseVisualStyleBackColor = true;
            this.Day.Click += new System.EventHandler(this.Day_Click);
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(2, 110);
            this.Hour.Margin = new System.Windows.Forms.Padding(2);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(52, 23);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "Hour";
            this.Hour.UseVisualStyleBackColor = true;
            this.Hour.Click += new System.EventHandler(this.Hour_Click);
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(57, 110);
            this.Minute.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(48, 23);
            this.Minute.TabIndex = 1;
            this.Minute.Text = "Minute";
            this.Minute.UseVisualStyleBackColor = true;
            this.Minute.Click += new System.EventHandler(this.Minute_Click);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(108, 110);
            this.Second.Margin = new System.Windows.Forms.Padding(2);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(52, 23);
            this.Second.TabIndex = 1;
            this.Second.Text = "Second";
            this.Second.UseVisualStyleBackColor = true;
            this.Second.Click += new System.EventHandler(this.Second_Click);
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(6, 19);
            this.NameField.Margin = new System.Windows.Forms.Padding(10);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(156, 20);
            this.NameField.TabIndex = 0;
            this.NameField.Text = "[OriginalName]";
            this.NameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            // 
            // LeadingZeros
            // 
            this.LeadingZeros.FormattingEnabled = true;
            this.LeadingZeros.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.LeadingZeros.Location = new System.Drawing.Point(87, 67);
            this.LeadingZeros.Name = "LeadingZeros";
            this.LeadingZeros.Size = new System.Drawing.Size(75, 21);
            this.LeadingZeros.TabIndex = 4;
            this.LeadingZeros.Text = "Yes";
            this.LeadingZeros.SelectedValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Leading zeros";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Length";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starts at";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(87, 43);
            this.Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(75, 20);
            this.Length.TabIndex = 0;
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Length.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Length.ValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(87, 92);
            this.Step.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(75, 20);
            this.Step.TabIndex = 0;
            this.Step.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Step.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Step.ValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(87, 19);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 20);
            this.Start.TabIndex = 0;
            this.Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Start.ValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DateLeadingZeros);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(47, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date
            // 
            this.Date.FormattingEnabled = true;
            this.Date.Items.AddRange(new object[] {
            "Acquisition",
            "Now"});
            this.Date.Location = new System.Drawing.Point(87, 19);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(75, 21);
            this.Date.TabIndex = 4;
            this.Date.Tag = "";
            this.Date.Text = "Acquisition";
            this.Date.SelectedValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Leading zeros";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateLeadingZeros
            // 
            this.DateLeadingZeros.FormattingEnabled = true;
            this.DateLeadingZeros.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.DateLeadingZeros.Location = new System.Drawing.Point(87, 42);
            this.DateLeadingZeros.Name = "DateLeadingZeros";
            this.DateLeadingZeros.Size = new System.Drawing.Size(75, 21);
            this.DateLeadingZeros.TabIndex = 4;
            this.DateLeadingZeros.Text = "Yes";
            this.DateLeadingZeros.SelectedValueChanged += new System.EventHandler(this.FilterSettings_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LeadingZeros);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.Step);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NameField);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name Pattern";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 164);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add";
            // 
            // RenameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "RenameControl";
            this.Size = new System.Drawing.Size(168, 447);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
    }
}