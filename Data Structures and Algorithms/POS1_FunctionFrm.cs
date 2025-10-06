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
    public partial class POS1_FunctionFrm : Form
    {
        private void displaytextbox(string itemname, string price)
        {
            itemnameTextbox.Text = itemname;
            priceTextbox.Text = price;
        }
        private void quantitytextbox()
        {
            qtytextbox.Clear();
            qtytextbox.Focus();
        }
        public POS1_FunctionFrm()
        {
            InitializeComponent();
        }

        private void POS1_FunctionFrm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displaytextbox("Adobo", "100");
            quantitytextbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displaytextbox("Barbeque", "60.50");
            quantitytextbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displaytextbox("Beef Nilaga", "150.00");
            quantitytextbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displaytextbox("Giniling", "100.50");
            quantitytextbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displaytextbox("Kaldereta", "150.00");
            quantitytextbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            displaytextbox("Lechon", "300.00");
            quantitytextbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            displaytextbox("Mechado", "120.00");
            quantitytextbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displaytextbox("Menudo", "110.00");
            quantitytextbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displaytextbox("Monggo", "120.00");
            quantitytextbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displaytextbox("Pinakbet", "130.00");
            quantitytextbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displaytextbox("Pochero", "150.00");
            quantitytextbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displaytextbox("Pork Siomai", "70.00");
            quantitytextbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displaytextbox("Shanghai", "100.00");
            quantitytextbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            displaytextbox("Sinigang", "150.00");
            quantitytextbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            displaytextbox("Pork Sisig", "120.00");
            quantitytextbox();
        }
    }
}
