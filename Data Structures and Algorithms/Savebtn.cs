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
            //code to disable the texboxes 
            dis_empcodetextbox.Enabled = false;
            dis_empnametextbox.Enabled = false;
            dis_cutofftextbox.Enabled = false;
            dis_payperiodtextbox.Enabled = false;
            dis_departmenttextbox.Enabled = false;

            dis_basicdaytextbox.Enabled = false;
            dis_overtimedaytextbox.Enabled = false;
            dis_honordaytextbox.Enabled = false;
            dis_honoradjdaytextbox.Enabled = false;
            dis_subdaytextbox.Enabled = false;
            dis_tardydaytextbox.Enabled = false;

            dis_basictaxtextbox.Enabled = false;
            dis_overtimetaxtextbox.Enabled = false;
            dis_honortaxtextbox.Enabled = false;
            dis_honooradjtaxtextbox.Enabled = false;
            dis_subtaxtextbox.Enabled = false;
            dis_tardytaxtextbox.Enabled = false;

            dis_nonbasictextbox.Enabled = false;
            dis_nonovertimetextbox.Enabled = false;
            dis_nonhonortextbox.Enabled = false;
            dis_nonhonoradjtextbox.Enabled = false;
            dis_nonsubtextbox.Enabled = false;
            dis_nontardytextbox.Enabled = false;

            dis_withholdingtaxtextbox.Enabled = false;
            dis_ssscontribtextbox.Enabled = false;
            dis_hdmfcontribtextbox.Enabled = false;
            dis_philhealthcontribtextbox.Enabled = false;
            dis_wispcontribtextbox.Enabled = false;

            dis_earningstextbox.Enabled = false;
            dis_deductiontextbox.Enabled = false;
            display_overtimetexbox.Enabled = false;
            dis_grossearningstextbox.Enabled = false;
            dis2_deductiontexbox.Enabled = false;
            dis_netpaytextbox.Enabled = false;



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
