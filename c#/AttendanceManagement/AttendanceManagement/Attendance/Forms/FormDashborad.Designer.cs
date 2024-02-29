namespace AttendanceManagement.Attendance.Forms
{
    partial class FormDashborad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashborad));
            panel1 = new Panel();
            buttonSetting = new Button();
            buttonReport = new Button();
            buttonAddCourse = new Button();
            buttonAddTeacher = new Button();
            buttonAddStudent = new Button();
            buttonAttendance = new Button();
            Dashborad = new Button();
            panel4 = new Panel();
            panelSide = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelBack = new Panel();
            panelExpand = new Panel();
            buttonLogOut = new Button();
            buttonMinimize = new Button();
            panel3 = new Panel();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            panelTop = new Panel();
            labelRole = new Label();
            label6 = new Label();
            labelUsername = new Label();
            label4 = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            userControlAdmin1 = new AdminDashborad.UserControlAdmin();
            userControlAddStudent1 = new AdminDashborad.UserControlAddStudent();
            userControlAddTeacher1 = new AdminDashborad.UserControlAddTeacher();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(51, 154, 240);
            panel1.Controls.Add(buttonSetting);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonAddCourse);
            panel1.Controls.Add(buttonAddTeacher);
            panel1.Controls.Add(buttonAddStudent);
            panel1.Controls.Add(buttonAttendance);
            panel1.Controls.Add(Dashborad);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Name = "panel1";
            // 
            // buttonSetting
            // 
            resources.ApplyResources(buttonSetting, "buttonSetting");
            buttonSetting.Cursor = Cursors.Hand;
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.ForeColor = Color.White;
            buttonSetting.Image = Properties.Resources.browser_settings1;
            buttonSetting.Name = "buttonSetting";
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonReport
            // 
            resources.ApplyResources(buttonReport, "buttonReport");
            buttonReport.Cursor = Cursors.Hand;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.ForeColor = Color.White;
            buttonReport.Image = Properties.Resources.report;
            buttonReport.Name = "buttonReport";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonAddCourse
            // 
            resources.ApplyResources(buttonAddCourse, "buttonAddCourse");
            buttonAddCourse.Cursor = Cursors.Hand;
            buttonAddCourse.FlatAppearance.BorderSize = 0;
            buttonAddCourse.ForeColor = Color.White;
            buttonAddCourse.Image = Properties.Resources.homework;
            buttonAddCourse.Name = "buttonAddCourse";
            buttonAddCourse.UseVisualStyleBackColor = true;
            buttonAddCourse.Click += buttonAddCourse_Click;
            // 
            // buttonAddTeacher
            // 
            resources.ApplyResources(buttonAddTeacher, "buttonAddTeacher");
            buttonAddTeacher.Cursor = Cursors.Hand;
            buttonAddTeacher.FlatAppearance.BorderSize = 0;
            buttonAddTeacher.ForeColor = Color.White;
            buttonAddTeacher.Image = Properties.Resources.teacher;
            buttonAddTeacher.Name = "buttonAddTeacher";
            buttonAddTeacher.UseVisualStyleBackColor = true;
            buttonAddTeacher.Click += buttonAddTeacher_Click;
            // 
            // buttonAddStudent
            // 
            resources.ApplyResources(buttonAddStudent, "buttonAddStudent");
            buttonAddStudent.Cursor = Cursors.Hand;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Image = Properties.Resources.reading1;
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonAttendance
            // 
            resources.ApplyResources(buttonAttendance, "buttonAttendance");
            buttonAttendance.Cursor = Cursors.Hand;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Image = Properties.Resources.assessment;
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // Dashborad
            // 
            resources.ApplyResources(Dashborad, "Dashborad");
            Dashborad.Cursor = Cursors.Hand;
            Dashborad.FlatAppearance.BorderSize = 0;
            Dashborad.ForeColor = Color.White;
            Dashborad.Image = Properties.Resources.home3;
            Dashborad.Name = "Dashborad";
            Dashborad.UseVisualStyleBackColor = true;
            Dashborad.Click += Dashborad_Click;
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(panelSide);
            panel4.Name = "panel4";
            // 
            // panelSide
            // 
            resources.ApplyResources(panelSide, "panelSide");
            panelSide.BackColor = Color.White;
            panelSide.Name = "panelSide";
            panelSide.Paint += panelSide_Paint;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            resources.ApplyResources(panelBack, "panelBack");
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Name = "panelBack";
            // 
            // panelExpand
            // 
            resources.ApplyResources(panelExpand, "panelExpand");
            panelExpand.BackColor = Color.FromArgb(51, 154, 240);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(buttonMinimize);
            panelExpand.Controls.Add(panel3);
            panelExpand.Name = "panelExpand";
            panelExpand.Paint += panel3_Paint;
            // 
            // buttonLogOut
            // 
            resources.ApplyResources(buttonLogOut, "buttonLogOut");
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.ForeColor = Color.FromArgb(51, 154, 240);
            buttonLogOut.Image = Properties.Resources.logout1;
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonMinimize
            // 
            resources.ApplyResources(buttonMinimize, "buttonMinimize");
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.ForeColor = Color.FromArgb(51, 154, 240);
            buttonMinimize.Image = Properties.Resources.minus;
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            panel3.Paint += panel3_Paint_1;
            // 
            // pictureBoxExpand
            // 
            resources.ApplyResources(pictureBoxExpand, "pictureBoxExpand");
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.down_arrow;
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.icons8_account_1001;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            resources.ApplyResources(labelTime, "labelTime");
            labelTime.ForeColor = Color.FromArgb(51, 154, 240);
            labelTime.Name = "labelTime";
            // 
            // panelTop
            // 
            resources.ApplyResources(panelTop, "panelTop");
            panelTop.BackColor = Color.FromArgb(51, 154, 240);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            panelTop.Name = "panelTop";
            // 
            // labelRole
            // 
            resources.ApplyResources(labelRole, "labelRole");
            labelRole.BackColor = Color.FromArgb(51, 154, 240);
            labelRole.ForeColor = Color.White;
            labelRole.Name = "labelRole";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.FromArgb(51, 154, 240);
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            // 
            // labelUsername
            // 
            resources.ApplyResources(labelUsername, "labelUsername");
            labelUsername.BackColor = Color.FromArgb(51, 154, 240);
            labelUsername.ForeColor = Color.White;
            labelUsername.Name = "labelUsername";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.FromArgb(51, 154, 240);
            label4.ForeColor = Color.White;
            label4.Name = "label4";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // userControlAdmin1
            // 
            resources.ApplyResources(userControlAdmin1, "userControlAdmin1");
            userControlAdmin1.BackColor = Color.White;
            userControlAdmin1.Name = "userControlAdmin1";
            // 
            // userControlAddStudent1
            // 
            resources.ApplyResources(userControlAddStudent1, "userControlAddStudent1");
            userControlAddStudent1.BackColor = Color.White;
            userControlAddStudent1.Name = "userControlAddStudent1";
            userControlAddStudent1.Load += userControlAddStudent1_Load;
            // 
            // userControlAddTeacher1
            // 
            resources.ApplyResources(userControlAddTeacher1, "userControlAddTeacher1");
            userControlAddTeacher1.Name = "userControlAddTeacher1";
            userControlAddTeacher1.Load += userControlAddTeacher1_Load;
            // 
            // FormDashborad
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(userControlAddTeacher1);
            Controls.Add(userControlAddStudent1);
            Controls.Add(userControlAdmin1);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashborad";
            WindowState = FormWindowState.Maximized;
            Load += FormDashborad_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panelBack;
        private Panel panelTop;
        private Label labelTime;
        private Label label4;
        private PictureBox pictureBox2;
        private Label labelRole;
        private Label label6;
        private Label labelUsername;
        private PictureBox pictureBoxExpand;
        private Panel panelExpand;
        private Button buttonMinimize;
        private Panel panel3;
        private Button buttonLogOut;
        private Panel panelSide;
        private Panel panel4;
        private Button Dashborad;
        private Button buttonAttendance;
        private Button buttonReport;
        private Button buttonAddCourse;
        private Button buttonAddTeacher;
        private Button buttonAddStudent;
        private Button buttonSetting;
        private System.Windows.Forms.Timer timerDateAndTime;
        private AdminDashborad.UserControlAdmin userControlAdmin1;
        private AdminDashborad.UserControlAddStudent userControlAddStudent1;
        private AdminDashborad.UserControlAddTeacher userControlAddTeacher1;

        private AdminDashborad.UserControlAdmin userControlAdmin2;
    }
}