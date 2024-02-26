namespace GrifindoToysPayrollSystem
{
    partial class Form1
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
            System.Windows.Forms.Label ot_rate;
            System.Windows.Forms.Label allowance;
            this.id_label = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.OTTextBox = new System.Windows.Forms.TextBox();
            this.AllowanceTextBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ot_rate = new System.Windows.Forms.Label();
            allowance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(51, 55);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(52, 16);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "User ID";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(51, 94);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(51, 131);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(46, 16);
            this.label_salary.TabIndex = 2;
            this.label_salary.Text = "Salary";
            // 
            // ot_rate
            // 
            ot_rate.AutoSize = true;
            ot_rate.Location = new System.Drawing.Point(51, 166);
            ot_rate.Name = "ot_rate";
            ot_rate.Size = new System.Drawing.Size(58, 16);
            ot_rate.TabIndex = 3;
            ot_rate.Text = "OT Rate";
            // 
            // allowance
            // 
            allowance.AutoSize = true;
            allowance.Location = new System.Drawing.Point(51, 203);
            allowance.Name = "allowance";
            allowance.Size = new System.Drawing.Size(69, 16);
            allowance.TabIndex = 4;
            allowance.Text = "Allowance";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(161, 48);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(136, 22);
            this.IdTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(161, 88);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(136, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(161, 125);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(136, 22);
            this.salaryTextBox.TabIndex = 7;
            // 
            // OTTextBox
            // 
            this.OTTextBox.Location = new System.Drawing.Point(161, 163);
            this.OTTextBox.Name = "OTTextBox";
            this.OTTextBox.Size = new System.Drawing.Size(136, 22);
            this.OTTextBox.TabIndex = 8;
            // 
            // AllowanceTextBox
            // 
            this.AllowanceTextBox.Location = new System.Drawing.Point(161, 199);
            this.AllowanceTextBox.Name = "AllowanceTextBox";
            this.AllowanceTextBox.Size = new System.Drawing.Size(136, 22);
            this.AllowanceTextBox.TabIndex = 9;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(36, 261);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(110, 29);
            this.registerBtn.TabIndex = 10;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(152, 261);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 29);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(268, 261);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 29);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.AllowanceTextBox);
            this.Controls.Add(this.OTTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(allowance);
            this.Controls.Add(ot_rate);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.id_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox OTTextBox;
        private System.Windows.Forms.TextBox AllowanceTextBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button button1;
    }
}

