using System;
using System.Data;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class Form3 : Form
    {
        private DatabaseManager dbManager;

        public Form3()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            // Assuming the employee's ID is available somewhere in your application
            string employeeId = "123"; // Replace "123" with the actual employee ID

            // Retrieve the data from the database
            string query = $"SELECT * FROM settings WHERE policy = '1'";
            DataTable dataTable = dbManager.GetDataTable(query);

            // Check if any data is retrieved
            if (dataTable.Rows.Count > 0)
            {
                // Populate the fields with the retrieved data
                DataRow row = dataTable.Rows[0]; // Assuming only one row is returned
                daterange_box.Text = row["date_range"].ToString();
                startDatePicker.Value = Convert.ToDateTime(row["start_date"]);
                endDatePicker.Value = Convert.ToDateTime(row["end_date"]);
                noOfLeaves.Text = row["no_of_leaves"].ToString();
            }
            else
            {
                // Handle case when no data is retrieved
                MessageBox.Show("No leave details found for the employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Implement the update functionality here
            // Retrieve the values from the fields and perform necessary database updates
            string dateRange = daterange_box.Text;
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            int noOfLeavesValue = Convert.ToInt32(noOfLeaves.Text);

            // Execute the update query using the retrieved values
            // Example query:
            string updateQuery = $"UPDATE settings SET start_date = '{startDate.ToString("yyyy-MM-dd")}', " +
            $"end_date = '{endDate.ToString("yyyy-MM-dd")}', date_range = '{dateRange}', " +
            $"no_of_leaves = {noOfLeavesValue} WHERE policy = '1'";


            // Execute the update query using the DatabaseManager
            bool success = dbManager.Update(updateQuery);

            // Check if the update was successful
            if (success)
            {
                MessageBox.Show("Leave details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update leave details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
