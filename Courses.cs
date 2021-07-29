using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Courses
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

        public Courses()
        {

        }
        public void SetCourse(string CourseCode, string CourseName)
        {
            this.CourseCode = CourseCode;
            this.CourseName = CourseName;
        }
        public string GetCourse()
        {
            return CourseName;
        }
    }
}
