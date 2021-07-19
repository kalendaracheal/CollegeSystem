using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeApp
{
    public partial class Student : Form
    {

        string connectionString = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CollegeDB;Data Source=DESKTOP-ANOUTM1";
        public Student()
        {
            InitializeComponent();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtStudentNumber.Text);

            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("addStudent", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@StudentNumber", txtStudentNumber.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@YearOfStudy", txtYearOfStudy.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text.Trim()); 
                 sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Regestration is successful.");
                clear();
            }
            void clear()
             {
                txtStudentNumber.Text = txtRegNo.Text = txtFirstName.Text = txtLastName.Text = txtGender.Text = txtDateOfBirth.Text = txtCourseName.Text = txtYearOfStudy.Text = txtMobileNumber.Text = " ";
             }
        }


        private void Button2_Click(object sender, EventArgs e)
        { 
        
        }
                 protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        
        

        private void Register_Click(object sender, EventArgs e)
        {

            string connectionString;
            SqlConnection cnn;
            connectionString = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CollegeDB;Data Source=DESKTOP-ANOUTM1";
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql, Output = "";
            sql = "Select StudentNumber, RegNo, FirstName, LastName, Gender, DateOfBirth, CourseName, YearOfStudy, MobileNumber from Students";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " -" + dataReader.GetValue(1) + "\n";
            }


            sql = "Insert into Students (StudentNumber, RegNo, FirstName, LastName, Gender, DateOfBirth, CourseName, YearOfStudy, MobileNumber) values ('1900716514', '19/U/16514/PS', 'Jolly', 'Petra', '2004-07-13', 'Software Engineering', 2, '0712001214') ";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
            MessageBox.Show(Output);
            MessageBox.Show("Connection Open !");

            MessageBox.Show("Data inserted");
            cnn.Close();

        }

        private void Student_Load(object sender, EventArgs e)
        {
            MessageBox.Show("It should work now");
        }
    }
}

