using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_and_Algorithms
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void pOS1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cash1 = new Form1();
            cash1.MdiParent = this;
            cash1.Show();
        }

        private void pOS2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cash2 = new Form2();
            cash2.MdiParent = this;
            cash2.Show();
        }
        private void pOS3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 cash3 = new Form3();
            cash3.MdiParent = this;
            cash3.Show();

        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void studentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 student = new Form4();
            student.MdiParent = this;
            student.Show();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrelimExam_Lesson5Activity payroll = new PrelimExam_Lesson5Activity();
            payroll.MdiParent = this;
            payroll.Show();
        }

        private void accountingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cashier4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 cash4 = new Form8();
            cash4.MdiParent = this;
            cash4.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void employeePayslipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 payslip = new Form9();
            payslip.MdiParent = this;
            payslip.Show();
        }
    }
}
