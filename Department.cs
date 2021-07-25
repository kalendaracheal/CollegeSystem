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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("AddDepartment", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();


            try
            {
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text.Trim());
                command.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text.Trim());
                command.Parameters.AddWithValue("@LecturerName", txtLecturerName.Text.Trim());
                command.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text.Trim());


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

            command = new SqlCommand("UpdateDepartments", cnn);
            command.CommandType = CommandType.StoredProcedure;
            try
            {

                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text.Trim());
                command.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text.Trim());
                command.Parameters.AddWithValue("@LecturerName", txtLecturerName.Text.Trim());
                command.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text.Trim());

                cnn.Open();

                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("   Department Updated successfully   ");
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

            command = new SqlCommand("DeleteDepartment", cnn);
            command.CommandType = CommandType.StoredProcedure;
            try
            {

                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text.Trim());
               
                cnn.Open();

                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("   Department Deleted successfully   ");
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
