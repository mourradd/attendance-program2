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
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 720);
            panel1.TabIndex = 0;
            // 
            // buttonSetting
            // 
            buttonSetting.Cursor = Cursors.Hand;
            buttonSetting.Dock = DockStyle.Top;
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.FlatStyle = FlatStyle.Flat;
            buttonSetting.ForeColor = Color.White;
            buttonSetting.Image = Properties.Resources.browser_settings1;
            buttonSetting.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSetting.Location = new Point(8, 462);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(252, 47);
            buttonSetting.TabIndex = 0;
            buttonSetting.Text = "     Setting";
            buttonSetting.TextAlign = ContentAlignment.MiddleLeft;
            buttonSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonReport
            // 
            buttonReport.Cursor = Cursors.Hand;
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ForeColor = Color.White;
            buttonReport.Image = Properties.Resources.report;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(8, 415);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(252, 47);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "     Reports";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonAddCourse
            // 
            buttonAddCourse.Cursor = Cursors.Hand;
            buttonAddCourse.Dock = DockStyle.Top;
            buttonAddCourse.FlatAppearance.BorderSize = 0;
            buttonAddCourse.FlatStyle = FlatStyle.Flat;
            buttonAddCourse.ForeColor = Color.White;
            buttonAddCourse.Image = Properties.Resources.homework;
            buttonAddCourse.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCourse.Location = new Point(8, 368);
            buttonAddCourse.Name = "buttonAddCourse";
            buttonAddCourse.Size = new Size(252, 47);
            buttonAddCourse.TabIndex = 0;
            buttonAddCourse.Text = "     Add Course";
            buttonAddCourse.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddCourse.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddCourse.UseVisualStyleBackColor = true;
            buttonAddCourse.Click += buttonAddCourse_Click;
            // 
            // buttonAddTeacher
            // 
            buttonAddTeacher.Cursor = Cursors.Hand;
            buttonAddTeacher.Dock = DockStyle.Top;
            buttonAddTeacher.FlatAppearance.BorderSize = 0;
            buttonAddTeacher.FlatStyle = FlatStyle.Flat;
            buttonAddTeacher.ForeColor = Color.White;
            buttonAddTeacher.Image = Properties.Resources.teacher;
            buttonAddTeacher.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddTeacher.Location = new Point(8, 321);
            buttonAddTeacher.Name = "buttonAddTeacher";
            buttonAddTeacher.Size = new Size(252, 47);
            buttonAddTeacher.TabIndex = 0;
            buttonAddTeacher.Text = "     Add Teacher";
            buttonAddTeacher.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddTeacher.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddTeacher.UseVisualStyleBackColor = true;
            buttonAddTeacher.Click += buttonAddTeacher_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Cursor = Cursors.Hand;
            buttonAddStudent.Dock = DockStyle.Top;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Image = Properties.Resources.reading1;
            buttonAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddStudent.Location = new Point(8, 274);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(252, 47);
            buttonAddStudent.TabIndex = 0;
            buttonAddStudent.Text = "     Add Student";
            buttonAddStudent.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Cursor = Cursors.Hand;
            buttonAttendance.Dock = DockStyle.Top;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Image = Properties.Resources.assessment;
            buttonAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.Location = new Point(8, 227);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(252, 47);
            buttonAttendance.TabIndex = 0;
            buttonAttendance.Text = "     Attendance";
            buttonAttendance.TextAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // Dashborad
            // 
            Dashborad.Cursor = Cursors.Hand;
            Dashborad.Dock = DockStyle.Top;
            Dashborad.FlatAppearance.BorderSize = 0;
            Dashborad.FlatStyle = FlatStyle.Flat;
            Dashborad.ForeColor = Color.White;
            Dashborad.Image = Properties.Resources.home3;
            Dashborad.ImageAlign = ContentAlignment.MiddleLeft;
            Dashborad.Location = new Point(8, 180);
            Dashborad.Name = "Dashborad";
            Dashborad.Size = new Size(252, 47);
            Dashborad.TabIndex = 0;
            Dashborad.Text = "     Dashborad";
            Dashborad.TextAlign = ContentAlignment.MiddleLeft;
            Dashborad.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashborad.UseVisualStyleBackColor = true;
            Dashborad.Click += Dashborad_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelSide);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 540);
            panel4.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(8, 47);
            panelSide.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 180);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(97, 140);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 0;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 115);
            label1.Name = "label1";
            label1.Size = new Size(220, 19);
            label1.TabIndex = 0;
            label1.Text = "Attendance Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(81, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(260, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(940, 180);
            panelBack.TabIndex = 0;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(51, 154, 240);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(buttonMinimize);
            panelExpand.Controls.Add(panel3);
            panelExpand.Location = new Point(728, 73);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 107);
            panelExpand.TabIndex = 2;
            panelExpand.Paint += panel3_Paint;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.Dock = DockStyle.Top;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            buttonLogOut.ForeColor = Color.FromArgb(51, 154, 240);
            buttonLogOut.Image = Properties.Resources.logout1;
            buttonLogOut.Location = new Point(0, 53);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(198, 48);
            buttonLogOut.TabIndex = 0;
            buttonLogOut.Text = "    Log Out";
            buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Century Gothic", 10F);
            buttonMinimize.ForeColor = Color.FromArgb(51, 154, 240);
            buttonMinimize.Image = Properties.Resources.minus;
            buttonMinimize.Location = new Point(0, 5);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(198, 48);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.Text = "    Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 5);
            panel3.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.down_arrow;
            pictureBoxExpand.Location = new Point(795, 50);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(27, 24);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 4;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.icons8_account_1001;
            pictureBox2.Location = new Point(729, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelTime.ForeColor = Color.FromArgb(51, 154, 240);
            labelTime.Location = new Point(24, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(35, 23);
            labelTime.TabIndex = 0;
            labelTime.Text = "(?)";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(51, 154, 240);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 80);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(940, 100);
            panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.FromArgb(51, 154, 240);
            labelRole.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(160, 56);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(37, 23);
            labelRole.TabIndex = 0;
            labelRole.Text = "(?)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(51, 154, 240);
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 57);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 0;
            label6.Text = "Role:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(51, 154, 240);
            labelUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(160, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(37, 23);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "(?)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(51, 154, 240);
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 22);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 0;
            label4.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // FormDashborad
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDashborad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashborad";
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
    }
}