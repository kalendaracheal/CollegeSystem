using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Student());
            // Application.Run(new Lecturer());
            //Application.Run(new Department());
            //Application.Run(new LectureRooms());
            Application.Run(new Course());
            Student st = new Student();
            Lecturer l = new Lecturer();
        }
    }
}

