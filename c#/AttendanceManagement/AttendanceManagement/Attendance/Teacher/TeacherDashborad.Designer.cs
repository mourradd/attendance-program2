namespace AttendanceManagement.Attendance.Teacher
{
    partial class TeacherDashborad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashborad));
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            buttonLogOut = new Button();
            buttonMinimize = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panelExpand = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelSide = new Panel();
            buttonReport = new Button();
            buttonAttendance = new Button();
            Dashborad = new Button();
            panel4 = new Panel();
            panelBack = new Panel();
            label2 = new Label();
            comboBox2 = new ComboBox();
            pictureBoxExp = new PictureBox();
            panelExp = new Panel();
            buttonMinimiz = new Button();
            buttonLogout2 = new Button();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            panelTop = new Panel();
            CourseName = new Label();
            Course = new Label();
            labelRole = new Label();
            label6 = new Label();
            labelUsername = new Label();
            label4 = new Label();
            panel1 = new Panel();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            panelTeacherPar = new Panel();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExp).BeginInit();
            panelExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxExpand
            // 
            resources.ApplyResources(pictureBoxExpand, "pictureBoxExpand");
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.down_arrow;
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.TabStop = false;
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
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
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
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.teacher1;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Name = "panel2";
            // 
            // panelSide
            // 
            resources.ApplyResources(panelSide, "panelSide");
            panelSide.BackColor = Color.White;
            panelSide.Name = "panelSide";
            panelSide.Paint += panelSide_Paint;
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
            // panelBack
            // 
            resources.ApplyResources(panelBack, "panelBack");
            panelBack.Controls.Add(label2);
            panelBack.Controls.Add(comboBox2);
            panelBack.Controls.Add(pictureBoxExp);
            panelBack.Controls.Add(panelExp);
            panelBack.Controls.Add(pictureBox3);
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Name = "panelBack";
            panelBack.Paint += panelBack_Paint;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // comboBox2
            // 
            resources.ApplyResources(comboBox2, "comboBox2");
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { resources.GetString("comboBox2.Items"), resources.GetString("comboBox2.Items1") });
            comboBox2.Name = "comboBox2";
            // 
            // pictureBoxExp
            // 
            resources.ApplyResources(pictureBoxExp, "pictureBoxExp");
            pictureBoxExp.Cursor = Cursors.Hand;
            pictureBoxExp.Image = Properties.Resources.down_arrow;
            pictureBoxExp.Name = "pictureBoxExp";
            pictureBoxExp.TabStop = false;
            pictureBoxExp.Click += pictureBoxExp_Click;
            // 
            // panelExp
            // 
            resources.ApplyResources(panelExp, "panelExp");
            panelExp.BackColor = Color.FromArgb(51, 154, 240);
            panelExp.BorderStyle = BorderStyle.FixedSingle;
            panelExp.Controls.Add(buttonMinimiz);
            panelExp.Controls.Add(buttonLogout2);
            panelExp.Controls.Add(panel6);
            panelExp.Name = "panelExp";
            // 
            // buttonMinimiz
            // 
            resources.ApplyResources(buttonMinimiz, "buttonMinimiz");
            buttonMinimiz.BackColor = Color.White;
            buttonMinimiz.Cursor = Cursors.Hand;
            buttonMinimiz.FlatAppearance.BorderSize = 0;
            buttonMinimiz.ForeColor = Color.FromArgb(51, 154, 240);
            buttonMinimiz.Image = Properties.Resources.minus;
            buttonMinimiz.Name = "buttonMinimiz";
            buttonMinimiz.UseVisualStyleBackColor = false;
            buttonMinimiz.Click += buttonMinimiz_Click;
            // 
            // buttonLogout2
            // 
            resources.ApplyResources(buttonLogout2, "buttonLogout2");
            buttonLogout2.BackColor = Color.White;
            buttonLogout2.Cursor = Cursors.Hand;
            buttonLogout2.FlatAppearance.BorderSize = 0;
            buttonLogout2.ForeColor = Color.FromArgb(51, 154, 240);
            buttonLogout2.Image = Properties.Resources.logout1;
            buttonLogout2.Name = "buttonLogout2";
            buttonLogout2.UseVisualStyleBackColor = false;
            buttonLogout2.Click += button1_Click;
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Name = "panel6";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Image = Properties.Resources.teacher2;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // panelTop
            // 
            resources.ApplyResources(panelTop, "panelTop");
            panelTop.BackColor = Color.FromArgb(51, 154, 240);
            panelTop.Controls.Add(CourseName);
            panelTop.Controls.Add(Course);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            panelTop.Name = "panelTop";
            // 
            // CourseName
            // 
            resources.ApplyResources(CourseName, "CourseName");
            CourseName.BackColor = Color.FromArgb(51, 154, 240);
            CourseName.ForeColor = Color.White;
            CourseName.Name = "CourseName";
            // 
            // Course
            // 
            resources.ApplyResources(Course, "Course");
            Course.BackColor = Color.FromArgb(51, 154, 240);
            Course.ForeColor = Color.White;
            Course.Name = "Course";
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
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(51, 154, 240);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonAttendance);
            panel1.Controls.Add(Dashborad);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Name = "panel1";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick_1;
            // 
            // panelTeacherPar
            // 
            resources.ApplyResources(panelTeacherPar, "panelTeacherPar");
            panelTeacherPar.Name = "panelTeacherPar";
            panelTeacherPar.Paint += panelTeacherPar_Paint;
            // 
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.FormattingEnabled = true;
            comboBox1.Name = "comboBox1";
            // 
            // TeacherDashborad
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBox1);
            Controls.Add(panelTeacherPar);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherDashborad";
            WindowState = FormWindowState.Maximized;
            Load += TeacherDashborad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExp).EndInit();
            panelExp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBox2;
        private Label labelTime;
        private Button buttonLogOut;
        private Button buttonMinimize;
        private Panel panel3;
        private Label label1;
        private Panel panelExpand;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panelSide;
        private Button buttonReport;
        public Button buttonAttendance;
        private Button Dashborad;
        private Panel panel4;
        private Panel panelBack;
        private Panel panel1;
        private Panel panelTop;
        private Label labelRole;
        private Label label6;
        private Label labelUsername;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panelExp;
        private Button buttonLogout2;
        private Panel panel6;
        private PictureBox pictureBoxExp;
        private Button buttonMinimiz;
        private System.Windows.Forms.Timer timerDateAndTime;
        private UserControlTeacherDashboard teacherDashboard1;
        public Panel panelTeacherPar;
        private Label CourseName;
        private Label Course;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}
