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
        public Lecturer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtLecturerID.Text);
            using (SqlConnection sqlCon = new SqlConnection())
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("addStudent", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@LecturerID", txtLecturerID.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@LecturerName", txtLecturerName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Gender", txtGender.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Regestration is successful.");
                clear();
            }
        }
        void clear()
        {
            txtLecturerID.Text = txtLecturerName.Text = txtGender.Text = txtCourseName.Text = txtDepartmentName.Text = txtMobileNumber.Text = " ";
        }

    }
}

