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

        public void Count()
        {

        }

        private void UserControlAdmin_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
