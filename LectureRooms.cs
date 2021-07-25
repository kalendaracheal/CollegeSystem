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
   // string connectionString = "Data Source=.;Initial Catalog=ClinicMaster;Integrated Security =True";
    public partial class LectureRooms : Form
    {
        public LectureRooms()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=.;Initial Catalog=ClinicMaster;Integrated Security =True";
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //SqlConnection cnn = new SqlConnection(connectionString);
            //SqlCommand command;
            //cnn.Open();
            //string sql = "Insert into LecturerRooms (LectureRoomName, LectureRoomLevel, LectureRoomDescription) values ('" + txtLectureRoomName.Text + "', '" + txtLectureRoomLevel.Text + "', '" + txtLectureRoomDescription.Text + "')";

        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("AddLectureRoom", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();
          

            try
            {
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@LectureRoomName", txtLectureRoomName.Text.Trim());
                command.Parameters.AddWithValue("@LectureRoomLevel", txtLectureRoomLevel.Text.Trim());
                command.Parameters.AddWithValue("@LectureRoomDescription", txtLectureRoomDescription.Text.Trim());
                

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

            command = new SqlCommand("UpdateLectureRoom", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();


            try
            {
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@LectureRoomName", txtLectureRoomName.Text.Trim());
                command.Parameters.AddWithValue("@LectureRoomLevel", txtLectureRoomLevel.Text.Trim());
                command.Parameters.AddWithValue("@LectureRoomDescription", txtLectureRoomDescription.Text.Trim());


                int a = adapter.InsertCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("  Lecture Room Updated successfully !   ");
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

        private void Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Delete_Click(object sender, EventArgs e)
        {


            string connectionString = "Data Source=.;Initial Catalog=CollegeDB;Integrated Security=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("DeleteLectureRoom", cnn);
            command.CommandType = CommandType.StoredProcedure;
            cnn.Open();


            try
            {
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@LectureRoomName", txtLectureRoomName.Text.Trim());


                int a = adapter.InsertCommand.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("  Lecture Room Deleted successfully !   ");
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
