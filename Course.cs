using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

      
        public void SetCourse(string CourseCode, string CourseName)
        {
            this.CourseCode = CourseCode;
            this.CourseName = CourseName;
        }
        public string GetCourse()
        {
            return CourseName;
        }
        private void Course_Load(object sender, EventArgs e)
        {

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

            command = new SqlCommand("AddCourse", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();


            try
            {
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text.Trim());
                command.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());


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

        private void Close_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Delete_Click(object sender, EventArgs e)
        {


            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("DeleteCourse", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();


            try
            {
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text.Trim());


                int a = adapter.InsertCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("   Course Deleted successfully !   ");
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

            command = new SqlCommand("UpdateCourse", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();


            try
            {
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text.Trim());
                command.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());


                int a = adapter.InsertCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("    Course Updated successfully !   ");
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
