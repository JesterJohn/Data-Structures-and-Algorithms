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
        using System.Data.SqlClient;
        using System.Data;
    public partial class SampleLongMethod : Form
    {
        String picpath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;

        public SampleLongMethod()
        {
            connectionString = "Data Source = C203-08; Initial Catalog = SampleDataBaseDb; user ID = SA; Password = B1Admin123@";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SampleLongMethod_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            sql = "INSERT INTO Studentbl (Student_ID, Student_Name, Department, Picpath) VALUES ('" + student_notextbox.Text + "', '" + student_nametextbox.Text + "' + '" + departmenttextbox.Text + "' + '" + picpathtextbox.Text + "')";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM Studentbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "Studentbl");

            griddisplay.DataSource = dset.Tables[0];

            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-08\\source\\repos\\JesterJohn\\Data-Structures-and-Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");
            student_notextbox.Clear();
            student_nametextbox.Clear();
            departmenttextbox.Clear();
            picpathtextbox.Clear();

            if (connection.State == ConnectionState.Closed)
                connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Open();

            sql = "SELECT  * FROM Studentbl WHERE Student_ID = '" + student_nametextbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "Studentbl");

            griddisplay.DataSource = dset.Tables[0];

            student_nametextbox.Text = dset.Tables[0].Rows[0][1].ToString();
            departmenttextbox.Text = dset.Tables[0].Rows[0][2].ToString();
            picpathtextbox.Text = dset.Tables[0].Rows[0][3].ToString();  
            pictureBox1.Image = Image.FromFile(picpathtextbox.Text);

            if (connection.State == ConnectionState.Closed)
                connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Open();

            sql = "DELETE FROM Studentbl WHERE Student_ID = '" + student_notextbox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM Studentbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter(command);
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "Studentbl");

            griddisplay.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-08\\source\\repos\\JesterJohn\\Data-Structures-and-Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");

            if (connection.State == ConnectionState.Closed)
                connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Open();

            sql = "UPDATE Studentbl SET Student_Name = '" + student_nametextbox.Text + "', Department = '" + departmenttextbox.Text + "', Picpath = '" + picpathtextbox.Text + "' WHERE Student_ID = '" + student_notextbox.Text + "'";
            command = new SqlCommand(sql, connection);

            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM Studentbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter(command);
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "Studentbl");

            griddisplay.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-08\\source\\repos\\JesterJohn\\Data-Structures-and-Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");

            student_notextbox.Clear();
            student_nametextbox.Clear();
            departmenttextbox.Clear();
            picpathtextbox.Clear();

            if (connection.State == ConnectionState.Closed)
                connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-08\\source\\repos\\JesterJohn\\Data-Structures-and-Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");

            student_notextbox.Clear();
            student_nametextbox.Clear();    
            departmenttextbox.Clear();
            picpathtextbox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-08\\source\\repos\\JesterJohn\\Data-Structures-and-Algorithms\\Data Structures and Algorithms\\Images\\FB\\Default.jpg");

            student_notextbox.Clear();
            student_nametextbox.Clear();
            departmenttextbox.Clear();
            picpathtextbox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp";
            openFileDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            picpathtextbox.Text = openFileDialog.FileName;
        }
    }
}
