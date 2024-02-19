using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceManagement.AllClasses;
using AttendanceManagement.Attendance.Teacher;
//using static AttendanceManagement.Resources.UsersOfSystem;
using static AttendanceManagement.AllClasses.LoadUserFromXML;
namespace AttendanceManagement.Attendance.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");

        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();

        }

        private void pictureBoxError_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close");

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMinimize, "Minimize");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string filepath = "C:\\Users\\lap0\\OneDrive\\Desktop\\C#\\attendance-program2\\c#\\AttendanceManagement\\AttendanceManagement\\xml\\SystemData.xml";

            List<User> allUsers = LoadUsersFromXml(filepath);

            if (textBoxName.Text.Trim() != string.Empty && textBoxPassword.Text.Trim() != string.Empty)
            {
                foreach (var item in allUsers)
                {
                    if (textBoxName.Text.Trim() == item.Email && textBoxPassword.Text.Trim() == item.Password)
                    {
                        if (item.UserType == "admin")
                        {
                            FormDashborad FD = new FormDashborad();
                            FD.Username = item.Name;
                            FD.Role = item.UserType;
                            FD.ShowDialog();
                        }
                        else if (item.UserType == "teacher")
                        {
                            TeacherDashborad TD = new TeacherDashborad();
                            TD.Username = item.Name;
                            TD.Role = item.UserType;
                            TD.ShowDialog();
                        }
                        else
                        {
                            pictureBoxError.Hide();
                            labelError.Hide();

                        }

                        textBoxName.Clear();
                        textBoxPassword.Clear();
                        pictureBoxHide_Click(sender, e);
                        textBoxName.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Please Enter email and password");
                    }

                }

            }
        }
    }
}