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
            else if (usernametextbox.Text == "Cashier 1" && passwordtextbox.Text == "cash1")
                {
                MessageBox.Show("Welcome Cashier 1!");
                Form1 form1 = new Form1();
                form1.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else if (usernametextbox.Text == "Cashier 2" && passwordtextbox.Text == "cash2")
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
            else if (usernametextbox.Text == "Cashier 3" && passwordtextbox.Text == "cash3")
            {
                MessageBox.Show("Welcome Cashier 3!");
                Form3 form3 = new Form3();
                form3.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else if (usernametextbox.Text == "Cashier 4" && passwordtextbox.Text == "cash4")
            {
                MessageBox.Show("Welcome Cashier 4!");
                Form8 form8 = new Form8();
                form8.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else if (usernametextbox.Text == "Enrollment" && passwordtextbox.Text == "enroll123")
            {
                MessageBox.Show("Welcome Enrollment!");
                Form4 form4 = new Form4();
                form4.Show();
                usernametextbox.Clear();
                passwordtextbox.Clear();
            }
            else if (usernametextbox.Text == "Payslip" && passwordtextbox.Text == "payslip123")
            {
                MessageBox.Show("Welcome to Payslip!");
                Form9 form9 = new Form9();
                form9.Show();
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
