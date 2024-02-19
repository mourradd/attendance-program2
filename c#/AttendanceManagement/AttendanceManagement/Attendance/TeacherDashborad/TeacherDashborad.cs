﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttendanceManagement.Attendance.TeacherDashborad
{
    public partial class TeacherDashborad : Form
    {
        public string Username, Role;
        public TeacherDashborad()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void TeacherDashborad_Load(object sender, EventArgs e)
        {
            panelExp.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;
        }

        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString();
        }


        private void Dashborad_Click(object sender, EventArgs e)
        {
            MoveSidePanel(Dashborad);
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
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
        }

        

        
    }
}