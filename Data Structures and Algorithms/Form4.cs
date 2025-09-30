using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_and_Algorithms
{
    public partial class Form4 : Form
    {
        private int TotalNoofUnits = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //code for setting the combo box to display all the Engineering courses
            CourseCombobox.Text = "Select Program";
            CourseCombobox.Items.Add("Bachelor or Science in Computer Engineering");
            CourseCombobox.Items.Add("Bachelor or Science in Mechanical Engineering");
            CourseCombobox.Items.Add("Bachelor or Science in Civil Engineering");
            CourseCombobox.Items.Add("Bachelor or Science in Aeronautical Engineering");
            CourseCombobox.Items.Add("Bachelor or Science in Industrial Engineering");
            CourseCombobox.Items.Add("Bachelor or Science in Electrical Engineering");
            CourseCombobox.Items.Add("Bachelor or Science in Electronics Engineering");

            //code for disabling the textboxes
            TotalNoUnitstextbox.Enabled = false;
            TotalNoofUnitsTextbox2.Enabled = false;
            TotalTuitionFeeTextbox.Enabled = false;
            TotalTuitionFeesTextbox2.Enabled = false;
            CreditUnitsTextbox.Enabled = false;
            TotalMiscellanuousFeeTextbox.Enabled = false;
            TotalMiscellanouosFeesTextbox2.Enabled = false;
            TotalTuitionandFeeTextbox.Enabled = false;
            TotalTuitionandFeestextbox2.Enabled = false;
            ComputerLabFeeTextbox2.Enabled = false;
            CISCOLabFeeTextbox2.Enabled = false;
            ExamBookletTextbox2.Enabled = false;
            TotalOtherschoolFeesTextbox.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //code for browse button for image 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //codes for new / cancel button to clear all the textboxes
            StudentNameTextbox.Clear();
            StudentNoTextbox.Clear();
            YearLevelTextbox.Clear();
            ScholarTextbox.Clear();

            CourseNoTextbox.Clear();
            CourseCodeTextbox.Clear();
            CourseDescTextbox.Clear();
            UnitLectureTextbox.Clear();
            UnitLabTextbox.Clear();
            TimeTextbox.Clear();
            DayTextbox.Clear();

            CreditUnitsTextbox.Clear();
            TotalNoUnitstextbox.Clear();
            LabFeesTextbox.Clear();
            TotalTuitionFeeTextbox.Clear();
            TotalMiscellanuousFeeTextbox.Clear();
            CiscoLabFeeTextbox.Clear();
            ExamBookletFeeTextbox.Clear();
            TotalTuitionandFeeTextbox.Clear();

            TotalTuitionFeesTextbox2.Clear();
            TotalMiscellanouosFeesTextbox2.Clear();
            TotalNoofUnitsTextbox2.Clear();
            TotalTuitionandFeestextbox2.Clear();
            ComputerLabFeeTextbox2.Clear();
            CISCOLabFeeTextbox2.Clear();
            ExamBookletTextbox2.Clear();


        }
        private void button2_Click(object sender, EventArgs e)
        {
           

            //code to calculate the credit units 
            int unitlec, unitlab, creditUnits;
            unitlec = Convert.ToInt32(UnitLectureTextbox.Text);
            unitlab = Convert.ToInt32(UnitLabTextbox.Text);
            creditUnits = (unitlec + unitlab);
            TotalNoofUnits += creditUnits;
            TotalNoUnitstextbox.Text = TotalNoofUnits.ToString();
            TotalNoofUnitsTextbox2.Text = TotalNoofUnits.ToString();
            CreditUnitsTextbox.Text = creditUnits.ToString();

            string courseNumber = CourseNoTextbox.Text;
            string courseCode = CourseCodeTextbox.Text; 
            string courseDescription = CourseDescTextbox.Text;
            string unitLecture = UnitLectureTextbox.Text;
            string unitLab = UnitLabTextbox.Text;
            string creditUnit = CreditUnitsTextbox.Text;
            string time = TimeTextbox.Text;
            string day = DayTextbox.Text;

            //Codes for submit button to add all the data in the listboxes 
            NoListbox.Items.Add(CourseNoTextbox.Text);
            CourseCodeListbox.Items.Add(CourseCodeTextbox.Text);
            CourseDescListbox.Items.Add(CourseDescTextbox.Text);
            UnitLecListbox.Items.Add(UnitLectureTextbox.Text);
            UnitLabListbox.Items.Add(UnitLabTextbox.Text);
            CreditUnitsListbox.Items.Add(CreditUnitsTextbox.Text);
            TimeListbox.Items.Add(TimeTextbox.Text);
            DayListbox.Items.Add(DayTextbox.Text);

            TotalTuitionFeesTextbox2.Text = TotalTuitionFeeTextbox.Text;
            TotalMiscellanouosFeesTextbox2.Text = TotalMiscellanuousFeeTextbox.Text;
            TotalNoofUnitsTextbox2.Text = TotalNoUnitstextbox.Text;
            TotalTuitionandFeestextbox2.Text = TotalTuitionandFeeTextbox.Text;
            ComputerLabFeeTextbox2.Text = LabFeesTextbox.Text;
            CISCOLabFeeTextbox2.Text = CiscoLabFeeTextbox.Text;
            ExamBookletTextbox2.Text = ExamBookletFeeTextbox.Text;

            


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double totalTuitionFee, totalMiscellaneousFee, totalTuitionAndFee, ciscFee, exmbkltFee, labFee;

            labFee = Convert.ToDouble(LabFeesTextbox.Text);
            ciscFee = Convert.ToDouble(CiscoLabFeeTextbox.Text);
            exmbkltFee = Convert.ToDouble(ExamBookletFeeTextbox.Text);

            totalTuitionFee = TotalNoofUnits * 1700;
            totalMiscellaneousFee = labFee + ciscFee + exmbkltFee;
            totalTuitionAndFee = totalTuitionFee + totalMiscellaneousFee;


            TotalTuitionFeeTextbox.Text = totalTuitionFee.ToString("n");
            TotalMiscellanuousFeeTextbox.Text = totalMiscellaneousFee.ToString("n");
            TotalTuitionandFeeTextbox.Text = totalTuitionAndFee.ToString("n");
            LabFeesTextbox.Text = labFee.ToString("n");
            CiscoLabFeeTextbox.Text = ciscFee.ToString("n");
            ExamBookletFeeTextbox.Text = exmbkltFee.ToString("n");

            TotalTuitionandFeestextbox2.Text = TotalTuitionandFeeTextbox.Text;
            TotalMiscellanouosFeesTextbox2.Text = TotalMiscellanuousFeeTextbox.Text;
            TotalTuitionFeesTextbox2.Text = TotalTuitionFeeTextbox.Text;
            LabFeesTextbox.Text = ComputerLabFeeTextbox2.Text; 
            CISCOLabFeeTextbox2.Text = CiscoLabFeeTextbox.Text;
            ExamBookletTextbox2.Text = ExamBookletFeeTextbox.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 print = new Form5();
            print.DisplayNoListbox.Items.AddRange(this.NoListbox.Items);
            print.DisplayCourseCodeListbox.Items.AddRange(this.CourseCodeListbox.Items);
            print.DisplayCourseDescListbox.Items.AddRange(this.CourseDescListbox.Items);
            print.DisplayUnitLecListbox.Items.AddRange(this.UnitLecListbox.Items);
            print.DisplayUnitLabListbox.Items.AddRange(this.UnitLabListbox.Items);
            print.DisplayCreditUnitsListbox.Items.AddRange(this.CreditUnitsListbox.Items);
            print.DisplayTimeListbox.Items.AddRange(this.TimeListbox.Items);
            print.DisplayDayListbox.Items.AddRange(this.DayListbox.Items);

            print.DisplayCourseNoTextbox.Text = CourseNoTextbox.Text;
            print.DisplayCourseCodeTextbox.Text = CourseCodeTextbox.Text;
            print.DisplayCourseDescTextbox.Text = CourseDescTextbox.Text;
            print.DisplayUnitLectureTextbox.Text = UnitLectureTextbox.Text;
            print.DisplayUnitLabTextbox.Text = UnitLabTextbox.Text;
            print.DisplayTimeTextbox.Text = TimeTextbox.Text;
            print.DisplayDayTextbox.Text = DayTextbox.Text;
            print.DisplayCreditUnitsTextbox.Text = CreditUnitsTextbox.Text;
            print.DisplayTotalNoUnitstextbox.Text = TotalNoUnitstextbox.Text;
            print.DisplayLabFeesTextbox.Text = LabFeesTextbox.Text;
            print.DisplayTotalTuitionFeeTextbox.Text = TotalTuitionFeeTextbox.Text; 
            print.DisplayTotalMiscellanuousFeeTextbox.Text = TotalMiscellanuousFeeTextbox.Text;
            print.DisplayCiscoLabFeeTextbox.Text = CiscoLabFeeTextbox.Text;
            print.DisplayExamBookletFeeTextbox.Text = ExamBookletFeeTextbox.Text;
            print.DisplayTotalTuitionandFeeTextbox.Text = TotalTuitionandFeeTextbox.Text;




            print.Show();

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void CreditUnitsTextbox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void TotalNoofUnitsTextbox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TotalTuitionandFeeTextbox_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void TotalMiscellanuousFeeTextbox_TextChanged(object sender, EventArgs e)
        {
          

        }

        
    }
}
