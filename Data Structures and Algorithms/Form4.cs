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
    public partial class Form4 : Form
    {
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
            TotalMiscellanouosFeesTextbox2.Clear();
            TotalTuitionandFeestextbox2.Clear();
            ComputerLabFeeTextbox2.Clear();
            CISCOLabFeeTextbox2.Clear();
            ExamBookletTextbox2.Clear();



        }
        private void button2_Click(object sender, EventArgs e)
        {
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

        
    }
}
