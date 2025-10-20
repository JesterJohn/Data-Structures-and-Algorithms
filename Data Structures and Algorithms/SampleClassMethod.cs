using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Structures_and_Algorithms
{

    public partial class SampleClassMethod : Form
    {
        string picpath;
        db_connection db_connect = new db_connection();

        public SampleClassMethod()
        {
            db_connect.connString();
            InitializeComponent();
        }
        private void cleartextboxes()
        {
            picpathtextbox.Clear();
            student_notextbox.Clear();
            student_nametextbox.Clear();
            departmenttextbox.Clear();

            student_notextbox.Focus();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");
        }

        private void SampleClassMethod_Load(object sender, EventArgs e)
        {
            picpathtextbox.Hide();
            db_connect.sql = "SELECT * FROM StudentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSelect();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            picpathtextbox.Text = openFileDialog.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_connect.sql = "INSERT INTO StudentTbl (Student_ID, Student_Name, Department, Picpath) VALUES ('" + student_notextbox.Text + "', '" + student_nametextbox.Text + "', '" + departmenttextbox.Text + "', '" + picpathtextbox.Text + "')";
            db_connect.cmd();
            db_connect.sqladapterInsert();
            db_connect.sql = "SELECT * FROM StudentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSelect();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db_connect.sql = "SELECT * FROM StudentTbl WHERE Student_ID = '" + student_notextbox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSelect();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            student_nametextbox.Text = db_connect.sql_dataset.Tables[0].Rows[0][1].ToString();
            departmenttextbox.Text = db_connect.sql_dataset.Tables[0].Rows[0][2].ToString();
            picpathtextbox.Text = db_connect.sql_dataset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picpathtextbox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db_connect.sql = "DELETE FROM StudentTbl WHERE Student_ID = '" + student_notextbox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterDelete();
            db_connect.sql = "SELECT * FROM StudentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSelect();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            db_connect.sql = "UPDATE StudentTbl SET " +
                     "Student_Name = '" + student_nametextbox.Text + "', " +
                     "Department = '" + departmenttextbox.Text + "', " +
                     "Picpath = '" + picpathtextbox.Text + "' " +
                     "WHERE Student_ID = '" + student_notextbox.Text + "'";
            db_connect.cmd();
            db_connect.sqladapterUpdate();
            db_connect.sqladapterUpdate();
            db_connect.sql = "SELECT * FROM StudentTbl";
            db_connect.cmd();
            db_connect.sqladapterSelect();
            db_connect.sqldatasetSelect();
            griddisplay.DataSource = db_connect.sql_dataset.Tables[0];
            cleartextboxes(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }
    }
}
