using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_and_Algorithms
{
    public partial class POS2_FuntionFrm : Form
    {
        private void quantitytextbox()
        {
            quantitytextbox.Clear();
            quantitytextbox.Focus();
        }
        private void quantity_price_Convert()
        {
            double quantity, price;
            quantity = Convert.ToInt32(quantitytextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }
        private void computation_Formula_and_DisplayData()
        {
            discounttextbox.Text = discount_amt.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");
        }
        private void price_item_TextValue(string itemname, string price)
        {
            itemnametextbox.Text = itemname;
            pricetextbox.Text = price;
        }
        public POS2_FuntionFrm()
        {
            InitializeComponent();
        }

        private void POS2_FuntionFrm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name1lbl.Text, "100");
            quantitytextbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name2lbl.Text, "100");
            quantitytextbox();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name3lbl.Text, "60.50");
            quantitytextbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name4lbl.Text, "150.00");
            quantitytextbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name5lbl.Text, "100.50");
            quantitytextbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name6lbl.Text, "120.00");
            quantitytextbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name7lbl.Text, "80.00");
            quantitytextbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name8lbl.Text, "300.00");
            quantitytextbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name9lbl.Text, "150.00");
            quantitytextbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name10lbl.Text, "110.00");
            quantitytextbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name11lbl.Text, "120.00");
            quantitytextbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name12lbl.Text, "130.00");
            quantitytextbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name13lbl.Text, "150.00");
            quantitytextbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name14lbl.Text, "70.00");
            quantitytextbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name15lbl.Text, "100.00");
            quantitytextbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name16lbl.Text, "150.00");
            quantitytextbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name17lbl.Text, "200.00");
            quantitytextbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name18lbl.Text, "250.00");
            quantitytextbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name19lbl.Text, "300.00");
            quantitytextbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name20lbl.Text, "350.00");
            quantitytextbox();
        }

        private void seniocitizenRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
        }
        {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                regularRdbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                nodiscRdbtn.Checked = false;

            }
        catch(Exception);
            {
                MessageBox.Show("Input is Invalid");
                quantitytextbox();
            }
        }

        private void regularRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
        }
            quantity_price_Convert();
            discount_amt = (qty * price) * 0.30;
            conputation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            nodiscRdbtn.Checked = false;
        }
        catch(Exception)
        {
                MessageBox.Show("Input is Invalid");
                quantitytextbox();

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
        }
            quantity_price_Convert();
            discount_amt = (qty * price) * 0.15;
            conputation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;
            nodiscRdbtn.Checked = false;
        }
        catch(Exception)
        {
                MessageBox.Show("Input is Invalid in Quantity");
                quantitytextbox();

        private void nodiscRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
        }
            quantity_price_Convert();
            discount_amt = (qty * price) * 0;
            conputation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
        }
        catch(Exception)
        {
                MessageBox.Show("Input is Invalid in Quantity");
                quantitytextbox();
    }
    }
}
    





