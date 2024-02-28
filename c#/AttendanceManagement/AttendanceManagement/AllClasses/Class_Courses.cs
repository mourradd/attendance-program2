using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.AllClasses
{
    public class Class_Courses
    {
        public int ClassId { get; set; }
        public List<Class_Course> Courses { get; set; } = new List<Class_Course>();

        public override string ToString()
        {
            string res = "";
            foreach (var course in Courses) {
            foreach (var courseValue in AttendanceManagement.AllClasses.StudentsListGenerators.Courses) {
                if(course.CourseId==courseValue.ID) { res += courseValue.Name; }
                }
            }
            return res ;
        }

    }
}
