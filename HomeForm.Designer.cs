namespace GrifindoToysPayrollSystem
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeComponentToolStripMenuItem,
            this.salaryComponentToolStripMenuItem,
            this.settingComponentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeComponentToolStripMenuItem
            // 
            this.employeeComponentToolStripMenuItem.Name = "employeeComponentToolStripMenuItem";
            this.employeeComponentToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.employeeComponentToolStripMenuItem.Text = "Employee Component";
            this.employeeComponentToolStripMenuItem.Click += new System.EventHandler(this.employeeComponentToolStripMenuItem_Click);
            // 
            // salaryComponentToolStripMenuItem
            // 
            this.salaryComponentToolStripMenuItem.Name = "salaryComponentToolStripMenuItem";
            this.salaryComponentToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.salaryComponentToolStripMenuItem.Text = "Salary Component";
            this.salaryComponentToolStripMenuItem.Click += new System.EventHandler(this.salaryComponentToolStripMenuItem_Click);
            // 
            // settingComponentToolStripMenuItem
            // 
            this.settingComponentToolStripMenuItem.Name = "settingComponentToolStripMenuItem";
            this.settingComponentToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.settingComponentToolStripMenuItem.Text = "Setting Component";
            this.settingComponentToolStripMenuItem.Click += new System.EventHandler(this.settingComponentToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeComponentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryComponentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingComponentToolStripMenuItem;
    }
}