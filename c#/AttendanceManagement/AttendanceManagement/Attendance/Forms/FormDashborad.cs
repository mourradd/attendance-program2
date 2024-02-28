using AttendanceManagement.Attendance.Forms.AdminDashborad;

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
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 208);
        }


        private void Dashborad_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Dashborad);
            userControlAdmin1.Visible = true;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlAdmin1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControlAdmin1.Visible = false;
            userControlAddStudent1.Visible = true;
            userControlAddTeacher1.Visible = false;


        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddTeacher);
            userControlAdmin1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = true;



        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddCourse);
            userControlAdmin1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;




        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlAdmin1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;



        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonSetting);
            userControlAdmin1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAddTeacher1.Visible = false;




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

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        

       

        
    }
}
