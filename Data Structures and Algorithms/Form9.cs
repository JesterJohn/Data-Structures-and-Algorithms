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
    public partial class Form9 : Form
    {
     //codes for declaration of global variables
        private string picpath;
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_deduction = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;

        private Double netincome = 0.00,
            grossincome = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;

        private void grossincometextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bi_rate_per_hr_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bi_incometextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salaryy_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //codes for disabling textboxes
            bi_incometextbox.Enabled = false;
            hi_incometextbox.Enabled = false;
            oi_incometextbox.Enabled = false;
            netincometextbox.Enabled = false;
            grossincometextbox.Enabled = false;
            totaldeductiontextbox.Enabled = false;
            
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //cpdes for converting input data from textboxes as string as numeric
            //codes for putting data from textboxs to variables 
            sss_contrib = Convert.ToDouble(sss_contribtextbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contribtextbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contribtextbox.Text);
            tax_contrib = Convert.ToDouble(taxcontribtextbox.Text);
            sss_loan = Convert.ToDouble(sss_loantextbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loantextbox.Text);
            salary_loan = Convert.ToDouble(salary_loantextbox.Text);
            faculty_sav_loan = Convert.ToDouble(fsl_textbox.Text);
            salaryy_savings = Convert.ToDouble(fsd_textbox.Text);
            other_deduction = Convert.ToDouble(other_loantextbox.Text);

            //codes to compute the desired data to be computed 
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salaryy_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            //codes for converting numeric data to string and displayed it inside the textboxes 
            totaldeductiontextbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            netincometextbox.Text = netincome.ToString("n");

        }
        private void button6_Click(object sender, EventArgs e)
        {
            payslipview_listbox.Items.Add("---------------------------EMPLOYEE-INFORMATION----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("Employee Number: " + " " + empno_textbox.Text);
            payslipview_listbox.Items.Add("Firstname: " + " " + firstname_textbox.Text);
            payslipview_listbox.Items.Add("Middlename: " + " " + middlename_textbox.Text);
            payslipview_listbox.Items.Add("Lastname: " + " " + surname_textbox.Text);
            payslipview_listbox.Items.Add("Designation: " + " " + designation_textbox.Text);
            payslipview_listbox.Items.Add("Employee Status: " + " " + empstatus_textbox.Text);
            payslipview_listbox.Items.Add("Department: " + " " + department_textbox.Text);
            payslipview_listbox.Items.Add("Pay Date: " + " " + dateTimePicker1.Text);
            payslipview_listbox.Items.Add("---------------------------------BASIC-PAY---------------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("BP No. of Hrs.: " + " " + bi_no_of_hrs_textbox.Text);
            payslipview_listbox.Items.Add("BP Rate: " + " " + bi_rate_per_hr_textbox.Text);
            payslipview_listbox.Items.Add("Basic Pay Income: " + " " + bi_incometextbox.Text);
            payslipview_listbox.Items.Add("--------------------------------HONORARIUM---------------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("HP No. of Hrs.: " + " " + hi_noofhrstextbox.Text);
            payslipview_listbox.Items.Add("HP Rate: " + " " + hi_rateperhrtextbox.Text);
            payslipview_listbox.Items.Add("Honorarium Income: " + " " + hi_incometextbox.Text);
            payslipview_listbox.Items.Add("--------------------------------OTHER-INCOME-------------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("OP No. of Hrs.: " + " " + oi_noofhrstextbox.Text);
            payslipview_listbox.Items.Add("OP Rate: " + " " + oi_rateperhrtextbox.Text);
            payslipview_listbox.Items.Add("Other Pay Income: " + " " + oi_incometextbox.Text);
            payslipview_listbox.Items.Add("------------------------------REGULAR-DEDUCTION----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("SSS Contribution: " + " " + sss_contribtextbox.Text);
            payslipview_listbox.Items.Add("Philhealth Contribution: " + " " + philhealth_contribtextbox.Text);
            payslipview_listbox.Items.Add("Pagibig Contribution: " + " " + pagibig_contribtextbox.Text);
            payslipview_listbox.Items.Add("Tax Contribution: " + " " + taxcontribtextbox.Text);
            payslipview_listbox.Items.Add("-------------------------------OTHER-DEDUCTION-----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("SSS Loan: " + " " + sss_loantextbox.Text);
            payslipview_listbox.Items.Add("Pagibig Loan: " + " " + pagibig_loantextbox.Text);
            payslipview_listbox.Items.Add("Faculty Savings Deposit: " + " " + fsd_textbox.Text);
            payslipview_listbox.Items.Add("Faculty Savings Loan: " + " " + fsl_textbox.Text);
            payslipview_listbox.Items.Add("Salary Loan: " + " " + salary_loantextbox.Text);
            payslipview_listbox.Items.Add("Other Loan: " + " " + other_loantextbox.Text);
            payslipview_listbox.Items.Add("--------------------------------INCOME-SUMMARY-----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("Gross Income: " + " " + grossincometextbox.Text);
            payslipview_listbox.Items.Add("Net Income: " + " " + netincometextbox.Text);
            payslipview_listbox.Items.Add("-------------------------------DEDUCTION-SUMMARY---------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add("Total Deductions: " + " " + totaldeductiontextbox.Text);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form9_Printfrm printfrm = new Form9_Printfrm();
            printfrm.Displaylistbox.Items.AddRange(payslipview_listbox.Items);
            printfrm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            empno_textbox.Clear();
            firstname_textbox.Clear();
            middlename_textbox.Clear();
            surname_textbox.Clear();
            civilstatus_textbox.Clear();
            designation_textbox.Clear();
            noofdependenttextbox.Clear();
            empstatus_textbox.Clear();
            department_textbox.Clear();
            bi_no_of_hrs_textbox.Clear();
            bi_rate_per_hr_textbox.Clear();
            bi_incometextbox.Clear();
            hi_noofhrstextbox.Clear();
            hi_rateperhrtextbox.Clear();
            hi_incometextbox.Clear();
            oi_noofhrstextbox.Clear();
            oi_rateperhrtextbox.Clear();
            oi_incometextbox.Clear();
            grossincometextbox.Clear();
            netincometextbox.Clear();
            sss_contribtextbox.Clear();
            pagibig_contribtextbox.Clear();
            philhealth_contribtextbox.Clear();
            taxcontribtextbox.Clear();
            sss_loantextbox.Clear();
            pagibig_loantextbox.Clear();
            fsd_textbox.Clear();
            fsl_textbox.Clear();
            salary_loantextbox.Clear();
            other_loantextbox.Clear();
            totaldeductiontextbox.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathtextbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }
        private void oi_noofhrstextbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(oi_noofhrstextbox.Text);
            other_rate = Convert.ToDouble(oi_rateperhrtextbox.Text);
            other_netincome = other_numhrs * other_rate;
            oi_incometextbox.Text = other_netincome.ToString("n");
            grossincome = basic_netincome + hono_netincome + other_netincome;
            grossincometextbox.Text = grossincome.ToString("n");
        }

        private void hi_noofhrstextbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(hi_noofhrstextbox.Text);
            hono_rate = Convert.ToDouble(hi_rateperhrtextbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hi_incometextbox.Text = hono_netincome.ToString("n");
        }

        private void bi_no_of_hrs_textbox_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs = Convert.ToDouble(bi_no_of_hrs_textbox.Text);
            basic_rate = Convert.ToDouble(bi_rate_per_hr_textbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            bi_incometextbox.Text = basic_netincome.ToString("n");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
