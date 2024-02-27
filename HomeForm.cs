using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void employeeComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            Form1 employeeform = new Form1();
            employeeform.MdiParent = this;
            employeeform.Show();
        }

        private void salaryComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            Form2 salaryform = new Form2();
            salaryform.MdiParent = this;
            salaryform.Show();
        }

        private void settingComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            Form3 settingsForm = new Form3();
            settingsForm.MdiParent = this;
            settingsForm.Show();
        }

        private void CloseCurrentForm()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

    }
}
