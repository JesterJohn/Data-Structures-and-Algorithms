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
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            
        }
        public void cleartextboxes()
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
        private void open_file_image()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

                posdb_connect.pos_sql =
                    "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) " +
                    "VALUES ('" + pos_id_combobox.Text + "', '" + nametextbox1.Text + "', '" + nametextbox2.Text + "', '" + nametextbox3.Text + "', '" + nametextbox4.Text + "', '" + nametextbox5.Text + "', '" + nametextbox6.Text + "', '" + nametextbox7.Text + "', '" + nametextbox8.Text + "', '" + nametextbox9.Text + "', '" + nametextbox10.Text + "', '" + nametextbox11.Text + "', '" + nametextbox12.Text + "', '" + nametextbox13.Text + "', '" + nametextbox14.Text + "', '" + nametextbox15.Text + "', '" + nametextbox16.Text + "', '" + nametextbox17.Text + "', '" + nametextbox18.Text + "', '" + nametextbox19.Text + "', '" + nametextbox20.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

            posdb_connect.pos_sql =
                  "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) " +
                  "VALUES ('" + pricetextbox1.Text + "', '" + pricetextbox2.Text + "', '" + pricetextbox3.Text + "', '" + pricetextbox4.Text + "', '" + pricetextbox5.Text + "', '" + pricetextbox6.Text + "', '" + pricetextbox7.Text + "', '" + pricetextbox8.Text + "', '" + pricetextbox9.Text + "', '" + pricetextbox10.Text + "', '" + pricetextbox11.Text + "', '" + pricetextbox12.Text + "', '" + pricetextbox13.Text + "', '" + pricetextbox14.Text + "', '" + pricetextbox15.Text + "', '" + pricetextbox16.Text + "', '" + pricetextbox17.Text + "', '" + pricetextbox18.Text + "', '" + pricetextbox19.Text + "', '" + pricetextbox20.Text + "', '" + pos_id_combobox.Text + "')";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterInsert();

            posdb_connect.pos_sql =
                    "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) " +
                    "VALUES ('" + picpathtextbox1.Text + "', '" + picpathtextbox2.Text + "', '" + picpathtextbox3.Text + "', '" + picpathtextbox4.Text + "', '" + picpathtextbox5.Text + "', '" + picpathtextbox6.Text + "', '" + picpathtextbox7.Text + "', '" + picpathtextbox8.Text + "', '" + picpathtextbox9.Text + "', '" + picpathtextbox10.Text + "', '" + picpathtextbox11.Text + "', '" + picpathtextbox12.Text + "', '" + picpathtextbox13.Text + "', '" + picpathtextbox14.Text + "', '" + picpathtextbox15.Text + "', '" + picpathtextbox16.Text + "', '" + picpathtextbox17.Text + "', '" + picpathtextbox18.Text + "', '" + picpathtextbox19.Text + "', '" + picpathtextbox20.Text + "', '" + pos_id_combobox.Text + "')";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterInsert();

            posdb_connect.pos_select();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();
            datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            cleartextboxes();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            posdb_connect.pos_sql =
            "SELECT * FROM pos_nameTbl " +
            "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
            "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
            "WHERE pos_nameTbl.pos_id = '" + pos_id_combobox.Text + "'";

            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sqldatasetSELECT();
            datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                nametextbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                nametextbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                nametextbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                nametextbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                nametextbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                nametextbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                nametextbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                nametextbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                nametextbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                nametextbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                nametextbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                nametextbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();    
                nametextbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                nametextbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                nametextbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                nametextbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                nametextbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                nametextbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                nametextbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                nametextbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            picpathtextbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image = Image.FromFile(picpathtextbox1.Text);
            picpathtextbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image = Image.FromFile(picpathtextbox2.Text);
            picpathtextbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image = Image.FromFile(picpathtextbox3.Text);
            picpathtextbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.Image = Image.FromFile(picpathtextbox4.Text);
            picpathtextbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image = Image.FromFile(picpathtextbox5.Text);
            picpathtextbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image = Image.FromFile(picpathtextbox6.Text);
            picpathtextbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image = Image.FromFile(picpathtextbox7.Text);
            picpathtextbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image = Image.FromFile(picpathtextbox8.Text);
            picpathtextbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image = Image.FromFile(picpathtextbox9.Text);
            picpathtextbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image = Image.FromFile(picpathtextbox10.Text);
            picpathtextbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image = Image.FromFile(picpathtextbox11.Text);
            picpathtextbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image = Image.FromFile(picpathtextbox12.Text);
            picpathtextbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image = Image.FromFile(picpathtextbox13.Text);
            picpathtextbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image = Image.FromFile(picpathtextbox14.Text);
            picpathtextbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image = Image.FromFile(picpathtextbox15.Text);
            picpathtextbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image = Image.FromFile(picpathtextbox16.Text);
            picpathtextbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image = Image.FromFile(picpathtextbox17.Text);
            picpathtextbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image = Image.FromFile(picpathtextbox18.Text);
            picpathtextbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image = Image.FromFile(picpathtextbox19.Text);
            picpathtextbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image = Image.FromFile(picpathtextbox20.Text);



                pricetextbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                pricetextbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                pricetextbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                pricetextbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                pricetextbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                pricetextbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                pricetextbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                pricetextbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                pricetextbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                pricetextbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                pricetextbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                pricetextbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                pricetextbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                pricetextbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                pricetextbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                pricetextbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                pricetextbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                pricetextbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                pricetextbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                pricetextbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                posdb_connect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + nametextbox1.Text + "', name2 = '" + nametextbox2.Text + "', name3 = '" + nametextbox3.Text + "', name4 = '" + nametextbox4.Text + "', name5 = '" + nametextbox5.Text + "', name6 = '" + nametextbox6.Text + "', name7 = '" + nametextbox7.Text + "', name8 = '" + nametextbox8.Text + "', name9 = '" + nametextbox9.Text + "', name10 = '" + nametextbox10.Text + "', name11 = '" + nametextbox11.Text + "', name12 = '" + nametextbox12.Text + "', name13 = '" + nametextbox13.Text + "', name14 = '" + nametextbox14.Text + "', name15 = '" + nametextbox15.Text + "', name16 = '" + nametextbox16.Text + "', name17 = '" + nametextbox17.Text + "', name18 = '" + nametextbox18.Text + "', name19 = '" + nametextbox19.Text + "', name20 = '" + nametextbox20.Text + "' WHERE pos_id = '" + pos_id_combobox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_picTbl SET pic1 = '" + picpathtextbox1.Text + "', pic2 = '" + picpathtextbox2.Text + "', pic3 = '" + picpathtextbox3.Text + "', pic4 = '" + picpathtextbox4.Text + "', pic5 = '" + picpathtextbox5.Text + "', pic6 = '" + picpathtextbox6.Text + "', pic7 = '" + picpathtextbox7.Text + "', pic8 = '" + picpathtextbox8.Text + "', pic9 = '" + picpathtextbox9.Text + "', pic10 = '" + picpathtextbox10.Text + "', pic11 = '" + picpathtextbox11.Text + "', pic12 = '" + picpathtextbox12.Text + "', pic13 = '" + picpathtextbox13.Text + "', pic14 = '" + picpathtextbox14.Text + "', pic15 = '" + picpathtextbox15.Text + "', pic16 = '" + picpathtextbox16.Text + "', pic17 = '" + picpathtextbox17.Text + "', pic18 = '" + picpathtextbox18.Text + "', pic19 = '" + picpathtextbox19.Text + "', pic20 = '" + picpathtextbox20.Text + "' WHERE pos_id = '" + pos_id_combobox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + pricetextbox1.Text + "', price2 = '" + pricetextbox2.Text + "', price3 = '" + pricetextbox3.Text + "', price4 = '" + pricetextbox4.Text + "', price5 = '" + pricetextbox5.Text + "', price6 = '" + pricetextbox6.Text + "', price7 = '" + pricetextbox7.Text + "', price8 = '" + pricetextbox8.Text + "', price9 = '" + pricetextbox9.Text + "', price10 = '" + pricetextbox10.Text + "', price11 = '" + pricetextbox11.Text + "', price12 = '" + pricetextbox12.Text + "', price13 = '" + pricetextbox13.Text + "', price14 = '" + pricetextbox14.Text + "', price15 = '" + pricetextbox15.Text + "', price16 = '" + pricetextbox16.Text + "', price17 = '" + pricetextbox17.Text + "', price18 = '" + pricetextbox18.Text + "', price19 = '" + pricetextbox19.Text + "', price20 = '" + pricetextbox20.Text + "' WHERE pos_id = '" + pos_id_combobox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();

        }

        private void button4_Click(object sender, EventArgs e)
        {

                posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id = ' " + pos_id_combobox.Text + " ' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id = ' " + pos_id_combobox.Text + " ' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id = ' " + pos_id_combobox.Text + " ' ";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                datagriddisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox1.Text = picpath;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox2.Text = picpath;
        }
    

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox3.Text = picpath;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox4.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox4.Text = picpath;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox5.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox5.Text = picpath;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox6.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox6.Text = picpath;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox7.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox7.Text = picpath;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox8.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox8.Text = picpath;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox9.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox9.Text = picpath;

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox10.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox10.Text = picpath;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox11.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox11.Text = picpath;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox12.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox12.Text = picpath;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox13.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox13.Text = picpath;

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox14.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox14.Text = picpath;

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox15.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox15.Text = picpath;

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox16.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox16.Text = picpath;

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox17.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox17.Text = picpath;

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox18.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox18.Text = picpath;

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox19.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox19.Text = picpath;

        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp;";
            openFileDialog.ShowDialog();

            pictureBox20.Image = Image.FromFile(openFileDialog.FileName);
            picpath = openFileDialog.FileName;
            picpathtextbox20.Text = picpath;

        }
    }
}
