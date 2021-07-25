using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeApp
{
    class College
    {
        
        public string txtStudentNumber { get; set; }
        public string txtRegNo { get; set; }
        public string txtFirstName { get; set; }
        public string txtLastName { get; set; }
        public string txtGender { get; set; }
        public string txtDateOfBirth { get; set; }
        public string txtCourseName { get; set; }
        public int txtYearOfStudy { get; set; }
        public string txtMobileNumber { get; set; }
        //constuctor without arguments
        public College()
        {
        }
        //constuctor with arguments
        public College(string StudentNumber, string RegNo, string FirstName, string LastName, string Gender, string DateOfBirth, string CourseName, int YearOfStudy, string MobileNumber)
        {
            this.txtStudentNumber = StudentNumber;
            this.txtRegNo = RegNo;
            this.txtFirstName = FirstName;
            this.txtLastName = LastName;
            this.txtGender = Gender;
            this.txtDateOfBirth = DateOfBirth;
            this.txtCourseName = CourseName;
            this.txtYearOfStudy = YearOfStudy;
            this.txtMobileNumber = MobileNumber;
        }


        public void addStudent(Object Sender, EventArgs e)
        {

            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;


            command = new SqlCommand("addStudent", cnn);
            command.CommandType = CommandType.StoredProcedure;


            command.CommandText = "addStudent";
            adapter.InsertCommand = command;

            cnn.Open();
            // string sql = "Insert into Students (StudentNumber, RegNo, FirstName, LastName, Gender, DateOfBirth, CourseName, YearOfStudy, MobileNumber) values ('" + txtStudentNumber.Text + "', '" + txtRegNo.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtGender.Text + "', '" + txtDateOfBirth.Text + "', '" + txtCourseName.Text + "', '" + txtYearOfStudy.Text + "', '" + txtMobileNumber.Text + "')";SqlCommand cmd = new SqlCommand("dbo.test", conn);



            try
            {


                command.Parameters.AddWithValue("@StudentNumber", txtStudentNumber.Trim());
                command.Parameters.AddWithValue("@RegNo", txtRegNo.Trim());
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Trim());
                command.Parameters.AddWithValue("@LastName", txtLastName.Trim());
                command.Parameters.AddWithValue("@Gender", txtGender);
                command.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth);
                command.Parameters.AddWithValue("@CourseName", txtCourseName.Trim());
                command.Parameters.AddWithValue("@YearOfStudy", txtYearOfStudy);
                command.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Trim());


                int a = adapter.InsertCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("    Registration successful !   ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                cnn.Close();
            }
            cnn.Close();
        }
    }


}