using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.AllClasses
{
    public class Student : User
    {
       
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string ClassID { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{DateOfJoining}:{Email}:{Password}:{ClassID}";
        }
    }
}
