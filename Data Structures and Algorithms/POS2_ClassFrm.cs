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
    public partial class POS2_ClassFrm : Form
    {
        Price_Item_Value price_Item_Value = new Price_Item_Value();
        Variables variables = new Variables();

        
        public POS2_ClassFrm()
        {
            InitializeComponent();
        }
        private void quantitytextbox()
        {
            quantityTextbox.Clear();
            quantityTextbox.Focus();

        }
        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.price * variables.quantity) - variables.discount_amt;
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
            variables.quantity = Convert.ToInt32(quantityTextbox.Text);
            variables.price = Convert.ToDouble(pricetextbox.Text);
        }

        private void POS2_ClassFrm_Load(object sender, EventArgs e)
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
            variables.quantity = Convert.ToInt32(quantityTextbox.Text);
            variables.discount_amt = Convert.ToDouble(discounttextbox.Text);
            variables.discounted_amt = Convert.ToDouble(discountedtextbox.Text);
            variables.cash_given = Convert.ToDouble(cash_renderedtextbox.Text);

            variables.qty_total += variables.quantity;
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
            
            variables.amount_paid = variables.price * variables.quantity;
            discount_totaltextbox.Text = variables.amount_paid.ToString("n");
            cash_renderedtextbox.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Adobo", "100");
            GetPriceItemValue();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Barbeque", "80");
            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Beef Nilaga", "150");
            GetPriceItemValue();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Giniling", "120");
            GetPriceItemValue();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Kaldereta", "150");
            GetPriceItemValue();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Lechon", "200");
            GetPriceItemValue();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Mechado", "120");
            GetPriceItemValue();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Menudo", "100");
            GetPriceItemValue();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Monggo", "80");
            GetPriceItemValue();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Pinakbet", "100");
            GetPriceItemValue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Pochero", "150");
            GetPriceItemValue();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Pork Siomai", "90");
            GetPriceItemValue();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Shanghai", "50");
            GetPriceItemValue();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Sinigang", "120");
            GetPriceItemValue();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Pork Sisig", "150");
            GetPriceItemValue();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Sopas", "100");
            GetPriceItemValue();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Tinola", "120");
            GetPriceItemValue();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Kare - Kare", "100");
            GetPriceItemValue();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Pansit", "70");
            GetPriceItemValue();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_Item_Value.SetPriceItemValue("Bicol Express", "150");
            GetPriceItemValue();
        }

        private void seniocitizenRdbtn_CheckedChanged(object sender, EventArgs e)
        {
                quantity_price_Convert();
                variables.discount_amt = (variables.price * variables.quantity) * 0.30;
                computation_Formula_and_DisplayData();
                regularRdbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                nodiscRdbtn.Checked = false;
            
        }

        private void regularRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.price * variables.quantity) * 0.10;
            computation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            nodiscRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.price * variables.quantity) * 0.15;
            computation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;
            nodiscRdbtn.Checked = false;
        }

        private void nodiscRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            quantity_price_Convert();
            variables.discount_amt = (variables.price * variables.quantity) * 0.00;
            computation_Formula_and_DisplayData();
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
