using System.Drawing;
using System.Windows.Forms;
using System;

namespace GrifindoToysPayrollSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            this.Size = new Size(1100, 500);
        }

        private void employeeComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            Form1 employeeform = new Form1();
            InitializeChildForm(employeeform);
        }

        private void salaryComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            Form2 salaryform = new Form2();
            InitializeChildForm(salaryform);
        }

        private void settingComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            Form3 settingsForm = new Form3();
            InitializeChildForm(settingsForm);
        }

        private void CloseCurrentForm()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void InitializeChildForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(0, 0); // Top-left corner
            childForm.MdiParent = this;
            childForm.ControlBox = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = new Size(1100, 500);
            childForm.Show();
        }
    }
}
