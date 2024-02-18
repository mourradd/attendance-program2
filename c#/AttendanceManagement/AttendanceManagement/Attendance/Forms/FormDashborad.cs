using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagement.Attendance.Forms
{
    public partial class FormDashborad : Form
    {
        public string Username, Role;
        public FormDashborad()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashborad_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if(Role == "Teacher")
            {
                Dashborad.Hide();
                buttonSetting.Hide();
                buttonAddTeacher.Hide();
                buttonAddCourse.Hide();
            }


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

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString();
        }

        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void Dashborad_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Dashborad);
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddTeacher);

        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddCourse);

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonSetting);

        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible) {
            panelExpand.Visible = false;
            }else
                panelExpand.Visible = true;
        }
    }
}
