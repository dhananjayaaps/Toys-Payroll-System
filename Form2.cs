using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrifindoToysPayrollSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void CreateSalaryDetailsInDatabase(string employeeId, DateTime startDate, DateTime endDate, double basePay, double noPayValue, double grossPay)
        {
            // Construct the SQL query to insert new records into the salary_details table
            string query = $"INSERT INTO salary_details (employee_id, start_date, end_date, base_pay, no_pay_value, gross_pay) " +
                           $"VALUES ('{employeeId}', '{startDate.ToString("yyyy-MM-dd")}', '{endDate.ToString("yyyy-MM-dd")}', {basePay}, {noPayValue}, {grossPay})";

            // Execute the SQL query
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.ExecuteQuery(query);
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal monthlySalary = 0;
            decimal allowances = 0;
            decimal overtimeRate = 0;

            // Retrieve employee details
            string employeeId = userIdBox.Text;
            string query = $"SELECT * FROM employee WHERE id = '{employeeId}'";
            DatabaseManager dbManager = new DatabaseManager();
            Employee employee = dbManager.GetEmployeeDetails(query);

            if (employee != null)
            {
                // Retrieve salary details from the employee object
                monthlySalary = employee.Salary;
                allowances = employee.Allowance;
                overtimeRate = employee.OTRate;

            }
            else
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if employee is not found
            }

            // Parse input values
            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = EndDatePicker.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if start date is after end date
            }

            if (!int.TryParse(absetDays_Box.Text, out int absentDays) ||
                !int.TryParse(holidaysBox.Text, out int holidays) ||
                !int.TryParse(OtHoursBox.Text, out int overtimeHours))
            {
                MessageBox.Show("Please enter valid numeric values for absent days, holidays, and overtime hours.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if input values are not valid
            }

            if (!double.TryParse(TaxRateBox.Text, out double taxRate))
            {
                MessageBox.Show("Please enter a valid numeric value for tax rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if tax rate is not a valid numeric value
            }

            // Calculate salary cycle duration
            int salaryCycleDuration = (endDate - startDate).Days;

            // Calculate base pay
            double basePay = (double)monthlySalary + (double)allowances + ((double)overtimeRate * overtimeHours);

            // Calculate no-pay value
            double noPayValue = ((double)monthlySalary / salaryCycleDuration) * absentDays;

            // Calculate gross pay
            double grossPay = basePay - (noPayValue + (basePay * taxRate * 0.01));

            string retrieveDatesQuery = "SELECT start_date, end_date FROM settings WHERE policy = '1'";

            // Variables to store retrieved start date and end date
            DateTime retrievedStartDate = DateTime.MinValue;
            DateTime retrievedEndDate = DateTime.MinValue;

            // Execute the query to retrieve dates
            DatabaseManager dbManager2 = new DatabaseManager();
            DataTable dataTable = dbManager2.GetDataTable(retrieveDatesQuery);

            // Check if data is available
            if (dataTable.Rows.Count > 0)
            {
                // Retrieve start date and end date from the DataTable
                DataRow row = dataTable.Rows[0];
                retrievedStartDate = Convert.ToDateTime(row["start_date"]);
                retrievedEndDate = Convert.ToDateTime(row["end_date"]);
            }
            else
            {
                // Handle the case where no data is retrieved
                MessageBox.Show("Error retrieving start date and end date from settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool datesMatch = (retrievedStartDate == startDate) && (retrievedEndDate == endDate);

            if (!datesMatch)
            {
                MessageBox.Show("Start date and end date provided do not match the settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateSalaryDetailsInDatabase(employeeId, startDate, endDate, basePay, noPayValue, grossPay);

                MessageBox.Show("Settings updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            string UID = reportUIDBox.Text;
            DateTime startDate = reportStartPicker.Value;
            DateTime endDate = reportEndPicker.Value;

            string query = $"SELECT * FROM salary_details WHERE employee_id = '{UID}' AND start_date >= '{startDate.ToString("yyyy-MM-dd")}' AND end_date <= '{endDate.ToString("yyyy-MM-dd")}'";
            DatabaseManager dbManager = new DatabaseManager();
            DataTable dataTable = dbManager.GetDataTable(query);

            PDFGenerator pdfGenerator = new PDFGenerator();
            string fileName = pdfGenerator.GenerateReport(startDate, endDate, dataTable);

            // Provide a download link to the user
            MessageBox.Show($"PDF report generated successfully. Download from: {fileName}");
        }
    }
}
