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
            Form1 pos1 = new Form1();
            pos1.MdiParent = this;
            pos1.Show();
        }

        private void pOS2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 pos2 = new Form2();
            pos2.MdiParent = this;
            pos2.Show();
        }
        private void pOS3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrelimExam_Lesson5Activity pos3 = new PrelimExam_Lesson5Activity();
            pos3.MdiParent = this;
            pos3.Show();

        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void pOS4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pos4 = new Form3();
            pos4.MdiParent = this;
            pos4.Show();
        }

        private void pOS5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 pos5 = new Form4();
            pos5.MdiParent = this;
            pos5.Show();
        }
    }
}
