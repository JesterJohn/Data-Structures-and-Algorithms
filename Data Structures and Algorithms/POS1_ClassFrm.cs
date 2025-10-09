using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_and_Algorithms
{
    public partial class POS1_ClassFrm : Form
    {
        Price_Item_Value price_Item_Value = new Price_Item_Value();
        POS1 variables = new POS1();

        public POS1_ClassFrm()
        {
            InitializeComponent();
        }
        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.price * variables.qty) - variables.discount_amt;
            discounttextbox.Text = variables.discount_amt.ToString("n");
            discountedtextbox.Text = variables.discounted_amt.ToString("n");
        }
        public void GetPriceItemValue()
        {
            itemnametextbox.Text = price_Item_Value.GetItemName();
            pricetextbox.Text = price_Item_Value.GetPrice();

        }
        private void quantity_price_Convert()
        {
            int qty;
            double price;
            qty = Convert.ToInt32(quantityTextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }
        private void POS1_ClassFrm_Load(object sender, EventArgs e)
        {
            itemnametextbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtextbox.Enabled = false;
            qty_totaltextbox.Enabled = false;
            discount_totaltextbox.Enabled = false;
            discounted_totaltextbox.Enabled = false;
            changetextbox.Enabled = false;
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            variables.qty = Convert.ToInt32(quantityTextbox.Text);
            variables.discount_amt = Convert.ToDouble(discounttextbox.Text);
            variables.discounted_amt = Convert.ToDouble(discountedtextbox.Text);
            variables.cash_given = Convert.ToDouble(cash_renderedtextbox.Text);

            variables.qty_total += variables.qty;
            variables.discount_totalgiven += variables.discount_amt;
            variables.discounted_amt += variables.discounted_amt;
            variables.change = variables.cash_given - variables.discounted_amt;

            qty_totaltextbox.Text = variables.qty_total.ToString();
            discounttextbox.Text = variables.discount_totalgiven.ToString("n");
            discountedtextbox.Text = variables.discounted_amt.ToString("n");
            discounted_totaltextbox.Text = variables.discounted_amt.ToString("n");
            changetextbox.Text = variables.change.ToString("n");
            cash_renderedtextbox.Text = variables.cash_given.ToString("n");

        }

        private void quantityTextbox_TextChanged(object sender, EventArgs e)
        {
            variables.price = Convert.ToDouble(pricetextbox.Text);
            variables.qty = Convert.ToInt32(quantityTextbox.Text);
            variables.amount_paid = variables.price * variables.qty;
            discount_totaltextbox.Text = variables.amount_paid.ToString("n");
            cash_renderedtextbox.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Adobo", "100");
            GetPriceItemValue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Barbeque", "120");
            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Beef Nilaga", "150");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Giniling", "130");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Kaldereta", "200");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Lechon ", "180");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Mechado", "110");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Menudo", "140");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Monggo", "160");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Pinakbet", "170");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Pochero", "190");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Pork Siomai", "50");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Shanghai", "70");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Sinigang", "80");
            GetPriceItemValue();    
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Pork Sisig", "90");
            GetPriceItemValue();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Sopas", "60");
            GetPriceItemValue();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Tinola", "75");
            GetPriceItemValue();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Kare - Kare", "85");
            GetPriceItemValue();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Pancit", "95");
            GetPriceItemValue();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceValue("Bicol Express", "120");
            GetPriceItemValue();
        }

        private void seniocitizenRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.qty * variables.price) * 0.30;
            computation_Formula_and_DisplayData();
            regularRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            nodiscRdbtn.Checked = false;
        }

        private void regularRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.qty * variables.price) * 0.10;
            computation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            nodiscRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.qty * variables.price) * 0.15;
            computation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;
            nodiscRdbtn.Checked = false;
        }

        private void nodiscRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.qty * variables.price) * 0; 
            computation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            itemnametextbox.Clear();
            pricetextbox.Clear();
            quantityTextbox.Clear();
            discounttextbox.Clear();
            discountedtextbox.Clear();
            changetextbox.Clear();
            cash_renderedtextbox.Clear();
        }
    }
}
