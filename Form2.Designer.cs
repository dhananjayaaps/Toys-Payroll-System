namespace GrifindoToysPayrollSystem
{
    partial class Form2
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
            this.startDate_label = new System.Windows.Forms.Label();
            this.EndDate_label = new System.Windows.Forms.Label();
            this.absetdays_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.absetDays_Box = new System.Windows.Forms.TextBox();
            this.holidaysBox = new System.Windows.Forms.TextBox();
            this.OtHoursBox = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TaxRateBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reportStartPicker = new System.Windows.Forms.DateTimePicker();
            this.reportEndPicker = new System.Windows.Forms.DateTimePicker();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.reportUIDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startDate_label
            // 
            this.startDate_label.AutoSize = true;
            this.startDate_label.Location = new System.Drawing.Point(30, 85);
            this.startDate_label.Name = "startDate_label";
            this.startDate_label.Size = new System.Drawing.Size(66, 16);
            this.startDate_label.TabIndex = 0;
            this.startDate_label.Text = "Start Date";
            // 
            // EndDate_label
            // 
            this.EndDate_label.AutoSize = true;
            this.EndDate_label.Location = new System.Drawing.Point(30, 133);
            this.EndDate_label.Name = "EndDate_label";
            this.EndDate_label.Size = new System.Drawing.Size(63, 16);
            this.EndDate_label.TabIndex = 1;
            this.EndDate_label.Text = "End Date";
            // 
            // absetdays_label
            // 
            this.absetdays_label.AutoSize = true;
            this.absetdays_label.Location = new System.Drawing.Point(30, 181);
            this.absetdays_label.Name = "absetdays_label";
            this.absetdays_label.Size = new System.Drawing.Size(84, 16);
            this.absetdays_label.TabIndex = 2;
            this.absetdays_label.Text = "Absent Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Holidays";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "OT Hours";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StartDatePicker.Location = new System.Drawing.Point(184, 79);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(117, 22);
            this.StartDatePicker.TabIndex = 5;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EndDatePicker.Location = new System.Drawing.Point(184, 127);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(117, 22);
            this.EndDatePicker.TabIndex = 6;
            // 
            // absetDays_Box
            // 
            this.absetDays_Box.Location = new System.Drawing.Point(184, 174);
            this.absetDays_Box.Name = "absetDays_Box";
            this.absetDays_Box.Size = new System.Drawing.Size(117, 22);
            this.absetDays_Box.TabIndex = 7;
            // 
            // holidaysBox
            // 
            this.holidaysBox.Location = new System.Drawing.Point(184, 218);
            this.holidaysBox.Name = "holidaysBox";
            this.holidaysBox.Size = new System.Drawing.Size(117, 22);
            this.holidaysBox.TabIndex = 8;
            // 
            // OtHoursBox
            // 
            this.OtHoursBox.Location = new System.Drawing.Point(184, 264);
            this.OtHoursBox.Name = "OtHoursBox";
            this.OtHoursBox.Size = new System.Drawing.Size(117, 22);
            this.OtHoursBox.TabIndex = 9;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(116, 341);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "User ID";
            // 
            // userIdBox
            // 
            this.userIdBox.Location = new System.Drawing.Point(184, 25);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(117, 22);
            this.userIdBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tax Rate";
            // 
            // TaxRateBox
            // 
            this.TaxRateBox.Location = new System.Drawing.Point(184, 305);
            this.TaxRateBox.Name = "TaxRateBox";
            this.TaxRateBox.Size = new System.Drawing.Size(117, 22);
            this.TaxRateBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Report Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Report End Date";
            // 
            // reportStartPicker
            // 
            this.reportStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportStartPicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.reportStartPicker.Location = new System.Drawing.Point(569, 74);
            this.reportStartPicker.Name = "reportStartPicker";
            this.reportStartPicker.Size = new System.Drawing.Size(117, 22);
            this.reportStartPicker.TabIndex = 17;
            // 
            // reportEndPicker
            // 
            this.reportEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportEndPicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.reportEndPicker.Location = new System.Drawing.Point(569, 121);
            this.reportEndPicker.Name = "reportEndPicker";
            this.reportEndPicker.Size = new System.Drawing.Size(117, 22);
            this.reportEndPicker.TabIndex = 18;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(482, 181);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(149, 23);
            this.generateBtn.TabIndex = 19;
            this.generateBtn.Text = "Generate Report";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "User ID";
            // 
            // reportUIDBox
            // 
            this.reportUIDBox.Location = new System.Drawing.Point(569, 25);
            this.reportUIDBox.Name = "reportUIDBox";
            this.reportUIDBox.Size = new System.Drawing.Size(117, 22);
            this.reportUIDBox.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 517);
            this.Controls.Add(this.reportUIDBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.reportEndPicker);
            this.Controls.Add(this.reportStartPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaxRateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userIdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.OtHoursBox);
            this.Controls.Add(this.holidaysBox);
            this.Controls.Add(this.absetDays_Box);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.absetdays_label);
            this.Controls.Add(this.EndDate_label);
            this.Controls.Add(this.startDate_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startDate_label;
        private System.Windows.Forms.Label EndDate_label;
        private System.Windows.Forms.Label absetdays_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.TextBox absetDays_Box;
        private System.Windows.Forms.TextBox holidaysBox;
        private System.Windows.Forms.TextBox OtHoursBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TaxRateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker reportStartPicker;
        private System.Windows.Forms.DateTimePicker reportEndPicker;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reportUIDBox;

    }
}