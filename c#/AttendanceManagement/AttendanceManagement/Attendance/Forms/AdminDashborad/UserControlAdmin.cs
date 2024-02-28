using AttendanceManagement.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagement.Attendance.Forms.AdminDashborad
{
    public partial class UserControlAdmin : UserControl
    {

        public UserControlAdmin()
        {
            InitializeComponent();
        }

        //public void Count()
        //{
        //    labelTotalStudents.Text
        //}

        private void UserControlAdmin_Load(object sender, EventArgs e)
        {
            // استدعاء الدالة لحساب عدد الطلاب
            int numberOfStudents = StudentsListGenerators.CountStudents();
            int numberOfTeachers=TeacherListGenerators.CountTeachers();
           labelTotalStudents.Text = numberOfStudents.ToString();
            labelTotalTeachers.Text = numberOfTeachers.ToString();
        }


    }
}
