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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /*private void loginbutton1_Click(object sender, EventArgs e)
        {
           // this.ActiveControl = textBox2;
           // textBox2.Focus();
           if( textBox2.Text == "Admin" && textBox2.Text == "password")
            {
                Home.HomeInventory home = new Home.HomeInventory();
                home.show();
                this.Close();
            }
            else
            {

                MessageBox.Show("Please Check your username and password");
            }
        }*/
        private void closebutton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }/*
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }*/

        private void button1_Click(object sender, EventArgs e)
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
            while(dataReader.Read())
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
            cnn.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        /* protected override bool ProcessCardKey(ref System.Windows.Forms.Message msg, System.Windows.keys keyData)
try
{
if(msg.WParam.ToInt32()==(Int) keys.Escape)
{


DialogResult result = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
if (result == DialogResult.Yes)
{
close = false;
Application.Exit();

}
}
else
{
return base.ProcessCmdKey(ref msg, keyData!);

catch{MessageBox.Show("Key press error");
*/

    }

}
