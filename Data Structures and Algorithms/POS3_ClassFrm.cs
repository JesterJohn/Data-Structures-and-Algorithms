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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Data_Structures_and_Algorithms
{
    public partial class POS3_ClassFrm : Form
    {
        double total_amt = 0;
        int total_qty = 0;

        Price_Item_Value price_discountamount_value = new Price_Item_Value();
        Variables variables = new Variables();
        private void quantitytextbox()
        {
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }
        private void foodradiobtn()
        {
            foodARdbtn.Checked = false;
            foodRdbtn.Checked = false;
        }
        
        private void item_priceValue(string discount, string price)
        {
            discounttextbox.Text = discount;
            pricetextbox.Text = price;
        }

        public POS3_ClassFrm()
        {
            InitializeComponent();
        }
       
        private void POS3_ClassFrm_Load(object sender, EventArgs e)
        {
            pricetextbox.Enabled = false;
            discounttextbox.Enabled = false;
            discountedtextbox.Enabled = false;
            changetextbox.Enabled = false;
            totalbillstextbox.Enabled = false;
            totalqtytextbox.Enabled = false;

            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_CokeCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;
            B_HaloHaloCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            DisplayPicturebox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "500");
            displaylistbox.Items.Add(checkBox1.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "600");
            displaylistbox.Items.Add(checkBox2.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "400");
            displaylistbox.Items.Add(checkBox3.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "650");
            displaylistbox.Items.Add(checkBox4.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "700");
            displaylistbox.Items.Add(checkBox5.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "450");
            displaylistbox.Items.Add(checkBox6.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "550");
            displaylistbox.Items.Add(checkBox7.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "750");
            displaylistbox.Items.Add(checkBox8.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "650");
            displaylistbox.Items.Add(checkBox9.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "450");
            displaylistbox.Items.Add(checkBox10.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox11.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox12.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox13.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox14.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox15.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox16.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox17.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox18.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox19.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575");
            displaylistbox.Items.Add(checkBox20.Text + " " + pricetextbox.Text);
            quantitytextbox();
        }
        private void qtytextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(qtytextbox.Text) ||
                string.IsNullOrWhiteSpace(pricetextbox.Text) ||
                string.IsNullOrWhiteSpace(discounttextbox.Text))

                return; 

            double price, discount_amt, discounted_amt;
            int qty;

            price = Convert.ToDouble(pricetextbox.Text);
            qty = Convert.ToInt32(qtytextbox.Text);
            discount_amt = Convert.ToDouble(discounttextbox.Text);

            discounted_amt = (price * qty) - discount_amt;
            total_qty += qty;
            totalqtytextbox.Text = total_qty.ToString();
            total_amt += discounted_amt;
            totalbillstextbox.Text = total_amt.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");
        }
        private void foodRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.Coral;
            foodARdbtn.Checked = false;

            displaylistbox.Items.Add("====================================");
            displaylistbox.Items.Add("          CUSTOMER ORDER");
            displaylistbox.Items.Add("====================================");

            DisplayPicturebox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Food Bundle A.jpg");

            A_FriedChickenCheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_CokeCheckBox.Checked = true;
            A_SideDishCheckBox.Checked = true;
            A_SpecialPizzaCheckBox.Checked = true;

            B_HaloHaloCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            pricetextbox.Text = "1000.00";
            discounttextbox.Text = "200.00";
            price = Convert.ToDouble(pricetextbox.Text);

            displaylistbox.Items.Add("Discount Amount: " + " " + discounttextbox.Text);
            displaylistbox.Items.Add(foodRdbtn.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.Coral;
            foodRdbtn.Checked = false;

            displaylistbox.Items.Add("====================================");
            displaylistbox.Items.Add("          CUSTOMER ORDER");
            displaylistbox.Items.Add("====================================");

            DisplayPicturebox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Food Bundle B.jpg");

            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_CokeCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;

            B_HaloHaloCheckBox.Checked = true;
            B_ChickenCheckBox.Checked = true;
            B_CarbonaraCheckBox.Checked = true;
            B_FriesCheckBox.Checked = true;
            B_HawaiianCheckbox.Checked = true;

            pricetextbox.Text = "1000.00";
            discounttextbox.Text = "200.00";
            price = Convert.ToDouble(pricetextbox.Text);

            displaylistbox.Items.Add("Discount Amount: " + " " + discounttextbox.Text);
            displaylistbox.Items.Add(foodARdbtn.Text + " " + pricetextbox.Text);

            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foodradiobtn();

            pricetextbox.Clear();
            qtytextbox.Clear();
            discounttextbox.Clear();
            discountedtextbox.Clear();
            totalbillstextbox.Clear();
            cashgiventextbox.Clear();
            changetextbox.Clear();  
            totalqtytextbox.Clear();


            DisplayPicturebox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");
            A_CokeCheckBox.Checked = false;
            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HaloHaloCheckBox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox6.Checked = false;
            checkBox11.Checked = false;
            checkBox16.Checked = false;
            checkBox7.Checked = false;
            checkBox12.Checked = false;
            checkBox17.Checked = false;
            checkBox3.Checked = false;
            checkBox8.Checked = false;
            checkBox13.Checked = false;
            checkBox18.Checked = false;
            checkBox4.Checked = false;
            checkBox9.Checked = false;
            checkBox14.Checked = false;
            checkBox19.Checked = false;
            checkBox19.Checked = false;
            checkBox5.Checked = false;
            checkBox10.Checked = false;
            checkBox20.Checked = false;
            checkBox15.Checked = false;
            displaylistbox.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, change, totalamount_paid;
            cash_given = Convert.ToDouble(cashgiventextbox.Text);
            totalamount_paid = Convert.ToDouble(totalbillstextbox.Text);
            change = cash_given - totalamount_paid;
            changetextbox.Text = change.ToString("n");

            displaylistbox.Items.Add("====================================================");
            displaylistbox.Items.Add("Total Bills: " + " " + totalbillstextbox.Text);
            displaylistbox.Items.Add("Cash Given: " + " " + cashgiventextbox.Text);
            displaylistbox.Items.Add("Change: " + " " + changetextbox.Text);
            displaylistbox.Items.Add("Total No. of Items: " + " " + totalqtytextbox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8_PrintFrm print = new Form8_PrintFrm();
            print.DisplayListbox.Items.AddRange(this.displaylistbox.Items);
            print.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displaylistbox.Items.RemoveAt(displaylistbox.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displaylistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
