using AttendanceManagement.AllClasses;

namespace AttendanceManagement.Attendance.Student
{
    partial class StudentCourseAttendaceDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelBack = new Panel();
            pictureBoxClose = new PictureBox();
            labelTime = new Label();
            panelTop = new Panel();
            JoiningDateValue = new Label();
            JoiningDate = new Label();
            ClassValue = new Label();
            label8 = new Label();
            labelRole = new Label();
            label6 = new Label();
            labelUsername = new Label();
            label4 = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            dayDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            attendanceStateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentDayAttendBindingSource = new BindingSource(components);
            studentCourseAttandanceBindingSource = new BindingSource(components);
            numberOfAttendendLecDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfAbsentedLecDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            attandanceBindingSource = new BindingSource(components);
            courseAttendanceBindingSource = new BindingSource(components);
            buttonReport = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            CoursNaneValue = new Label();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentDayAttendBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentCourseAttandanceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attandanceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseAttendanceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelBack
            // 
            panelBack.Controls.Add(pictureBoxClose);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Dock = DockStyle.Top;
            panelBack.ForeColor = SystemColors.ActiveCaptionText;
            panelBack.Location = new Point(0, 0);
            panelBack.Margin = new Padding(4);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1813, 211);
            panelBack.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.icons8_cross_50;
            pictureBoxClose.Location = new Point(1770, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(31, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click_1;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelTime.ForeColor = Color.FromArgb(51, 154, 240);
            labelTime.Location = new Point(28, 27);
            labelTime.Margin = new Padding(4, 0, 4, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(28, 18);
            labelTime.TabIndex = 0;
            labelTime.Text = "(?)";
            // 
            // panelTop
            // 
            panelTop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTop.BackColor = Color.FromArgb(51, 154, 240);
            panelTop.Controls.Add(JoiningDateValue);
            panelTop.Controls.Add(JoiningDate);
            panelTop.Controls.Add(ClassValue);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 94);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1813, 117);
            panelTop.TabIndex = 0;
            // 
            // JoiningDateValue
            // 
            JoiningDateValue.AutoSize = true;
            JoiningDateValue.BackColor = Color.FromArgb(51, 154, 240);
            JoiningDateValue.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            JoiningDateValue.ForeColor = SystemColors.ActiveCaptionText;
            JoiningDateValue.Location = new Point(665, 70);
            JoiningDateValue.Margin = new Padding(4, 0, 4, 0);
            JoiningDateValue.Name = "JoiningDateValue";
            JoiningDateValue.Size = new Size(30, 19);
            JoiningDateValue.TabIndex = 3;
            JoiningDateValue.Text = "(?)";
            // 
            // JoiningDate
            // 
            JoiningDate.AutoSize = true;
            JoiningDate.BackColor = Color.FromArgb(51, 154, 240);
            JoiningDate.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            JoiningDate.ForeColor = Color.White;
            JoiningDate.Location = new Point(510, 63);
            JoiningDate.Margin = new Padding(4, 0, 4, 0);
            JoiningDate.Name = "JoiningDate";
            JoiningDate.Size = new Size(128, 28);
            JoiningDate.TabIndex = 4;
            JoiningDate.Text = "Join Date:";
            // 
            // ClassValue
            // 
            ClassValue.AutoSize = true;
            ClassValue.BackColor = Color.FromArgb(51, 154, 240);
            ClassValue.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ClassValue.ForeColor = SystemColors.ActiveCaptionText;
            ClassValue.Location = new Point(665, 33);
            ClassValue.Margin = new Padding(4, 0, 4, 0);
            ClassValue.Name = "ClassValue";
            ClassValue.Size = new Size(30, 19);
            ClassValue.TabIndex = 1;
            ClassValue.Text = "(?)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(51, 154, 240);
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(507, 26);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 28);
            label8.TabIndex = 2;
            label8.Text = "Class       :";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.FromArgb(51, 154, 240);
            labelRole.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelRole.ForeColor = SystemColors.ActiveCaptionText;
            labelRole.Location = new Point(219, 65);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(30, 19);
            labelRole.TabIndex = 0;
            labelRole.Text = "(?)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(51, 154, 240);
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(58, 63);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 0;
            label6.Text = "Role         :";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(51, 154, 240);
            labelUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelUsername.ForeColor = SystemColors.ActiveCaptionText;
            labelUsername.Location = new Point(219, 26);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(30, 19);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "(?)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(51, 154, 240);
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 0;
            label4.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dayDateDataGridViewTextBoxColumn, attendanceStateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentDayAttendBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 4;
            dataGridView1.Size = new Size(1813, 342);
            dataGridView1.TabIndex = 1;
            // 
            // dayDateDataGridViewTextBoxColumn
            // 
            dayDateDataGridViewTextBoxColumn.DataPropertyName = "Day_Date";
            dayDateDataGridViewTextBoxColumn.HeaderText = "Day_Date";
            dayDateDataGridViewTextBoxColumn.Name = "dayDateDataGridViewTextBoxColumn";
            dayDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceStateDataGridViewTextBoxColumn
            // 
            attendanceStateDataGridViewTextBoxColumn.DataPropertyName = "Attendance_State";
            attendanceStateDataGridViewTextBoxColumn.HeaderText = "Attendance_State";
            attendanceStateDataGridViewTextBoxColumn.Name = "attendanceStateDataGridViewTextBoxColumn";
            attendanceStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDayAttendBindingSource
            // 
            studentDayAttendBindingSource.DataSource = typeof(StudentDayAttend);
            // 
            // studentCourseAttandanceBindingSource
            // 
            studentCourseAttandanceBindingSource.DataSource = typeof(StudentDayAttend);
            // 
            // numberOfAttendendLecDataGridViewTextBoxColumn
            // 
            numberOfAttendendLecDataGridViewTextBoxColumn.Name = "numberOfAttendendLecDataGridViewTextBoxColumn";
            // 
            // numberOfAbsentedLecDataGridViewTextBoxColumn
            // 
            numberOfAbsentedLecDataGridViewTextBoxColumn.Name = "numberOfAbsentedLecDataGridViewTextBoxColumn";
            // 
            // attandanceBindingSource
            // 
            attandanceBindingSource.DataSource = typeof(Attandance);
            // 
            // courseAttendanceBindingSource
            // 
            courseAttendanceBindingSource.DataSource = typeof(CourseAttendance);
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(151, 154, 240);
            buttonReport.Cursor = Cursors.Hand;
            buttonReport.Dock = DockStyle.Right;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ForeColor = Color.White;
            buttonReport.Image = Properties.Resources.report;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(1646, 211);
            buttonReport.Margin = new Padding(3, 2, 3, 2);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(167, 73);
            buttonReport.TabIndex = 2;
            buttonReport.Text = " Save Report";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Pdf", "Excel", "Web Page" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "" });
            comboBox1.Location = new Point(1519, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 31);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1220, 235);
            label1.Name = "label1";
            label1.Size = new Size(282, 23);
            label1.TabIndex = 4;
            label1.Text = "Choose the type of the Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(151, 154, 240);
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 235);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 6;
            label3.Text = "Course Name";
            // 
            // CoursNaneValue
            // 
            CoursNaneValue.AutoSize = true;
            CoursNaneValue.BackColor = Color.WhiteSmoke;
            CoursNaneValue.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            CoursNaneValue.ForeColor = SystemColors.ActiveCaptionText;
            CoursNaneValue.Location = new Point(219, 242);
            CoursNaneValue.Margin = new Padding(4, 0, 4, 0);
            CoursNaneValue.Name = "CoursNaneValue";
            CoursNaneValue.Size = new Size(30, 19);
            CoursNaneValue.TabIndex = 5;
            CoursNaneValue.Text = "(?)";
            // 
            // StudentCourseAttendaceDashboard
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1813, 626);
            Controls.Add(CoursNaneValue);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(buttonReport);
            Controls.Add(dataGridView1);
            Controls.Add(panelBack);
            Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "StudentCourseAttendaceDashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dashborad";
            Load += FormDashborad_Load;
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentDayAttendBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentCourseAttandanceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)attandanceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseAttendanceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelBack;
        private Panel panelTop;
        private Label labelTime;
        private Label label4;
        private Label labelRole;
        private Label label6;
        private Label labelUsername;
        private Button Dashborad;



        private System.Windows.Forms.Timer timerDateAndTime;

#endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dateOfDayDataGridViewTextBoxColumn;
        private BindingSource attandanceBindingSource;
        private BindingSource studentCourseAttandanceBindingSource;
        private BindingSource courseAttendanceBindingSource;
        private DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfLectureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfAttendendLecDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfAbsentedLecDataGridViewTextBoxColumn;
        private Label ClassValue;
        private Label label8;
        private Label JoiningDateValue;
        private Label JoiningDate;
        private PictureBox pictureBoxClose;
        private DataGridViewTextBoxColumn dayDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attendanceStateDataGridViewTextBoxColumn;
        private BindingSource studentDayAttendBindingSource;
        private Button buttonReport;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private Label CoursNaneValue;
    }
}