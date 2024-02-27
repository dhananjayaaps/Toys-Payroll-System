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
            this.components = new System.ComponentModel.Container();
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
            this.getEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ot_rate = new System.Windows.Forms.Label();
            allowance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(161, 48);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(136, 22);
            this.IdTextBox.TabIndex = 5;
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
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
            // getEmployee
            // 
            this.getEmployee.Location = new System.Drawing.Point(36, 312);
            this.getEmployee.Name = "getEmployee";
            this.getEmployee.Size = new System.Drawing.Size(110, 29);
            this.getEmployee.TabIndex = 13;
            this.getEmployee.Text = "View Details";
            this.getEmployee.UseVisualStyleBackColor = true;
            this.getEmployee.Click += new System.EventHandler(this.getEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.oTRateDataGridViewTextBoxColumn,
            this.allowanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(384, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 293);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(268, 312);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 29);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(152, 312);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(110, 29);
            this.showAllBtn.TabIndex = 16;
            this.showAllBtn.Text = "View All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // oTRateDataGridViewTextBoxColumn
            // 
            this.oTRateDataGridViewTextBoxColumn.DataPropertyName = "OTRate";
            this.oTRateDataGridViewTextBoxColumn.HeaderText = "OTRate";
            this.oTRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oTRateDataGridViewTextBoxColumn.Name = "oTRateDataGridViewTextBoxColumn";
            this.oTRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // allowanceDataGridViewTextBoxColumn
            // 
            this.allowanceDataGridViewTextBoxColumn.DataPropertyName = "Allowance";
            this.allowanceDataGridViewTextBoxColumn.HeaderText = "Allowance";
            this.allowanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allowanceDataGridViewTextBoxColumn.Name = "allowanceDataGridViewTextBoxColumn";
            this.allowanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(GrifindoToysPayrollSystem.Employee);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 450);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getEmployee);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
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
        private System.Windows.Forms.Button getEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button showAllBtn;
    }
}

