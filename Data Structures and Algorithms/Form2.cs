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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Codes for disabling the textboxes 
            itemnametextbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtextbox.Enabled = false;
            qty_totaltextbox.Enabled = false;
            discount_totaltextbox.Enabled = false;
            discounted_totaltextbox.Enabled = false;
            changetextbox.Enabled = false;

            //Codes for inserting picture or image inside the picturebox tool
            pictureBox1.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\adobo.jpg");
            pictureBox2.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\bbq.jpg");
            pictureBox3.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\beef nilaga.jpg");
            pictureBox4.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\giniling.jpg");
            pictureBox5.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\kaldereta.jpg");
            pictureBox6.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\lechon.jpg");
            pictureBox7.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\mechado.jpg");
            pictureBox8.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\menudo.png");
            pictureBox9.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\monggo.jpg");
            pictureBox10.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pinakbet.jpg");
            pictureBox11.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pochero.jpg");
            pictureBox12.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pork Siomai.jpg");
            pictureBox13.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\shanghai.jpg");
            pictureBox14.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\sinigang.jpg");
            pictureBox15.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\sisig.jpg");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\sopas.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\tinola.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\kare kare.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pancit.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\Bicol_Express.jpg");

            //codes for inserting or assigning a value to the text property of a label
            name1lbl.Text = "Adobo";
            name2lbl.Text = "Barbeque";
            name3lbl.Text = "Beef Nilaga";
            name4lbl.Text = "Giniling";
            name5lbl.Text = "Kaldereta";
            name6lbl.Text = "Lechon";
            name7lbl.Text = "Mechado";
            name8lbl.Text = "Menudo";
            name9lbl.Text = "Monggo";
            name10lbl.Text = "Pinakbet";
            name11lbl.Text = "Pochero";
            name12lbl.Text = "Pork Siomai";
            name13lbl.Text = "Shanghai";
            name14lbl.Text = "Sinigang";
            name15lbl.Text = "Sisig";
            name16lbl.Text = "Sopas";
            name17lbl.Text = "Tinola";
            name18lbl.Text = "Kare - Kare";
            name19lbl.Text = "Pancit";
            name20lbl.Text = "Bicol Express";

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name2lbl.Text;
            pricetextbox.Text = "50";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name1lbl.Text;
            pricetextbox.Text = "120";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name3lbl.Text;
            pricetextbox.Text = "150";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name4lbl.Text;
            pricetextbox.Text = "100";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name5lbl.Text;
            pricetextbox.Text = "100";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name6lbl.Text;
            pricetextbox.Text = "250";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name7lbl.Text;
            pricetextbox.Text = "100";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name8lbl.Text;
            pricetextbox.Text = "120";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name9lbl.Text;
            pricetextbox.Text = "80";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name10lbl.Text;
            pricetextbox.Text = "90";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name11lbl.Text;
            pricetextbox.Text = "150";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name12lbl.Text;
            pricetextbox.Text = "80";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name13lbl.Text;
            pricetextbox.Text = "70";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name14lbl.Text;
            pricetextbox.Text = "120";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name15lbl.Text;
            pricetextbox.Text = "150";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name16lbl.Text;
            pricetextbox.Text = "90";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name17lbl.Text;
            pricetextbox.Text = "110";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name18lbl.Text;
            pricetextbox.Text = "200";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name19lbl.Text ;
            pricetextbox.Text = "80";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametextbox.Text = name20lbl.Text;
            pricetextbox.Text = "130";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as avalue of the variable 
            qty = Convert.ToInt32(qtyTextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            //converting numeric fata to string and display it inside the textboxes
            discounttextbox.Text = discount_amt.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");

            //codes for checking the other radio buttons in the interface once the senior citizen card method executed 
            regularRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regularRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as avalue of the variable 
            qty = Convert.ToInt32(qtyTextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            //converting numeric fata to string and display it inside the textboxes
            discounttextbox.Text = discount_amt.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");

            //codes for checking the other radio buttons in the interface once the senior citizen card method executed 
            seniocitizenRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as avalue of the variable 
            qty = Convert.ToInt32(qtyTextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            //converting numeric fata to string and display it inside the textboxes
            discounttextbox.Text = discount_amt.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");

            //codes for checking the other radio buttons in the interface once the senior citizen card method executed 
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object 
            int qty;
            double price, discount_amt, discounted_amt;

            // convert string data from textboxes to numeric and place it as avalue of the variable 
            qty = Convert.ToInt32(qtyTextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            // create a formula needed for computation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            //converting numeric fata to string and display it inside the textboxes
            discounttextbox.Text = discount_amt.ToString("n");
            discountedtextbox.Text = discounted_amt.ToString("n");

            //codes for checking the other radio buttons in the interface once the senior citizen card method executed 
            seniocitizenRdbtn.Checked = false;
            regularRdbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty_total = 0;
            double discount_totalgiven = 0;
            double discounted_total = 0;


            // declaration of variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(qtyTextbox.Text);
            discount_amt = Convert.ToDouble(discounttextbox.Text);
            discounted_amt = Convert.ToDouble(discountedtextbox.Text);
            cash_rendered = Convert.ToDouble(cash_renderedtextbox.Text);

            // accumulate totals
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            // display results in textboxes
            qty_totaltextbox.Text = qty_total.ToString();
            discount_totaltextbox.Text = discount_totalgiven.ToString("n");
            discounted_totaltextbox.Text = discounted_total.ToString("n");
            changetextbox.Text = change.ToString("n");
            cash_renderedtextbox.Text = cash_rendered.ToString("n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codes for clearing specific pointed texboxes 
            itemnametextbox.Clear();
            pricetextbox.Clear();
            qtyTextbox.Clear();
            discounttextbox.Clear();
            discountedtextbox.Clear();
            changetextbox.Clear();
            cash_renderedtextbox.Clear();
        }
        
    }
}
