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
    public partial class Payroll_FunctionFrm : Form
    {
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

        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salaryy_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;

        private void CalculateAndSetIncome(TextBox numHrsTextBox, TextBox rateTextBox, ref Double hoursField, ref Double rateField, ref Double incomeField, TextBox incomeTextBox)
        {
            if (Double.TryParse(numHrsTextBox.Text, out double hours) && Double.TryParse(rateTextBox.Text, out double rate))
            {
                hoursField = hours;
                rateField = rate;
                incomeField = hoursField * rateField;
                incomeTextBox.Text = incomeField.ToString("n");
            }
            else
            {
                incomeField = 0.00;
                incomeTextBox.Text = 0.00.ToString("n");
            }

            UpdateGrossIncome();
        }

        private void UpdateGrossIncome()
        {
            grossincome = basic_netincome + hono_netincome + other_netincome;
            grossincometextbox.Text = grossincome.ToString("n");
        }

        private void ClearAllTextBoxes()
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

            basic_netincome = hono_netincome = other_netincome = 0.00;
            grossincome = netincome = total_deduction = 0.00;
        }

        private void CalculatePayrollSummary()
        {
            Double GetTextBoxValue(TextBox textBox)
            {
                return Double.TryParse(textBox.Text, out double value) ? value : 0.00;
            }

            sss_contrib = GetTextBoxValue(sss_contribtextbox);
            pagibig_contrib = GetTextBoxValue(pagibig_contribtextbox);
            philhealth_contrib = GetTextBoxValue(philhealth_contribtextbox);
            tax_contrib = GetTextBoxValue(taxcontribtextbox);

            sss_loan = GetTextBoxValue(sss_loantextbox);
            pagibig_loan = GetTextBoxValue(pagibig_loantextbox);
            salary_loan = GetTextBoxValue(salary_loantextbox);
            faculty_sav_loan = GetTextBoxValue(fsl_textbox);
            salaryy_savings = GetTextBoxValue(fsd_textbox);
            other_deduction = GetTextBoxValue(other_loantextbox);

            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salaryy_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            netincome = grossincome - total_deduction;

            totaldeductiontextbox.Text = total_deduction.ToString("n");
            netincometextbox.Text = netincome.ToString("n");
        }

        private void GeneratePayslipView()
        {
            payslipview_listbox.Items.Clear();

            payslipview_listbox.Items.Add("---------------------------EMPLOYEE-INFORMATION----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"Employee Number: {empno_textbox.Text}");
            payslipview_listbox.Items.Add($"Firstname: {firstname_textbox.Text}");
            payslipview_listbox.Items.Add($"Middlename: {middlename_textbox.Text}");
            payslipview_listbox.Items.Add($"Lastname: {surname_textbox.Text}");
            payslipview_listbox.Items.Add($"Designation: {designation_textbox.Text}");
            payslipview_listbox.Items.Add($"Employee Status: {empstatus_textbox.Text}");
            payslipview_listbox.Items.Add($"Department: {department_textbox.Text}");
            payslipview_listbox.Items.Add($"Pay Date: {dateTimePicker1.Text}");

            payslipview_listbox.Items.Add("---------------------------------BASIC-PAY---------------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"BP No. of Hrs.: {bi_no_of_hrs_textbox.Text}");
            payslipview_listbox.Items.Add($"BP Rate: {bi_rate_per_hr_textbox.Text}");
            payslipview_listbox.Items.Add($"Basic Pay Income: {bi_incometextbox.Text}");

            payslipview_listbox.Items.Add("--------------------------------HONORARIUM---------------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"HP No. of Hrs.: {hi_noofhrstextbox.Text}");
            payslipview_listbox.Items.Add($"HP Rate: {hi_rateperhrtextbox.Text}");
            payslipview_listbox.Items.Add($"Honorarium Income: {hi_incometextbox.Text}");

            payslipview_listbox.Items.Add("--------------------------------OTHER-INCOME-------------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"OP No. of Hrs.: {oi_noofhrstextbox.Text}");
            payslipview_listbox.Items.Add($"OP Rate: {oi_rateperhrtextbox.Text}");
            payslipview_listbox.Items.Add($"Other Pay Income: {oi_incometextbox.Text}");

            payslipview_listbox.Items.Add("------------------------------REGULAR-DEDUCTION----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"SSS Contribution: {sss_contribtextbox.Text}");
            payslipview_listbox.Items.Add($"Philhealth Contribution: {philhealth_contribtextbox.Text}");
            payslipview_listbox.Items.Add($"Pagibig Contribution: {pagibig_contribtextbox.Text}");
            payslipview_listbox.Items.Add($"Tax Contribution: {taxcontribtextbox.Text}");

            payslipview_listbox.Items.Add("-------------------------------OTHER-DEDUCTION-----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"SSS Loan: {sss_loantextbox.Text}");
            payslipview_listbox.Items.Add($"Pagibig Loan: {pagibig_loantextbox.Text}");
            payslipview_listbox.Items.Add($"Faculty Savings Deposit: {fsd_textbox.Text}");
            payslipview_listbox.Items.Add($"Faculty Savings Loan: {fsl_textbox.Text}");
            payslipview_listbox.Items.Add($"Salary Loan: {salary_loantextbox.Text}");
            payslipview_listbox.Items.Add($"Other Loan: {other_loantextbox.Text}");

            payslipview_listbox.Items.Add("--------------------------------INCOME-SUMMARY-----------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"Gross Income: {grossincometextbox.Text}");
            payslipview_listbox.Items.Add($"Net Income: {netincometextbox.Text}");

            payslipview_listbox.Items.Add("-------------------------------DEDUCTION-SUMMARY---------------------------");
            payslipview_listbox.Items.Add("---------------------------------------------------------------------------");
            payslipview_listbox.Items.Add($"Total Deductions: {totaldeductiontextbox.Text}");
        }

        private void oi_noofhrstextbox_TextChanged_1(object sender, EventArgs e)
        {
            CalculateAndSetIncome(oi_noofhrstextbox, oi_rateperhrtextbox, ref other_numhrs, ref other_rate, ref other_netincome, oi_incometextbox);
        }

        private void hi_noofhrstextbox_TextChanged_1(object sender, EventArgs e)
        {
            CalculateAndSetIncome(hi_noofhrstextbox, hi_rateperhrtextbox, ref hono_numhrs, ref hono_rate, ref hono_netincome, hi_incometextbox);
        }

        private void bi_no_of_hrs_textbox_TextChanged_1(object sender, EventArgs e)
        {
            CalculateAndSetIncome(bi_no_of_hrs_textbox, bi_rate_per_hr_textbox, ref basic_numhrs, ref basic_rate, ref basic_netincome, bi_incometextbox);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CalculatePayrollSummary();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            GeneratePayslipView();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public Payroll_FunctionFrm()
        {
            InitializeComponent();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form9_Printfrm printfrm = new Form9_Printfrm();
            printfrm.Displaylistbox.Items.AddRange(payslipview_listbox.Items);
            printfrm.Show();
        }

        private void Payroll_FunctionFrm_Load(object sender, EventArgs e)
        {
            bi_incometextbox.Enabled = false;
            hi_incometextbox.Enabled = false;
            oi_incometextbox.Enabled = false;
            netincometextbox.Enabled = false;
            grossincometextbox.Enabled = false;
            totaldeductiontextbox.Enabled = false;
        }
    }
}