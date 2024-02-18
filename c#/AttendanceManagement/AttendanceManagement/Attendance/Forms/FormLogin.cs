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
using static AttendanceManagement.Resources.UsersOfSystem;

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
            if (textBoxName.Text.Trim() != string.Empty && textBoxPassword.Text.Trim() != string.Empty)
            {
                foreach (var item in students)
                {
                    if (textBoxName.Text.Trim() == item.Email && textBoxPassword.Text.Trim() == item.PassWord)
                    {
                        FormDashborad FD = new FormDashborad();

                        FD.Username = item.Name;
                        FD.Role = "admin";
                        textBoxName.Clear();
                        textBoxPassword.Clear();
                        pictureBoxHide_Click(sender, e);
                        textBoxName.Focus();
                        pictureBoxError.Hide();
                        labelError.Hide();
                        FD.ShowDialog();

                    }else
                    {
                        pictureBoxError.Show();
                        labelError.Show();
                    }

                }
                //if (textBoxName.Text.Trim() == "mohamed" && textBoxPassword.Text.Trim() == "123" || textBoxName.Text.Trim() == "ali" && textBoxPassword.Text.Trim() == "123")
                //{

                //    FormDashborad FD = new FormDashborad();


                //    if (textBoxName.Text.Trim() == "mohamed")
                //    {
                //        FD.Role = "Admin";
                //    }
                //    else
                //    {
                //        FD.Role = "Teacher";
                //    }
                //    FD.Username = textBoxName.Text;
                //    textBoxName.Clear();
                //    textBoxPassword.Clear();
                //    pictureBoxHide_Click(sender, e);
                //    textBoxName.Focus();
                //    pictureBoxError.Hide();
                //    labelError.Hide();
                //    FD.ShowDialog();

                //}
                //else
                //{
                //    pictureBoxError.Show();
                //    labelError.Show();
                //}
            }
            else
            {
                pictureBoxError.Show();
                labelError.Show();
            }
        }
    }
}