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
    using System.Data.SqlClient;
    using System.Data;
    public partial class SampleFunctions : Form
    {
        String picpath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
        public SampleFunctions()
        {
            connectionString = "Data Source = LAPTOP-9QMQALA3\\SQLEXPRESS ; Initial Catalog = SampleDataBaseDb; Integrated Security = True ";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }
        private void clrtextboxes()
        {
            picpathtextbox.Clear();
            student_nametextbox.Clear();
            student_notextbox.Clear();
            departmenttextbox.Clear();
        }
        private void cmd()
        {
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
        }
        private void sqlSelect()
        { 
            sql = "SELECT * FROM StudentTbl";
        }
        private void sqladapterSelect()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqladapterDelete()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqladapterUpdate()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqladapterInsert()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();
        }
        private void sqldataset()
        {
            dset = new DataSet();
            adaptersql.Fill(dset, "StudentTbl");
            griddisplay.DataSource = dset.Tables[0];
        }
        private void SampleFunctions_Load(object sender, EventArgs e)
        {
            picpathtextbox.Hide();
            connection.Open();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();

            connection.Close();
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
            connection.Open();

            sql = "INSERT INTO StudentTbl (Student_ID, Student_Name, Department, Picpath) VALUES ('" + student_notextbox.Text + "', '" + student_nametextbox.Text + "', '" + departmenttextbox.Text + "', '" + picpathtextbox.Text + "')";
            cmd();
            sqladapterInsert();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();

            connection.Close();

            clrtextboxes();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT  * FROM StudentTbl WHERE Student_ID = ' " + student_notextbox.Text + " ' ";
            cmd();
            sqladapterSelect();
            sqldataset();

            student_nametextbox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmenttextbox.Text = dset.Tables[0].Rows[0][2].ToString();
            picpathtextbox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picpathtextbox.Text);
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "DELETE FROM StudentTbl WHERE Student_ID = '" + student_notextbox.Text + "'";
            cmd();
            sqladapterDelete();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();
            connection.Close();
            clrtextboxes();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE StudentTbl SET Student_Name = '" + student_nametextbox.Text + "', Department = '" + departmenttextbox.Text + "', Picpath = '" + picpathtextbox.Text + "' WHERE Student_ID = '" + student_notextbox.Text + "'";
            cmd();
            sqladapterUpdate();
            sqlSelect();
            cmd();
            sqladapterSelect();
            sqldataset();
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clrtextboxes();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Jester\\source\\repos\\Data Structures and Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");
        }
    }
}
