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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernametextbox.Text == "Admin" && passwordtextbox.Text == "admin123")
            {
                MessageBox.Show("Welcome Admin!");
                MainFrm mainFrm = new MainFrm();
                mainFrm.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else if (usernametextbox.Text == "Cashier 1" && passwordtextbox.Text == "12345")
                {
                MessageBox.Show("Welcome Cashier 1!");
                Form1 form1 = new Form1();
                form1.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else if (usernametextbox.Text == "Cashier 2" && passwordtextbox.Text == "54321")
            {
                MessageBox.Show("Welcome Cashier 2!");
                Form2 form2 = new Form2();
                form2.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else if (usernametextbox.Text == "Payroll" && passwordtextbox.Text == "payroll123")
            {
                MessageBox.Show("Welcome Payroll!");
                PrelimExam_Lesson5Activity prelimExam_Lesson5Activity = new PrelimExam_Lesson5Activity();
                prelimExam_Lesson5Activity.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            {
                
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
