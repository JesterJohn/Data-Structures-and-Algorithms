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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Code for changing tje form bachground
        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Code for changing the form background 
            this.BackColor = Color.Red;
            
            //inserting image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Food Bundle A.jpg");

            //codes to check the checkboxes 
            A_CokeCheckBox.Checked = true;
            A_FriedChickenCheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_SideDishCheckBox.Checked = true;
            A_SpecialPizzaCheckBox.Checked = true;

            //codes to uncheck the checkboxes
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HaloHaloCheckBox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            //codes for displaying data inside the textbox 
            priceTextbox.Text = "P 1,000.00";
            DiscountTextbox.Text = "(20% of the price) P 200.00";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //code for changing the form background
            this.BackColor = Color.Red;
         
            //inserting image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Food Bundle B.jpg");

            //codes to check the checkboxes
            B_CarbonaraCheckBox.Checked = true;
            B_ChickenCheckBox.Checked = true;
            B_FriesCheckBox.Checked = true;
            B_HaloHaloCheckBox.Checked = true;
            B_HawaiianCheckbox.Checked = true;

            //codes to uncheck the checkboxes
            A_CokeCheckBox.Checked = false;
            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;

            //codes for displaying data inside the textboxes 
            priceTextbox.Text = "P 1,299.00";
            DiscountTextbox.Text = "(15% of the price0 P194.85";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codes to uncheck all given checkboxes 
            foodARdbtn.Checked = false;
            foodRdbtn.Checked = false;

            //codes for inserting default images inside the picturebox 
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");

            //codes to uncheck all the checkboxes 
            A_CokeCheckBox.Checked = false;
            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_SideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HaloHaloCheckBox.Checked = false;
            B_HawaiianCheckbox.Checked = false;

            //codes for clearing the textboxes 
            priceTextbox.Clear();
            DiscountTextbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void A_FriedChickenCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
