using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.AllClasses
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfJoining { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string ClassID { get; set; }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{DateOfJoining}:{Email}:{PassWord}:{ClassID}";
        }
    }
}
