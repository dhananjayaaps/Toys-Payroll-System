using System;
using System.Data;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Diagnostics;

namespace GrifindoToysPayrollSystem
{
    public class PDFGenerator
    {
        public string GenerateReport(DateTime startDate, DateTime endDate, DataTable dataTable)
        {
            string fileName = $"PayrollReport_{startDate.ToString("MM-dd-yyyy")}_{endDate.ToString("MM-dd-yyyy")}.pdf";

            // Create a new PDF document
            using (PdfWriter writer = new PdfWriter(fileName))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Add title
                    Paragraph title = new Paragraph($"Payroll Report - {startDate.ToString("MM/dd/yyyy")} to {endDate.ToString("MM/dd/yyyy")}");
                    document.Add(title);

                    // Add table header
                    Table table = new Table(dataTable.Columns.Count);
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        table.AddHeaderCell(column.ColumnName);
                    }

                    // Add data rows
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            table.AddCell(item.ToString());
                        }
                    }

                    // Add table to document
                    document.Add(table);
                }
            }
            Process.Start(fileName);
            return fileName;
        }
    }
}
