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

        string connectionString = "Data Source=.;Initial Catalog=ClinicMaster;Integrated Security =True";
        public Student()
        {
            InitializeComponent();

        }



        //         protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Escape)
        //    {
        //        Close();
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}




        private void Register_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;


           command = new SqlCommand("addStudent", cnn);
            command.CommandType = CommandType.StoredProcedure;


           // command.CommandText = "addStudent";
            //adapter.InsertCommand = command;

            cnn.Open();
            //string sql = "Insert into Students (StudentNumber, RegNo, FirstName, LastName, Gender, DateOfBirth, CourseName, YearOfStudy, MobileNumber) values ('" + txtStudentNumber.Text + "', '" + txtRegNo.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtGender.Text + "', '" + txtDateOfBirth.Text + "', '" + txtCourseName.Text + "', '" + txtYearOfStudy.Text + "', '" + txtMobileNumber.Text + "')";SqlCommand cmd = new SqlCommand("dbo.test", cnn);



            try
            {
               
                adapter.InsertCommand = command;

                command.Parameters.AddWithValue("@StudentNumber", txtStudentNumber.Text.Trim());
                command.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                command.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                command.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text.Trim());
                command.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
                command.Parameters.AddWithValue("@YearOfStudy", txtYearOfStudy.Text.Trim());
                command.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text.Trim());


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
               // command.Dispose();
                cnn.Close();
            }
            cnn.Close();


        }
      
        public bool verify()
{
    if ((txtStudentNumber.Text.Trim() == "") ||
       (txtRegNo.Text.Trim() == "") ||
       (txtFirstName.Text.Trim() == "") ||
        (txtLastName.Text.Trim() == "") ||
        (txtGender.Text.Trim() == "") ||
       (txtDateOfBirth.Text.Trim() == "") ||
        (txtCourseName.Text.Trim() == "") ||
        (txtYearOfStudy.Text.Trim() == "") ||
        (txtMobileNumber.Text.Trim() == ""))
    {
        return false;
    }
    else
    {
        return true;
    }
}

private void Student_Load(object sender, EventArgs e)
{
    //MessageBox.Show("Student system");
}

private void Close_Click(object sender, EventArgs e)
{
    // this.Close();
    System.Windows.Forms.Application.ExitThread();
}

private void Update_Click(object sender, EventArgs e)
{
    string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
    SqlConnection cnn = new SqlConnection(connectionString);
    SqlCommand command;
    //string sql = "UPDATE Students SET StudentNumber = '" + txtStudentNumber.Text + "', RegNo = '" + txtRegNo.Text + "', FirstName =  '" + txtFirstName.Text + "', LastName =  '" + txtLastName.Text + "', Gender =  '" + txtGender.Text + "', DateOfBirth =  '" + txtDateOfBirth.Text + "', CourseName = '" + txtCourseName.Text + "', YearOfStudy = '" + txtYearOfStudy.Text + "', MobileNumber = '" + txtMobileNumber.Text + "' WHERE StudentNumber = '" + txtStudentNumber.Text + "';";

    command = new SqlCommand("UpdateStudent", cnn);
    command.CommandType = CommandType.StoredProcedure;
    try
    {


        command.Parameters.AddWithValue("@StudentNumber", txtStudentNumber.Text.Trim());
        command.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
        command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
        command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
        command.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
        command.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text.Trim());
        command.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
        command.Parameters.AddWithValue("@YearOfStudy", txtYearOfStudy.Text.Trim());
        command.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text.Trim());

        cnn.Open();

        int a = command.ExecuteNonQuery();
        if (a > 0)
        {
            MessageBox.Show("   Student Updated successfully   ");
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {


        cnn.Close();
    }
}

private void Delete_Click(object sender, EventArgs e)
{


    string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
    SqlConnection cnn = new SqlConnection(connectionString);
    SqlDataAdapter adapter = new SqlDataAdapter();
    SqlCommand command;
            //string sql = "DELETE FROM Students  WHERE StudentNumber = '" + txtStudentNumber.Text + "' ; "; ;

            command = new SqlCommand("DeleteStudent", cnn);
    command.CommandType = CommandType.StoredProcedure;

    try
    {

                adapter.InsertCommand = command;

        command.Parameters.AddWithValue("@StudentNumber", txtStudentNumber.Text.Trim());
        cnn.Open();

        int a = command.ExecuteNonQuery();
        if (a > 0)
        {
            MessageBox.Show("Student Deleted successfully");
        }

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {


        cnn.Close();
    }
}
    }
}

