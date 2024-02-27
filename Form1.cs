using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void getEmployee_Click(object sender, EventArgs e)
        {
            string employeeId = IdTextBox.Text; // Assuming idTextBox contains the employee ID
            string query = $"SELECT * FROM employee WHERE id = '{employeeId}'";
            DatabaseManager dbManager = new DatabaseManager();
            Employee employee = dbManager.GetEmployeeDetails(query);
            if (employee != null)
            {
                // Display employee details on the form
                DisplayEmployeeDetails(employee);
            }
            else
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayEmployeeDetails(Employee employee)
        {
            IdTextBox.Text = employee.Id.ToString();
            NameTextBox.Text = employee.Name;
            salaryTextBox.Text = employee.Salary.ToString();
            OTTextBox.Text = employee.OTRate.ToString();
            AllowanceTextBox.Text = employee.Allowance.ToString();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM employee";
            DatabaseManager dbManager = new DatabaseManager();
            DataTable dataTable = dbManager.GetDataTable(query);

            // Bind DataTable to DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can add code here to handle cell content click events if needed
            // For example:
            /*
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("You clicked on: " + row.Cells["ColumnName"].Value.ToString());
            }
            */
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Retrieve search criteria from fields
            string name = NameTextBox.Text.Trim();
            decimal? salary = null;
            if (!string.IsNullOrWhiteSpace(salaryTextBox.Text))
            {
                salary = Convert.ToDecimal(salaryTextBox.Text.Trim());
            }
            // You can add more fields as per your requirements

            // Construct the SQL query based on the search criteria
            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM employee WHERE 1=1");
            if (!string.IsNullOrWhiteSpace(name))
            {
                queryBuilder.Append($" AND name LIKE '%{name}%'");
            }
            if (salary.HasValue)
            {
                queryBuilder.Append($" AND salary = {salary}");
            }
            // You can add more conditions for additional fields

            string query = queryBuilder.ToString();

            // Execute the query to fetch the related users from the database
            DatabaseManager dbManager = new DatabaseManager();
            DataTable searchResults = dbManager.GetDataTable(query);

            // Bind the DataTable to the DataGridView to display the search results
            dataGridView1.DataSource = searchResults;
        }
    }
 }
