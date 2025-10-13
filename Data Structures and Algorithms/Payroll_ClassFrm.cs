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
    
    public partial class Payroll_ClassFrm : Form
    {
        Variables1 variables1 = new Variables1();
        public Payroll_ClassFrm()
        {
            InitializeComponent();
        }
        private void computation_Summary_Formula_and_DisplayData()
        {
            variables1.BasicIncome = Convert.ToDouble(bi_incometextbox.Text);
            variables1.HonorariumIncome = Convert.ToDouble(hi_incometextbox.Text);
            variables1.OtherIncome = Convert.ToDouble(oi_incometextbox.Text);
            variables1.GrossIncome = variables1.BasicIncome + variables1.HonorariumIncome + variables1.OtherIncome;
            grossincometextbox.Text = variables1.GrossIncome.ToString("n");

            variables1.SSS = Convert.ToDouble(sss_contribtextbox.Text);
            variables1.Pagibig = Convert.ToDouble(pagibig_contribtextbox.Text);
            variables1.PhilHealth = Convert.ToDouble(philhealth_contribtextbox.Text);
            variables1.Tax = Convert.ToDouble(taxcontribtextbox.Text);
            variables1.SSSLoan = Convert.ToDouble(sss_loantextbox.Text);
            variables1.PagibigLoan = Convert.ToDouble(pagibig_loantextbox.Text);
            variables1.FacultySavingsDeposit = Convert.ToDouble(fsd_textbox.Text);
            variables1.FacultySavingsLoan = Convert.ToDouble(fsl_textbox.Text);
            variables1.SalaryLoan = Convert.ToDouble(salary_loantextbox.Text);
            variables1.OtherLoan = Convert.ToDouble(other_loantextbox.Text);

            variables1.TotalDeduction = variables1.SSS + variables1.Pagibig + variables1.PhilHealth + variables1.Tax + variables1.SSSLoan+ variables1.PagibigLoan + variables1.FacultySavingsDeposit + variables1.FacultySavingsLoan + variables1.SalaryLoan + variables1.OtherLoan;
            totaldeductiontextbox.Text = variables1.TotalDeduction.ToString("n");

            variables1.NetIncome = variables1.GrossIncome - variables1.TotalDeduction;
            netincometextbox.Text = variables1.NetIncome.ToString("n"); 
        }
        private void computation_Basic_Formula_and_DisplayData()
        {
            variables1.BasicHours = Convert.ToDouble(bi_no_of_hrs_textbox.Text);
            variables1.BasicRatePerHour = Convert.ToDouble(bi_rate_per_hr_textbox.Text);
            variables1.BasicIncome = variables1.BasicHours * variables1.BasicRatePerHour;
            bi_incometextbox.Text = variables1.BasicIncome.ToString("n");
        }
        private void computation_Honorarium_Formula_and_DisplayData()
        {
            variables1.HonorariumHours = Convert.ToDouble(hi_noofhrstextbox.Text);
            variables1.HonorariumRatePerHour = Convert.ToDouble(hi_rateperhrtextbox.Text);
            variables1.HonorariumIncome = variables1.HonorariumHours * variables1.HonorariumRatePerHour;
            hi_incometextbox.Text = variables1.HonorariumIncome.ToString("n");
        }
        private void computation_Other_Formula_and_DisplayData()
        {
            variables1.OtherHours = Convert.ToDouble(oi_noofhrstextbox.Text);
            variables1.OtherRatePerHour = Convert.ToDouble(oi_rateperhrtextbox.Text);
            variables1.OtherIncome = variables1.OtherHours * variables1.OtherRatePerHour;
            oi_incometextbox.Text = variables1.OtherIncome.ToString("n");
            variables1.GrossIncome = variables1.BasicIncome + variables1.HonorariumIncome + variables1.OtherIncome;
            grossincometextbox.Text = variables1.GrossIncome.ToString("n");
        }
        
        private void Payroll_ClassFrm_Load(object sender, EventArgs e)
        {
            bi_incometextbox.Enabled = false;
            hi_incometextbox.Enabled = false;
            oi_incometextbox.Enabled = false;
            netincometextbox.Enabled = false;
            grossincometextbox.Enabled = false;
            totaldeductiontextbox.Enabled = false;
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

            payslipview_listbox.Items.Clear();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            computation_Summary_Formula_and_DisplayData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void bi_no_of_hrs_textbox_TextChanged(object sender, EventArgs e)
        {
            computation_Basic_Formula_and_DisplayData();
        }

        private void hi_noofhrstextbox_TextChanged(object sender, EventArgs e)
        {
            computation_Honorarium_Formula_and_DisplayData();
        }

        private void oi_noofhrstextbox_TextChanged(object sender, EventArgs e)
        {
            computation_Other_Formula_and_DisplayData();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
