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
            pictureBox1.Image = Image.FromFile(@"C:\Users\Jester\source\repos\Data Structures and Algorithms\Data Structures and Algorithms\Images\adobo.jpg");
            pictureBox2.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\bbq.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\beef nilaga.jpg");
            pictureBox4.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\giniling.jpg");
            pictureBox5.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\kaldereta.jpg");
            pictureBox6.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\lechon.jpg");
            pictureBox7.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\mechado.jpg");
            pictureBox8.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\menudo.png");
            pictureBox9.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\monggo.jpg");
            pictureBox10.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pinakbet.jpg");
            pictureBox11.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pochero.jpg");
            pictureBox12.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pork Siomai.jpg");
            pictureBox13.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\shanghai.jpg");
            pictureBox14.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\sinigang.jpg");
            pictureBox15.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\sisig.jpg");
            pictureBox16.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\sopas.jpg");
            pictureBox17.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\tinola.jpg");
            pictureBox18.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\kare kare.jpg");
            pictureBox19.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\pancit.jpg");
            pictureBox20.Image = Image.FromFile(@"C:\\Users\\Jester\\source\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\Bicol_Express.jpg");

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
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            name2lbl.Text = "Barbeque";
            itemnametextbox.Text = "Barbeque";
            pricetextbox.Text = "50";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            name1lbl.Text = "Adobo";
            itemnametextbox.Text = "Adobo";
            pricetextbox.Text = "120";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            name3lbl.Text = "Beef Nilaga";
            itemnametextbox.Text = "Beef Nilaga";
            pricetextbox.Text = "150";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            name4lbl.Text = "Giniling";
            itemnametextbox.Text = "Giniling";
            pricetextbox.Text = "100";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            name5lbl.Text = "Kaldereta";
            itemnametextbox.Text = "Kaldereta";
            pricetextbox.Text = "100";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            name6lbl.Text = "Lechon";
            itemnametextbox.Text = "Lechon";
            pricetextbox.Text = "250";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            name7lbl.Text = "Mechado";
            itemnametextbox.Text = "Mechado";
            pricetextbox.Text = "100";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            name8lbl.Text = "Menudo";
            itemnametextbox.Text = "Menudo";
            pricetextbox.Text = "120";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            name9lbl.Text = "Monggo";
            itemnametextbox.Text = "Monggo";
            pricetextbox.Text = "80";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            name10lbl.Text = "Pinakbet";
            itemnametextbox.Text = "Pinakbet";
            pricetextbox.Text = "90";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            name11lbl.Text = "Pochero";
            itemnametextbox.Text = "Pochero";
            pricetextbox.Text = "150";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            name12lbl.Text = "Pork Siomai";
            itemnametextbox.Text = "Pork Siomai";
            pricetextbox.Text = "80";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            name13lbl.Text = "Shanghai";
            itemnametextbox.Text = "Shanghai";
            pricetextbox.Text = "70";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            name14lbl.Text = "Sinigang";
            itemnametextbox.Text = "Sinigang";
            pricetextbox.Text = "120";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            name15lbl.Text = "Sisig";
            itemnametextbox.Text = "Sisig";
            pricetextbox.Text = "150";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            name16lbl.Text = "Sopas";
            itemnametextbox.Text = "Sopas";
            pricetextbox.Text = "90";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            name17lbl.Text = "Tinola";
            itemnametextbox.Text = "Tinola";
            pricetextbox.Text = "110";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            name18lbl.Text = "Kare - Kare";
            itemnametextbox.Text = "Kare - Kare";
            pricetextbox.Text = "200";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            name19lbl.Text = "Pancit";
            itemnametextbox.Text = "Pancit";
            pricetextbox.Text = "80";
        }
        //Code for inserting or assignning a calue to the Text property of a textbox 
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            name20lbl.Text = "Bicol Express";
            itemnametextbox.Text = "Bicol Express";
            pricetextbox.Text = "130";
        }
    }
}
