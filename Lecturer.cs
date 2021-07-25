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

namespace CollegeApp
{
    public partial class Lecturer : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=ClinicMaster;Integrated Security =True";

        public Lecturer()
        {
            InitializeComponent();
        }

       
        void clear()
        {
            txtLecturerID.Text = txtLecturerName.Text = txtGender.Text = txtCourseName.Text = txtDepartmentName.Text = txtMobileNumber.Text = " ";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {

            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("AddLecturer", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();
         

            try
            {

                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@LecturerID", txtLecturerID.Text.Trim());
                command.Parameters.AddWithValue("@LecturerName", txtLecturerName.Text.Trim());
                command.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                command.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
                command.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text.Trim());
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
                command.Dispose();
                cnn.Close();
            }
            cnn.Close();


        }

        private void Update_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            
            command = new SqlCommand("UpdateLecturer", cnn);
            command.CommandType = CommandType.StoredProcedure;
            try
            {

                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@LecturerID", txtLecturerID.Text.Trim());
                command.Parameters.AddWithValue("@LecturerName", txtLecturerName.Text.Trim());
                command.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                command.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
                command.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text.Trim());
                command.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text.Trim());

                cnn.Open();

                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("   Lecturer Updated successfully   ");
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
            SqlCommand command;

            command = new SqlCommand("DeleteLecturer", cnn);
            command.CommandType = CommandType.StoredProcedure;
            try
            {


                command.Parameters.AddWithValue("@LecturerID", txtLecturerID.Text.Trim());
                cnn.Open();

                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("   Lecturer Deleted successfully   ");
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

