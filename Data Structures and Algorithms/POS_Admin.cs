using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_and_Algorithms
{
    public partial class POS_Admin : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;
        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                picpathtextbox1.Hide();
                picpathtextbox2.Hide();
                picpathtextbox3.Hide();
                picpathtextbox4.Hide();
                picpathtextbox5.Hide();
                picpathtextbox6.Hide();
                picpathtextbox7.Hide();
                picpathtextbox8.Hide();
                picpathtextbox9.Hide();
                picpathtextbox10.Hide();
                picpathtextbox11.Hide();
                picpathtextbox12.Hide();
                picpathtextbox13.Hide();
                picpathtextbox14.Hide();
                picpathtextbox15.Hide();
                picpathtextbox16.Hide();
                picpathtextbox17.Hide();
                picpathtextbox18.Hide();
                picpathtextbox19.Hide();
                picpathtextbox20.Hide();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSelect();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch(Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
        public void cleartextboxes()
        { 
            try
            {
                pic = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\default.jpg");
                picpathtextbox1.Clear();
                picpathtextbox2.Clear();
                picpathtextbox3.Clear();
                picpathtextbox4.Clear();
                picpathtextbox5.Clear();
                picpathtextbox6.Clear();
                picpathtextbox7.Clear();
                picpathtextbox8.Clear();
                picpathtextbox9.Clear();
                picpathtextbox10.Clear();
                picpathtextbox11.Clear();
                picpathtextbox12.Clear();
                picpathtextbox13.Clear();
                picpathtextbox14.Clear();
                picpathtextbox15.Clear();
                picpathtextbox16.Clear();
                picpathtextbox17.Clear();
                picpathtextbox18.Clear();
                picpathtextbox19.Clear();
                picpathtextbox20.Clear();

                pictureBox1.Image = pic;
                pictureBox2.Image = pic;
                pictureBox3.Image = pic;
                pictureBox4.Image = pic;
                pictureBox5.Image = pic;
                pictureBox6.Image = pic;
                pictureBox7.Image = pic;
                pictureBox8.Image = pic;
                pictureBox9.Image = pic;
                pictureBox10.Image = pic;
                pictureBox11.Image = pic;
                pictureBox12.Image = pic;
                pictureBox13.Image = pic;
                pictureBox14.Image = pic;
                pictureBox15.Image = pic;
                pictureBox16.Image = pic;
                pictureBox17.Image = pic;
                pictureBox18.Image = pic;
                pictureBox19.Image = pic;
                pictureBox20.Image = pic;

                pricetextbox1.Clear();
                pricetextbox2.Clear();
                pricetextbox3.Clear();
                pricetextbox4.Clear();
                pricetextbox5.Clear();
                pricetextbox6.Clear();
                pricetextbox7.Clear();
                pricetextbox8.Clear();
                pricetextbox9.Clear();
                pricetextbox10.Clear();
                pricetextbox11.Clear();
                pricetextbox12.Clear();
                pricetextbox13.Clear();
                pricetextbox14.Clear();
                pricetextbox15.Clear();
                pricetextbox16.Clear();
                pricetextbox17.Clear();
                pricetextbox18.Clear();
                pricetextbox19.Clear();
                pricetextbox20.Clear();

                nametextbox1.Clear();
                nametextbox2.Clear();
                nametextbox3.Clear();
                nametextbox4.Clear();
                nametextbox5.Clear();
                nametextbox6.Clear();
                nametextbox7.Clear();
                nametextbox8.Clear();
                nametextbox9.Clear();
                nametextbox10.Clear();
                nametextbox11.Clear();
                nametextbox12.Clear();
                nametextbox13.Clear();
                nametextbox14.Clear();
                nametextbox15.Clear();
                nametextbox16.Clear();
                nametextbox17.Clear();
                nametextbox18.Clear();
                nametextbox19.Clear();
                nametextbox20.Clear();

            }
            catch(Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
           
        }
        private void open_file_image()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.ShowDialog();
        }
    }
}
