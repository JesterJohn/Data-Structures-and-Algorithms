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
    public partial class Savebtn : Form
    {
        public Savebtn()
        {
            InitializeComponent();
        }

        private void Savebtn_Load(object sender, EventArgs e)
        {
            dis_empcodetextbox.Enabled = false;
            dis_empnametextbox.Enabled = false;
            dis_cutofftextbox.Enabled = false;
            dis_payperiodtextbox.Enabled = false;
            dis_basicdaytextbox.Enabled = false;
            dis_overtimedaytextbox.Enabled = false;
            dis_honordaytextbox.Enabled = false;
            dis_honoradjdaytextbox.Enabled = false;
            dis_subdaytextbox.Enabled = false;
            dis_tardydaytextbox.Enabled = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void empno_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void department_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}
