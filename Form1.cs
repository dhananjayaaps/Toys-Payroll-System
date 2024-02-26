using System;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO employee (id, name, salary, ot_rate, allowance) VALUES ({IdTextBox.Text}, '{NameTextBox.Text}', {salaryTextBox.Text}, {OTTextBox.Text}, {AllowanceTextBox.Text})";
            DatabaseManager dbManager = new DatabaseManager();
            if (dbManager.Insert(query))
            {
                MessageBox.Show("Employee registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to register employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE employee SET name = '{NameTextBox.Text}', salary = {salaryTextBox.Text}, ot_rate = {OTTextBox.Text}, allowance = {AllowanceTextBox.Text} WHERE id = {IdTextBox.Text}";
            DatabaseManager dbManager = new DatabaseManager();
            if (dbManager.Update(query))
            {
                MessageBox.Show("Employee information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update employee information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM employee WHERE id = {IdTextBox.Text}";
            DatabaseManager dbManager = new DatabaseManager();
            if (dbManager.Delete(query))
            {
                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to delete employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
