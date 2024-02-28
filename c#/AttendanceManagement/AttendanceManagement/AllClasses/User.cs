using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.AllClasses
{


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfJoining { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; } // type of user

        public string ClassID { get; set; }
    }

    //public class Students : User
    //{
    //    //public string ClassID { get; set; }
    //}

    public class Teachers : User
    {
        public List<int> CoursesTaught { get; set; }
    }

    public class Admins : User
    {
        
    }




}


