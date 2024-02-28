using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.AllClasses
{
    public class StudentCourseAttandance
    {
        public string CourseName { get; set; }
        public int NumberOfLecture { get; set; }
        public int NumberOfAttendendLec { get; set; }
        public int NumberOfAbsentedLec { get; set; }

        public override string ToString()
        {
            return $"{CourseName}:{NumberOfLecture}:{NumberOfAttendendLec}:{NumberOfAbsentedLec}";
        }


    }
}
