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

        int qty, qty_total;
        double price, discount_amt, discounted_amt, discount_totalgiven, discounted_total;
        
        public POS2_FuntionFrm()
        {
            InitializeComponent();
        }
        private void quantitytextbox()
        {
            quantityTextbox.Clear();
            quantityTextbox.Focus();
        }
        private void quantity_price_Convert()
        {
            
            qty = Convert.ToInt32(quantityTextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }
        private void computation_Formula_and_DisplayData()
        {

            discounted_amt = (qty * price) - discount_amt;
            discounttextbox.Text = discount_amt.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");
        }
        private void price_item_TextValue(string itemname, string price)
        {
            itemnametextbox.Text = itemname;
            pricetextbox.Text = price;
        }

        private void POS2_FuntionFrm_Load(object sender, EventArgs e)
        {
            // Codes for disabling the textboxes 
            itemnametextbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtextbox.Enabled = false;
            qty_totaltextbox.Enabled = false;
            discount_totaltextbox.Enabled = false;
            discounted_totaltextbox.Enabled = false;
            changetextbox.Enabled = false;

           
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
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                regularRdbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                nodiscRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantitytextbox();
            }
        }

        private void regularRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                seniocitizenRdbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                nodiscRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantitytextbox();
            }
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.15;
                computation_Formula_and_DisplayData();
                regularRdbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                nodiscRdbtn.Checked = false;


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input is Quantity");
                quantitytextbox();
            }
         }

        private void newbtn_Click(object sender, EventArgs e)
        {
            //codes for clearing specific pointed texboxes 
            itemnametextbox.Clear();
            pricetextbox.Clear();
            quantityTextbox.Clear();
            discounttextbox.Clear();
            discountedtextbox.Clear();
            changetextbox.Clear();
            cash_renderedtextbox.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void discounttextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nodiscRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0;
                computation_Formula_and_DisplayData();
                regularRdbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                nodiscRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data input is Quantity");
                quantitytextbox();
            }
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {

          

            // declaration of variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantityTextbox.Text);
            discount_amt = Convert.ToDouble(discounttextbox.Text);
            discounted_amt = Convert.ToDouble(discountedtextbox.Text);
            cash_rendered = Convert.ToDouble(cash_renderedtextbox.Text);

            // accumulate totals
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_total;

            // display results in textboxes
            qty_totaltextbox.Text = qty_total.ToString();
            discount_totaltextbox.Text = discount_totalgiven.ToString("n");
            discounted_totaltextbox.Text = discounted_total.ToString("n");
            changetextbox.Text = change.ToString("n");
            cash_renderedtextbox.Text = cash_rendered.ToString("n");
        }
    }
}

    





