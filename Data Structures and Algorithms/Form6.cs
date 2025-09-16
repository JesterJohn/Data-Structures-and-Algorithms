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

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bi_rate_per_hr, bi_no_of_hrs, hi_rate_per_hr, hi_no_of_hrs, oi_rate_per_hr, oi_no_of_hrs, basic_income, honorarium, other_income, gross_income,pagibig_contribution;
            bi_rate_per_hr = Convert.ToInt32(bi_rate_per_hr_textbox.Text);
            bi_no_of_hrs = Convert.ToInt32(bi_no_of_hrs_textbox.Text);
            hi_rate_per_hr = Convert.ToInt32(hi_rate_per_hr_textbox.Text);
            hi_no_of_hrs = Convert.ToInt32(hi_no_of_hrs_textbox.Text);
            oi_rate_per_hr = Convert.ToInt32(oi_rate_per_hr_textbox.Text);
            oi_no_of_hrs = Convert.ToInt32(oi_no_of_hrs_textbox.Text);
            pagibig_contribution = 200;
            

            basic_income = bi_rate_per_hr * bi_no_of_hrs;
            honorarium = hi_rate_per_hr * hi_no_of_hrs;
            other_income = oi_rate_per_hr * oi_no_of_hrs;
            gross_income = basic_income + honorarium + other_income;


            bi_incometextbox.Text = basic_income.ToString("n");
            hi_incometextbox.Text = honorarium.ToString("n");
            oi_incometextbox.Text = other_income.ToString("n");
            gross_incometextbox.Text = gross_income.ToString("n");

            if (gross_income < 5250)
            {
                sss_contribtextbox.Text = "510";
            }
            else if (gross_income >5250 && gross_income <5749.99)
            {
                sss_contribtextbox.Text = "560";
            }
            else if (gross_income > 5750 && gross_income <6249.99)
            {
                sss_contribtextbox.Text = "610";
            }
            else if (gross_income > 6250 && gross_income <6749.99)
            {
                sss_contribtextbox.Text = "660";
            }
            else if (gross_income > 6750 && gross_income <7249.99)
            {
                sss_contribtextbox.Text = "710";
            }
            else if (gross_income > 7250 && gross_income <7749.99)
            {
                sss_contribtextbox.Text = "760";
            }
            else if (gross_income > 7750 && gross_income <8249.99)
            {
                sss_contribtextbox.Text = "810";
            }
            else if (gross_income > 8250 && gross_income <8749.99)
            {
                sss_contribtextbox.Text = "860";
            }
            else if (gross_income > 8750 && gross_income <9249.99)
            {
                sss_contribtextbox.Text = "910";
            }
            else if (gross_income > 9250 && gross_income <9749.99)
            {
                sss_contribtextbox.Text = "960";
            }
            else if (gross_income > 9750 && gross_income <10249.99)
            {
                sss_contribtextbox.Text = "1010";
            }
            else if (gross_income > 10250 && gross_income <10749.99)
            {
                sss_contribtextbox.Text = "1060";
            }
            else if (gross_income > 10750 && gross_income <11249.99)
            {
                sss_contribtextbox.Text = "1110";
            }
            else if (gross_income > 11250 && gross_income <11749.99)
            {
                sss_contribtextbox.Text = "1160";
            }
            else if (gross_income > 11750 && gross_income <12249.99)
            {
                sss_contribtextbox.Text = "1210";
            }
            else if (gross_income > 12250 && gross_income <12749.99)
            {
                sss_contribtextbox.Text = "1260";
            }
            else if (gross_income > 12750 && gross_income <13249.99)
            {
                 sss_contribtextbox.Text = "1310";
            }
            else if (gross_income > 13250 && gross_income <13749.99)
            {
                sss_contribtextbox.Text = "1360";
            }
            else if (gross_income > 13750 && gross_income <14249.99)
            {
                sss_contribtextbox.Text = "1410";
            }
            else if (gross_income > 14250 && gross_income <14749.99)
            {
                sss_contribtextbox.Text = "1460";
            }
            else if (gross_income > 14750 && gross_income <15249.99)
            {
                sss_contribtextbox.Text = "1510";
            }
            else if (gross_income > 15250 && gross_income <15749.99)
            {
                sss_contribtextbox.Text = "1560";
            }
            else if (gross_income > 15750 && gross_income <16249.99)
            {
                sss_contribtextbox.Text = "1610";
            }
            else if (gross_income > 16250 && gross_income <16749.99)
            {
                sss_contribtextbox.Text = "1660";
            }
            else if (gross_income > 16750 && gross_income <17249.99)
            {
                sss_contribtextbox.Text = "1710";
            }
            else if (gross_income > 17250 && gross_income <17749.99)
            {
                sss_contribtextbox.Text = "1760";
            }
            else if (gross_income > 17750 && gross_income <18249.99)
            {
                sss_contribtextbox.Text = "1810";
            }
            else if (gross_income > 18250 && gross_income <18749.99)
            {
                sss_contribtextbox.Text = "1860";
            }
            else if (gross_income > 18750 && gross_income <19249.99)
            {
                sss_contribtextbox.Text = "1910";
            }
            else if (gross_income > 19250 && gross_income <19749.99)
            {
                sss_contribtextbox.Text = "1960";
            }
            else if (gross_income > 19750 && gross_income <20249.99)
            {
                sss_contribtextbox.Text = "2010";
            }
            else if (gross_income > 20250 && gross_income <20749.99)
            {
                sss_contribtextbox.Text = "2060";
            }
            else if (gross_income > 20750 && gross_income <21249.99)
            {
                sss_contribtextbox.Text = "2110";
            }
            else if (gross_income > 21250 && gross_income <21749.99)
            {
                sss_contribtextbox.Text = "2160";
            }
            else if (gross_income > 21750 && gross_income <22249.99)
            {
                sss_contribtextbox.Text = "2210";
            }
            else if (gross_income > 22250 && gross_income <22749.99)
            {
                sss_contribtextbox.Text = "2260";
            }
            else if (gross_income > 22750 && gross_income <23249.99)
            {
                sss_contribtextbox.Text = "2310";
            }
            else if (gross_income > 23250 && gross_income <23749.99)
            {
                sss_contribtextbox.Text = "2360";
            }
            else if (gross_income > 23750 && gross_income <24249.99)
            {
                sss_contribtextbox.Text = "2410";
            }
            else if (gross_income > 24250 && gross_income <24749.99)
            {
                sss_contribtextbox.Text = "2460";
            }
            else if (gross_income > 24750 && gross_income <25249.99)
            {
                sss_contribtextbox.Text = "2510";
            }
            else if (gross_income > 25250 && gross_income <25749.99)
            {
                sss_contribtextbox.Text = "2560";
            }
            else if (gross_income > 25750 && gross_income <26249.99)
            {
                sss_contribtextbox.Text = "2610";
            }
            else if (gross_income > 26250 && gross_income <26749.99)
            {
                sss_contribtextbox.Text = "2660";
            }
            else if (gross_income > 26750 && gross_income <27249.99)
            {
                sss_contribtextbox.Text = "2710";
            }
            else if (gross_income > 27250 && gross_income <27749.99)
            {
                sss_contribtextbox.Text = "2760";
            }
            else if (gross_income > 27750 && gross_income <28249.99)
            {
                sss_contribtextbox.Text = "2810";
            }
            else if (gross_income > 28250 && gross_income <28749.99)
            {
                sss_contribtextbox.Text = "2860";
            }
            else if (gross_income > 28750 && gross_income <29249.99)
            {
                sss_contribtextbox.Text = "2910";
            }
            else if (gross_income > 29250 && gross_income <29749.99)
            {
                sss_contribtextbox.Text = "2960";
            }
            else if (gross_income > 29750)
            {
                sss_contribtextbox.Text = "3010";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double sss_contrib, philhealth_contrib, pagibig_contrib, incometax_contrib, sss_loan, pagibig_loan, savings_deposit, savings_loan, salary_loan, other_loan, total_deduction, net_income, gross_income;
            sss_contrib = Convert.ToInt32(sss_contribtextbox.Text); 
            philhealth_contrib = Convert.ToInt32(philhealth_contribtextbox.Text);
            pagibig_contrib = Convert.ToInt32(pagibig_contribtextbox.Text);
            incometax_contrib = Convert.ToInt32(incometax_contribtextbox.Text);
            sss_loan = Convert.ToInt32(sss_loantextbox.Text);
            pagibig_loan = Convert.ToInt32(pagibig_loantextbox.Text);
            savings_deposit = Convert.ToInt32(facultysavings_deposittextbox.Text);
            savings_loan = Convert.ToInt32(facultysavings_loantextbox.Text);
            salary_loan = Convert.ToInt32(salary_loantextbox.Text); 
            other_loan = Convert.ToInt32(other_loantextbox.Text);
            gross_income = Convert.ToInt32(gross_incometextbox.Text);

            total_deduction = sss_contrib + philhealth_contrib + pagibig_contrib + incometax_contrib + sss_loan + pagibig_loan + savings_deposit + savings_loan + salary_loan + other_loan;
            net_income = gross_income - total_deduction;

            total_deductiontextbox.Text = total_deduction.ToString("n");
            net_incometextbox.Text = net_income.ToString("n");

        }
    }
}
