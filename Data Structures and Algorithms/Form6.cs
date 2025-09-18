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
    public partial class PrelimExam_Lesson5Activity : Form
    {
        public PrelimExam_Lesson5Activity()
        {
            InitializeComponent();
        }

        private void PrelimExam_Lesson5Activity_Load(object sender, EventArgs e)
        {
            //code to disable the textbpxes 
            bi_incometextbox.Enabled = false;
            hi_incometextbox.Enabled = false;
            oi_incometextbox.Enabled = false;
            gross_incometextbox.Enabled = false;
            net_incometextbox.Enabled = false;

            sss_contribtextbox.Enabled = false;
            philhealth_contribtextbox.Enabled = false;
            pagibig_contribtextbox.Enabled = false;
            incometax_contribtextbox.Enabled = false;

            total_deductiontextbox.Enabled = false;

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code for initialization of variables 
            double bi_rate_per_hr, bi_no_of_hrs, hi_rate_per_hr, hi_no_of_hrs, oi_rate_per_hr, oi_no_of_hrs, basic_income, honorarium, other_income, gross_income,incometaxcontrib;
            bi_rate_per_hr = Convert.ToDouble(bi_rate_per_hr_textbox.Text);
            bi_no_of_hrs = Convert.ToDouble(bi_no_of_hrs_textbox.Text);
            hi_rate_per_hr = Convert.ToDouble(hi_rate_per_hr_textbox.Text);
            hi_no_of_hrs = Convert.ToDouble(hi_no_of_hrs_textbox.Text);
            oi_rate_per_hr = Convert.ToDouble(oi_rate_per_hr_textbox.Text);
            oi_no_of_hrs = Convert.ToDouble(oi_no_of_hrs_textbox.Text);
            pagibig_contribtextbox.Text = "200";

            //code for calculation
            basic_income = bi_rate_per_hr * bi_no_of_hrs;
            honorarium = hi_rate_per_hr * hi_no_of_hrs;
            other_income = oi_rate_per_hr * oi_no_of_hrs;
            gross_income = basic_income + honorarium + other_income;

            //
            bi_incometextbox.Text = basic_income.ToString("n");
            hi_incometextbox.Text = honorarium.ToString("n");
            oi_incometextbox.Text = other_income.ToString("n");
            gross_incometextbox.Text = gross_income.ToString("n");


            // code for the condition for SSS Contribution based on the gross income
            if (gross_income < 5250)
            {
                sss_contribtextbox.Text = "510";
            }
            else if (gross_income > 5250 && gross_income < 5749.99)
            {
                sss_contribtextbox.Text = "560";
            }
            else if (gross_income > 5750 && gross_income < 6249.99)
            {
                sss_contribtextbox.Text = "610";
            }
            else if (gross_income > 6250 && gross_income < 6749.99)
            {
                sss_contribtextbox.Text = "660";
            }
            else if (gross_income > 6750 && gross_income < 7249.99)
            {
                sss_contribtextbox.Text = "710";
            }
            else if (gross_income > 7250 && gross_income < 7749.99)
            {
                sss_contribtextbox.Text = "760";
            }
            else if (gross_income > 7750 && gross_income < 8249.99)
            {
                sss_contribtextbox.Text = "810";
            }
            else if (gross_income > 8250 && gross_income < 8749.99)
            {
                sss_contribtextbox.Text = "860";
            }
            else if (gross_income > 8750 && gross_income < 9249.99)
            {
                sss_contribtextbox.Text = "910";
            }
            else if (gross_income > 9250 && gross_income < 9749.99)
            {
                sss_contribtextbox.Text = "960";
            }
            else if (gross_income > 9750 && gross_income < 10249.99)
            {
                sss_contribtextbox.Text = "1010";
            }
            else if (gross_income > 10250 && gross_income < 10749.99)
            {
                sss_contribtextbox.Text = "1060";
            }
            else if (gross_income > 10750 && gross_income < 11249.99)
            {
                sss_contribtextbox.Text = "1110";
            }
            else if (gross_income > 11250 && gross_income < 11749.99)
            {
                sss_contribtextbox.Text = "1160";
            }
            else if (gross_income > 11750 && gross_income < 12249.99)
            {
                sss_contribtextbox.Text = "1210";
            }
            else if (gross_income > 12250 && gross_income < 12749.99)
            {
                sss_contribtextbox.Text = "1260";
            }
            else if (gross_income > 12750 && gross_income < 13249.99)
            {
                sss_contribtextbox.Text = "1310";
            }
            else if (gross_income > 13250 && gross_income < 13749.99)
            {
                sss_contribtextbox.Text = "1360";
            }
            else if (gross_income > 13750 && gross_income < 14249.99)
            {
                sss_contribtextbox.Text = "1410";
            }
            else if (gross_income > 14250 && gross_income < 14749.99)
            {
                sss_contribtextbox.Text = "1460";
            }
            else if (gross_income > 14750 && gross_income < 15249.99)
            {
                sss_contribtextbox.Text = "1530";
            }
            else if (gross_income > 15250 && gross_income < 15749.99)
            {
                sss_contribtextbox.Text = "1580";
            }
            else if (gross_income > 15750 && gross_income < 16249.99)
            {
                sss_contribtextbox.Text = "1630";
            }
            else if (gross_income > 16250 && gross_income < 16749.99)
            {
                sss_contribtextbox.Text = "1680";
            }
            else if (gross_income > 16750 && gross_income < 17249.99)
            {
                sss_contribtextbox.Text = "1730";
            }
            else if (gross_income > 17250 && gross_income < 17749.99)
            {
                sss_contribtextbox.Text = "1780";
            }
            else if (gross_income > 17750 && gross_income < 18249.99)
            {
                sss_contribtextbox.Text = "1830";
            }
            else if (gross_income > 18250 && gross_income < 18749.99)
            {
                sss_contribtextbox.Text = "1880";
            }
            else if (gross_income > 18750 && gross_income < 19249.99)
            {
                sss_contribtextbox.Text = "1930";
            }
            else if (gross_income > 19250 && gross_income < 19749.99)
            {
                sss_contribtextbox.Text = "1980";
            }
            else if (gross_income > 19750 && gross_income < 20249.99)
            {
                sss_contribtextbox.Text = "2030";
            }
            else if (gross_income > 20250 && gross_income < 20749.99)
            {
                sss_contribtextbox.Text = "2080";
            }
            else if (gross_income > 20750 && gross_income < 21249.99)
            {
                sss_contribtextbox.Text = "2130";
            }
            else if (gross_income > 21250 && gross_income < 21749.99)
            {
                sss_contribtextbox.Text = "2180";
            }
            else if (gross_income > 21750 && gross_income < 22249.99)
            {
                sss_contribtextbox.Text = "2230";
            }
            else if (gross_income > 22250 && gross_income < 22749.99)
            {
                sss_contribtextbox.Text = "2280";
            }
            else if (gross_income > 22750 && gross_income < 23249.99)
            {
                sss_contribtextbox.Text = "2330";
            }
            else if (gross_income > 23250 && gross_income < 23749.99)
            {
                sss_contribtextbox.Text = "2380";
            }
            else if (gross_income > 23750 && gross_income < 24249.99)
            {
                sss_contribtextbox.Text = "2430";
            }
            else if (gross_income > 24250 && gross_income < 24749.99)
            {
                sss_contribtextbox.Text = "2480";
            }
            else if (gross_income > 24750 && gross_income < 25249.99)
            {
                sss_contribtextbox.Text = "2530";
            }
            else if (gross_income > 25250 && gross_income < 25749.99)
            {
                sss_contribtextbox.Text = "2580";
            }
            else if (gross_income > 25750 && gross_income < 26249.99)
            {
                sss_contribtextbox.Text = "2630";
            }
            else if (gross_income > 26250 && gross_income < 26749.99)
            {
                sss_contribtextbox.Text = "2680";
            }
            else if (gross_income > 26750 && gross_income < 27249.99)
            {
                sss_contribtextbox.Text = "2730";
            }
            else if (gross_income > 27250 && gross_income < 27749.99)
            {
                sss_contribtextbox.Text = "2780";
            }
            else if (gross_income > 27750 && gross_income < 28249.99)
            {
                sss_contribtextbox.Text = "2830";
            }
            else if (gross_income > 28250 && gross_income < 28749.99)
            {
                sss_contribtextbox.Text = "2880";
            }
            else if (gross_income > 28750 && gross_income < 29249.99)
            {
                sss_contribtextbox.Text = "2930";
            }
            else if (gross_income > 29250 && gross_income < 29749.99)
            {
                sss_contribtextbox.Text = "2980";
            }
            else if (gross_income > 29750 && gross_income < 30249.99)
            {
                sss_contribtextbox.Text = "3030";
            }
            else if (gross_income > 30250 && gross_income < 30749.99)
            {
                sss_contribtextbox.Text = "3080";
            }
            else if (gross_income > 30750 && gross_income < 31249.99)
            {
                sss_contribtextbox.Text = "3130";
            }
            else if (gross_income > 31250 && gross_income < 31749.99)
            {
                sss_contribtextbox.Text = "3180";
            }
            else if (gross_income > 31750 && gross_income < 32249.99)
            {
                sss_contribtextbox.Text = "3230";
            }
            else if (gross_income > 32250 && gross_income < 32749.99)
            {
                sss_contribtextbox.Text = "3280";
            }
            else if (gross_income > 32750 && gross_income < 33249.99)
            {
                sss_contribtextbox.Text = "3330";
            }
            else if (gross_income > 33250 && gross_income < 33749.99)
            {
                sss_contribtextbox.Text = "3380";
            }
            else if (gross_income > 33750 && gross_income < 34249.99)
            {
                sss_contribtextbox.Text = "3430";
            }
            else if (gross_income > 34250 && gross_income < 34749.99)
            {
                sss_contribtextbox.Text = "3480";
            }
            else
                sss_contribtextbox.Text = "3530";

            //code for condition of PHILHealth Contribution based on the gross income 

            if (gross_income < 5250)
            {
                philhealth_contribtextbox.Text = "250";
            }
            else if (gross_income > 5250 && gross_income < 5749.99)
            {
                philhealth_contribtextbox.Text = "275";
            }
            else if (gross_income > 5750 && gross_income < 6249.99)
            {
                philhealth_contribtextbox.Text = "300";
            }
            else if (gross_income > 6250 && gross_income < 6749.99)
            {
                philhealth_contribtextbox.Text = "325";
            }
            else if (gross_income > 6750 && gross_income < 7249.99)
            {
                philhealth_contribtextbox.Text = "350";
            }
            else if (gross_income > 7250 && gross_income < 7749.99)
            {
                philhealth_contribtextbox.Text = "375";
            }
            else if (gross_income > 7750 && gross_income < 8249.99)
            {
                philhealth_contribtextbox.Text = "400";
            }
            else if (gross_income > 8250 && gross_income < 8749.99)
            {
                philhealth_contribtextbox.Text = "425";
            }
            else if (gross_income > 8750 && gross_income < 9249.99)
            {
                philhealth_contribtextbox.Text = "450";
            }
            else if (gross_income > 9250 && gross_income < 9749.99)
            {
                philhealth_contribtextbox.Text = "475";
            }
            else if (gross_income > 9750 && gross_income < 10249.99)
            {
                philhealth_contribtextbox.Text = "500";
            }
            else if (gross_income > 10250 && gross_income < 10749.99)
            {
                philhealth_contribtextbox.Text = "525";
            }
            else if (gross_income > 10750 && gross_income < 11249.99)
            {
                philhealth_contribtextbox.Text = "550";
            }
            else if (gross_income > 11250 && gross_income < 11749.99)
            {
                philhealth_contribtextbox.Text = "575";
            }
            else if (gross_income > 11750 && gross_income < 12249.99)
            {
                philhealth_contribtextbox.Text = "600";
            }
            else if (gross_income > 12250 && gross_income < 12749.99)
            {
                philhealth_contribtextbox.Text = "625";
            }
            else if (gross_income > 12750 && gross_income < 13249.99)
            {
                philhealth_contribtextbox.Text = "650";
            }
            else if (gross_income > 13250 && gross_income < 13749.99)
            {
                philhealth_contribtextbox.Text = "675";
            }
            else if (gross_income > 13750 && gross_income < 14249.99)
            {
                philhealth_contribtextbox.Text = "700";
            }
            else if (gross_income > 14250 && gross_income < 14749.99)
            {
                philhealth_contribtextbox.Text = "725";
            }
            else if (gross_income > 14750 && gross_income < 15249.99)
            {
                philhealth_contribtextbox.Text = "750";
            }
            else if (gross_income > 15250 && gross_income < 15749.99)
            {
                philhealth_contribtextbox.Text = "775";
            }
            else if (gross_income > 15750 && gross_income < 16249.99)
            {
                philhealth_contribtextbox.Text = "800";
            }
            else if (gross_income > 16250 && gross_income < 16749.99)
            {
                philhealth_contribtextbox.Text = "825";
            }
            else if (gross_income > 16750 && gross_income < 17249.99)
            {
                philhealth_contribtextbox.Text = "850";
            }
            else if (gross_income > 17250 && gross_income < 17749.99)
            {
                philhealth_contribtextbox.Text = "875";
            }
            else if (gross_income > 17750 && gross_income < 18249.99)
            {
                philhealth_contribtextbox.Text = "900";
            }
            else if (gross_income > 18250 && gross_income < 18749.99)
            {
                philhealth_contribtextbox.Text = "925";
            }
            else if (gross_income > 18750 && gross_income < 19249.99)
            {
                philhealth_contribtextbox.Text = "950";
            }
            else if (gross_income > 19250 && gross_income < 19749.99)
            {
                philhealth_contribtextbox.Text = "975";
            }
            else if (gross_income > 19750 && gross_income < 20249.99)
            {
                philhealth_contribtextbox.Text = "1000";
            }
            else if (gross_income > 20250 && gross_income < 20749.99)
            {
                philhealth_contribtextbox.Text = "1025";
            }
            else if (gross_income > 20750 && gross_income < 21249.99)
            {
                philhealth_contribtextbox.Text = "1050";
            }
            else if (gross_income > 21250 && gross_income < 21749.99)
            {
                philhealth_contribtextbox.Text = "1075";
            }
            else if (gross_income > 21750 && gross_income < 22249.99)
            {
                philhealth_contribtextbox.Text = "1100";
            }
            else if (gross_income > 22250 && gross_income < 22749.99)
            {
                philhealth_contribtextbox.Text = "1125";
            }
            else if (gross_income > 22750 && gross_income < 23249.99)
            {
                philhealth_contribtextbox.Text = "1150";
            }
            else if (gross_income > 23250 && gross_income < 23749.99)
            {
                philhealth_contribtextbox.Text = "1175";
            }
            else if (gross_income > 23750 && gross_income < 24249.99)
            {
                philhealth_contribtextbox.Text = "1200";
            }
            else if (gross_income > 24250 && gross_income < 24749.99)
            {
                philhealth_contribtextbox.Text = "1225";
            }
            else if (gross_income > 24750 && gross_income < 25249.99)
            {
                philhealth_contribtextbox.Text = "1250";
            }
            else if (gross_income > 25250 && gross_income < 25749.99)
            {
                philhealth_contribtextbox.Text = "1275";
            }
            else if (gross_income > 25750 && gross_income < 26249.99)
            {
                philhealth_contribtextbox.Text = "1300";
            }
            else if (gross_income > 26250 && gross_income < 26749.99)
            {
                philhealth_contribtextbox.Text = "1325";
            }
            else if (gross_income > 26750 && gross_income < 27249.99)
            {
                philhealth_contribtextbox.Text = "1350";
            }
            else if (gross_income > 27250 && gross_income < 27749.99)
            {
                philhealth_contribtextbox.Text = "1375";
            }
            else if (gross_income > 27750 && gross_income < 28249.99)
            {
                philhealth_contribtextbox.Text = "1400";
            }
            else if (gross_income > 28250 && gross_income < 28749.99)
            {
                philhealth_contribtextbox.Text = "1425";
            }
            else if (gross_income > 28750 && gross_income < 29249.99)
            {
                philhealth_contribtextbox.Text = "1450";
            }
            else if (gross_income > 29250 && gross_income < 29749.99)
            {
                philhealth_contribtextbox.Text = "1475";
            }
            else if (gross_income > 29750 && gross_income < 30249.99)
            {
                philhealth_contribtextbox.Text = "1500";
            }
            else if (gross_income > 30250 && gross_income < 30749.99)
            {
                philhealth_contribtextbox.Text = "1525";
            }
            else if (gross_income > 30750 && gross_income < 31249.99)
            {
                philhealth_contribtextbox.Text = "1550";
            }
            else if (gross_income > 31250 && gross_income < 31749.99)
            {
                philhealth_contribtextbox.Text = "1575";
            }
            else if (gross_income > 31750 && gross_income < 32249.99)
            {
                philhealth_contribtextbox.Text = "1600";
            }
            else if (gross_income > 32250 && gross_income < 32749.99)
            {
                philhealth_contribtextbox.Text = "1625";
            }
            else if (gross_income > 32750 && gross_income < 33249.99)
            {
                philhealth_contribtextbox.Text = "1650";
            }
            else if (gross_income > 33250 && gross_income < 33749.99)
            {
                philhealth_contribtextbox.Text = "1675";
            }
            else if (gross_income > 33750 && gross_income < 34249.99)
            {
                philhealth_contribtextbox.Text = "1700";
            }
            else if (gross_income > 34250 && gross_income < 34749.99)
            {
                philhealth_contribtextbox.Text = "1725";
            }
            else
                philhealth_contribtextbox.Text = "1750";

            // code for contition of Income Tax Contribution based on the gross income


            if (gross_income < (250000/12))
            {
                incometaxcontrib = 0.00;
            }
            else if (gross_income > (250000/12) && gross_income < (400000/12))
            {
                incometaxcontrib = (gross_income * 0.15);
            }
            else if (gross_income > (400000 / 12) && gross_income < (800000 / 12))
            {
                incometaxcontrib = (gross_income - 250000) * 0.20;
            }
            else if (gross_income > (800000 / 12) && gross_income < (2000000 / 12))
            {
                incometaxcontrib = (gross_income - 400000) * 0.25;
            }
            else if (gross_income > (2000000 / 12) && gross_income < (8000000 / 12))
            {
                incometaxcontrib = (gross_income - 2000000) * 0.30;
            }
            else
            {
                incometaxcontrib = (gross_income - (8000000 / 12)) * 0.35;
            }
            incometax_contribtextbox.Text = incometaxcontrib.ToString("n");
        } 


        private void button2_Click(object sender, EventArgs e)
                {
                    // code for initializing the variables 
                    double sss_contrib, philhealth_contrib, pagibig_contrib, incometax_contrib;
                    double sss_loan, pagibig_loan, savings_deposit, savings_loan, salary_loan, other_loan;
                    double total_deduction, net_income, gross_income;

                    sss_contrib = Convert.ToDouble(sss_contribtextbox.Text);
                    philhealth_contrib = Convert.ToDouble(philhealth_contribtextbox.Text);
                    pagibig_contrib = Convert.ToDouble(pagibig_contribtextbox.Text);
                    incometax_contrib = Convert.ToDouble(incometax_contribtextbox.Text);

                    sss_loan = Convert.ToDouble(sss_loantextbox.Text);
                    pagibig_loan = Convert.ToDouble(pagibig_loantextbox.Text);
                    savings_deposit = Convert.ToDouble(facultysavings_deposittextbox.Text);
                    savings_loan = Convert.ToDouble(facultysavings_loantextbox.Text);
                    salary_loan = Convert.ToDouble(salary_loantextbox.Text);
                    other_loan = Convert.ToDouble(other_loantextbox.Text);
                    gross_income = Convert.ToDouble(gross_incometextbox.Text);

                    // code for the formulas 
                    total_deduction = sss_contrib + philhealth_contrib + pagibig_contrib + incometax_contrib + sss_loan + pagibig_loan + savings_deposit + savings_loan + salary_loan + other_loan;
                    net_income = gross_income - total_deduction;

                    total_deductiontextbox.Text = total_deduction.ToString("n");
                    net_incometextbox.Text = net_income.ToString("n");

                }

        private void button5_Click(object sender, EventArgs e)
        {
            //code to clear all the textboxes 
            empno_textbox.Clear();
            department_textbox.Clear();
            firstname_textbox.Clear();
            middlename_textbox.Clear();
            surname_textbox.Clear();    
            civilstatus_textbox.Clear();
            QDS_textbox.Clear();
            empstatus_textbox.Clear();
            designation_textbox.Clear();

            bi_incometextbox.Clear();
            bi_rate_per_hr_textbox.Clear();
            bi_no_of_hrs_textbox.Clear();
            hi_incometextbox.Clear();
            hi_rate_per_hr_textbox.Clear();
            hi_no_of_hrs_textbox.Clear();
            oi_incometextbox.Clear();
            oi_rate_per_hr_textbox.Clear();
            oi_no_of_hrs_textbox.Clear();

            gross_incometextbox.Clear();
            net_incometextbox.Clear();

            sss_contribtextbox.Clear();
            philhealth_contribtextbox.Clear();
            pagibig_contribtextbox.Clear();
            incometax_contribtextbox.Clear();
            
            sss_loantextbox.Clear();
            pagibig_loantextbox.Clear();
            facultysavings_deposittextbox.Clear();
            facultysavings_loantextbox.Clear();
            salary_loantextbox.Clear();
            other_loantextbox.Clear();

            total_deductiontextbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // codes to transfer all the data from one form to another form
            Savebtn print = new Savebtn();

            print.dis_basicdaytextbox.Text = bi_no_of_hrs_textbox.Text;
            print.dis_basictaxtextbox.Text = bi_incometextbox.Text;
            print.dis_overtimedaytextbox.Text = oi_no_of_hrs_textbox.Text;
            print.dis_overtimetaxtextbox.Text = oi_incometextbox.Text;
            print.dis_honordaytextbox.Text = hi_no_of_hrs_textbox.Text;
            print.dis_honortaxtextbox.Text = hi_incometextbox.Text;

            print.dis_honoradjdaytextbox.Text = "0.00";
            print.dis_subdaytextbox.Text = "0.00";
            print.dis_tardydaytextbox.Text = "0.00";
            print.dis_honooradjtaxtextbox.Text = "0.00";
            print.dis_subtaxtextbox.Text = "0.00";
            print.dis_tardytaxtextbox.Text = "0.00";
            print.dis_nonbasictextbox.Text = "0.00";
            print.dis_nonovertimetextbox.Text = "0.00";
            print.dis_nonhonortextbox.Text = "0.00";
            print.dis_nonhonoradjtextbox.Text = "0.00";
            print.dis_nonsubtextbox.Text = "0.00";
            print.dis_nontardytextbox.Text = "0.00";

            print.dis_departmenttextbox.Text = department_textbox.Text;
            print.dis_empcodetextbox.Text = empno_textbox.Text;
            print.dis_empnametextbox.Text = surname_textbox.Text + ", " + firstname_textbox.Text + " " + middlename_textbox.Text;
            print.dis_cutofftextbox.Text = dateTimePicker1.Value.ToString("MMMM dd,yyyy");
            print.dis_payperiodtextbox.Text = dateTimePicker1.Value.ToString("MMMM dd,yyyy");

            print.dis_withholdingtaxtextbox.Text = incometax_contribtextbox.Text;
            print.dis_ssscontribtextbox.Text = sss_contribtextbox.Text;
            print.dis_hdmfcontribtextbox.Text = pagibig_contribtextbox.Text;
            print.dis_philhealthcontribtextbox.Text = philhealth_contribtextbox.Text;
            print.dis_wispcontribtextbox.Text = "750.00";

            print.dis_earningstextbox.Text = gross_incometextbox.Text;
            print.dis_deductiontextbox.Text = total_deductiontextbox.Text;
            print.display_overtimetexbox.Text = oi_incometextbox.Text;

            print.dis_grossearningstextbox.Text = gross_incometextbox.Text;
            print.dis2_deductiontexbox.Text = total_deductiontextbox.Text;
            print.dis_netpaytextbox.Text = net_incometextbox.Text;



            print.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
