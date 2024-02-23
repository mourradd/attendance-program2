using AttendanceManagement.Attendance.Forms.AdminDashborad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttendanceManagement.Attendance.Student
{
    public partial class StudentDashboard : Form
    {
        public string Username, Role;

        public StudentDashboard()
        {
            InitializeComponent();
            timerDateAndTime.Start();

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            //MoveSidePanel(buttonSetting);
            //userControlAdmin1.Visible = false;
            //userControlAddStudent1.Visible = false;



        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            //////MoveSidePanel(buttonAttendance);
            //////userControlAdmin1.Visible = false;
            //////userControlAddStudent1.Visible = false;

        }

        private void Dashborad_Click(object sender, EventArgs e)
        {
            //MoveSidePanel(Dashborad);
            //userControlAdmin1.Visible = true;
            //userControlAddStudent1.Visible = false;
            //userControlAdmin1.Count();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonLogOut_Click(object sender, EventArgs e)
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


        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }


        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
                panelExpand.Visible = true;
        }


        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString();
        }


        private void FormDashborad_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;


        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            //MoveSidePanel(buttonReport);
            //userControlAdmin1.Visible = false;
            //userControlAddStudent1.Visible = false;


        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

    }



}
