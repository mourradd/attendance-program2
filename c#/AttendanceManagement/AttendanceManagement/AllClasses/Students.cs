using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.AllClasses
{
    public class Student : User
    {
       
       
        public int ClassID { get; set; }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{DateOfJoining}:{Email}:{Password}:{ClassID}";
        }
    }
}
