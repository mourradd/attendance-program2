using AttendanceManagement.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttendanceManagement.Attendance.Teacher
{
    public partial class TeacherDashborad : Form
    {
        private ResourceManager _resourceManager;
        public string Username, Role, course;
        public TeacherDashborad(string name)
        {
            InitializeComponent();
            timerDateAndTime.Start();
            Username = name;
           // Text = "Attendance Backup";

          //  string[] sourceFilePaths = new string[]
          //  {
            //"..\\..\\..\\xml\\SystemData.xml",
            //"..\\..\\..\\xml\\AttendanceData.xml"
            //};

            //string backupDirPath = "..\\..\\..\\xml\\Backup";

            //AttendanceBackupService backupService = new AttendanceBackupService(sourceFilePaths, backupDirPath);



        }



        private void TeacherDashborad_Load(object sender, EventArgs e)
        {
            panelExp.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;
            CourseName.Text = course;
        }

        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }




        private void Dashborad_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Dashborad);
            panelTeacherPar.Controls.Clear();
            //    UserControlTeacherDashboard TeacherDashboard = new UserControlTeacherDashboard(Username);
            UserControlTeacherDashboard TeacherDashboard = new UserControlTeacherDashboard("Naser");
            panelTeacherPar.Controls.Add(TeacherDashboard);

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            DialogResult dialogResult = MessageBox.Show("Are you want to log out", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panelExpand.Hide();
            }
        }

        private void pictureBoxExp_Click(object sender, EventArgs e)
        {

            if (panelExp.Visible)
            {
                panelExp.Visible = false;
            }
            else
                panelExp.Visible = true;

        }

        private void buttonMinimiz_Click(object sender, EventArgs e)
        {
            panelExp.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }





        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            panelTeacherPar.Controls.Clear();
            UserControlAttendance USattendance = new UserControlAttendance(Username);
            panelTeacherPar.Controls.Add(USattendance);

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            panelTeacherPar.Controls.Clear();
           // UserControTReoprt USReport = new UserControTReoprt(Username);
           // panelTeacherPar.Controls.Add(USReport);


        }


        private void timerDateAndTime_Tick_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString();

        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSwitchLanguage_Click(object sender, EventArgs e)
        {

        }


    }
}
