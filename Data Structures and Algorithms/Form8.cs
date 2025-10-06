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
    public partial class Form8 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //codes for disabling the textboxes
            pricetextbox.Enabled = false;
            discountedtextbox.Enabled = false;
            changetextbox.Enabled = false;
            totalbillstextbox.Enabled = false;
            discountedtextbox.Enabled = false;
            totalqtytextbox.Enabled = false;

            // codes for inserting image to a picturebox
            


            // codes to disable all checkboxes
            A_CokeCheckBox.Enabled = false;
            A_FriedChickenCheckBox.Enabled = false;
            A_FriesCheckBox.Enabled = false;
            A_SideDishCheckBox.Enabled = false;
            A_SpecialPizzaCheckBox.Enabled = false;

            B_CarbonaraCheckBox.Enabled = false;
            B_ChickenCheckBox.Enabled = false;  
            B_FriesCheckBox.Enabled = false;
            B_HaloHaloCheckBox.Enabled = false;
            B_HawaiianCheckbox.Enabled = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, total_amtpaid, change;
            cash_given = Convert.ToDouble(cashgiventextbox.Text);
            total_amtpaid = Convert.ToDouble(totalbillstextbox.Text);
            change = cash_given - total_amtpaid;

            changetextbox.Text = change.ToString("n");
            displaylistbox.Items.Add("Total Bills: " + " " + totalbillstextbox.Text);
            displaylistbox.Items.Add("Cash Given: " + " " + cashgiventextbox.Text);
            displaylistbox.Items.Add("Change: " + " " + changetextbox.Text);
            displaylistbox.Items.Add("Total No. of Items: " + " " + totalqtytextbox.Text);

            
        }

        private void qtytextbox_TextChanged(object sender, EventArgs e)
        {
            double price, discount_amt, discounted_amt;
            int qty;
            price = Convert.ToDouble(pricetextbox.Text);
            qty = Convert.ToInt32(qtytextbox.Text);
            discount_amt = Convert.ToDouble(discounttextbox.Text);
            discounted_amt = (price * qty) - discount_amt;
            total_qty += qty;
            totalqtytextbox.Text = total_qty.ToString();
            total_amount += discounted_amt;
            totalbillstextbox.Text = total_amount.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");
        }

        private void foodRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.LightCyan;
            foodARdbtn.Checked = false;
            DisplayPicturebox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Food Bundle A.jpg");
            A_CokeCheckBox.Checked = true;
            A_FriedChickenCheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_SideDishCheckBox.Checked = true;
            A_SpecialPizzaCheckBox.Checked = true;
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;    
            B_HaloHaloCheckBox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            pricetextbox.Text = "1,000.00";
            discounttextbox.Text = "200.00";
            price = Convert.ToDouble(pricetextbox.Text);

            displaylistbox.Items.Add("Discount Amount: " + " " + discounttextbox.Text);
            displaylistbox.Items.Add(foodARdbtn.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
            foodRdbtn.Checked = false;
            DisplayPicturebox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Food Bundle B.jpg");
            A_CokeCheckBox.Checked = false;
            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = true;
            B_ChickenCheckBox.Checked = true;
            B_FriesCheckBox.Checked = true;
            B_HaloHaloCheckBox.Checked = true;
            B_HawaiianCheckbox.Checked = true;

            pricetextbox.Text = "1,299.00";
            discounttextbox.Text = "(15% of the Price) P194.85";
            displaylistbox.Items.Add(foodARdbtn);
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

        private void button4_Click(object sender, EventArgs e)
        {
            foodRdbtn.Checked = false;
            foodARdbtn.Checked = false;
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

            pricetextbox.Clear();
            qtytextbox.Clear();
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
            checkBox19.Checked= false;
            checkBox19.Checked = false;
            checkBox5.Checked = false;
            checkBox10.Checked = false;
            checkBox20.Checked = false;
            checkBox15.Checked = false;
            displaylistbox.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discounttextbox.Text = "0.00";
            pricetextbox.Text = "500.99";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox1.Text + " "+ pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "550.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox2.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "600.99";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox3.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "700.50";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox4.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "500.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox5.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "750.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox6.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "700.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox7.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "850.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox8.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "450.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox9.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "650.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox10.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox11.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox12.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox13.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox14.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox15.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox16.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox17.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox18.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox19.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            pricetextbox.Text = "575.00";
            discounttextbox.Text = "0.00";
            price = Convert.ToDouble(pricetextbox.Text);
            displaylistbox.Items.Add(checkBox20.Text + " " + pricetextbox.Text);
            qtytextbox.Text = "0";
            qtytextbox.Focus();
        }

        private void displaylistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
