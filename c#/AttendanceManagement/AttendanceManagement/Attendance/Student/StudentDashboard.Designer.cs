using AttendanceManagement.AllClasses;
using AttendanceManagement.Attendance.Forms.AdminDashborad;
namespace AttendanceManagement.Attendance.Student

{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelBack = new Panel();
            panelExpand = new Panel();
            buttonMinimiz = new Button();
            buttonLogout2 = new Button();
            panel6 = new Panel();
            label7 = new Label();
            pictureBoxExpand = new PictureBox();
            comboBox1 = new ComboBox();
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
            pictureBox2 = new PictureBox();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            courseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfLectureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfAttendendLecDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberOfAbsentedLecDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentCourseAttandanceBindingSource = new BindingSource(components);
            attandanceBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            label5 = new Label();
            courseAttendanceBindingSource = new BindingSource(components);
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel1 = new Panel();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentCourseAttandanceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attandanceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseAttendanceBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(label7);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(comboBox1);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panelTop);
            panelBack.Controls.Add(pictureBox2);
            resources.ApplyResources(panelBack, "panelBack");
            panelBack.ForeColor = SystemColors.ActiveCaptionText;
            panelBack.Name = "panelBack";
            panelBack.Paint += panelBack_Paint;
            // 
            // panelExpand
            // 
            resources.ApplyResources(panelExpand, "panelExpand");
            panelExpand.BackColor = Color.FromArgb(51, 154, 240);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonMinimiz);
            panelExpand.Controls.Add(buttonLogout2);
            panelExpand.Controls.Add(panel6);
            panelExpand.Name = "panelExpand";
            // 
            // buttonMinimiz
            // 
            buttonMinimiz.BackColor = Color.White;
            buttonMinimiz.Cursor = Cursors.Hand;
            resources.ApplyResources(buttonMinimiz, "buttonMinimiz");
            buttonMinimiz.FlatAppearance.BorderSize = 0;
            buttonMinimiz.ForeColor = Color.FromArgb(51, 154, 240);
            buttonMinimiz.Name = "buttonMinimiz";
            buttonMinimiz.UseVisualStyleBackColor = false;
            buttonMinimiz.Click += buttonMinimize_Click;
            // 
            // buttonLogout2
            // 
            buttonLogout2.BackColor = Color.White;
            buttonLogout2.Cursor = Cursors.Hand;
            buttonLogout2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(buttonLogout2, "buttonLogout2");
            buttonLogout2.ForeColor = Color.FromArgb(51, 154, 240);
            buttonLogout2.Name = "buttonLogout2";
            buttonLogout2.UseVisualStyleBackColor = false;
            buttonLogout2.Click += buttonLogOut_Click;
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Name = "panel6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.FromArgb(51, 154, 240);
            label7.Name = "label7";
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelTime
            // 
            resources.ApplyResources(labelTime, "labelTime");
            labelTime.ForeColor = Color.FromArgb(51, 154, 240);
            labelTime.Name = "labelTime";
            labelTime.Click += labelTime_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(51, 154, 240);
            panelTop.Controls.Add(JoiningDateValue);
            panelTop.Controls.Add(JoiningDate);
            panelTop.Controls.Add(ClassValue);
            panelTop.Controls.Add(label8);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            resources.ApplyResources(panelTop, "panelTop");
            panelTop.Name = "panelTop";
            panelTop.Paint += panelTop_Paint;
            // 
            // JoiningDateValue
            // 
            resources.ApplyResources(JoiningDateValue, "JoiningDateValue");
            JoiningDateValue.BackColor = Color.FromArgb(51, 154, 240);
            JoiningDateValue.ForeColor = SystemColors.ActiveCaptionText;
            JoiningDateValue.Name = "JoiningDateValue";
            // 
            // JoiningDate
            // 
            resources.ApplyResources(JoiningDate, "JoiningDate");
            JoiningDate.BackColor = Color.FromArgb(51, 154, 240);
            JoiningDate.ForeColor = Color.White;
            JoiningDate.Name = "JoiningDate";
            // 
            // ClassValue
            // 
            resources.ApplyResources(ClassValue, "ClassValue");
            ClassValue.BackColor = Color.FromArgb(51, 154, 240);
            ClassValue.ForeColor = SystemColors.ActiveCaptionText;
            ClassValue.Name = "ClassValue";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.FromArgb(51, 154, 240);
            label8.ForeColor = Color.White;
            label8.Name = "label8";
            // 
            // labelRole
            // 
            resources.ApplyResources(labelRole, "labelRole");
            labelRole.BackColor = Color.FromArgb(51, 154, 240);
            labelRole.ForeColor = SystemColors.ActiveCaptionText;
            labelRole.Name = "labelRole";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.FromArgb(51, 154, 240);
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            label6.Click += label6_Click;
            // 
            // labelUsername
            // 
            resources.ApplyResources(labelUsername, "labelUsername");
            labelUsername.BackColor = Color.FromArgb(51, 154, 240);
            labelUsername.ForeColor = SystemColors.ActiveCaptionText;
            labelUsername.Name = "labelUsername";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.FromArgb(51, 154, 240);
            label4.ForeColor = Color.White;
            label4.Name = "label4";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.icons8_account_1001;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { courseNameDataGridViewTextBoxColumn, numberOfLectureDataGridViewTextBoxColumn, numberOfAttendendLecDataGridViewTextBoxColumn, numberOfAbsentedLecDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentCourseAttandanceBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(dataGridView1, "dataGridView1");
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
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            resources.ApplyResources(courseNameDataGridViewTextBoxColumn, "courseNameDataGridViewTextBoxColumn");
            courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfLectureDataGridViewTextBoxColumn
            // 
            numberOfLectureDataGridViewTextBoxColumn.DataPropertyName = "NumberOfLecture";
            resources.ApplyResources(numberOfLectureDataGridViewTextBoxColumn, "numberOfLectureDataGridViewTextBoxColumn");
            numberOfLectureDataGridViewTextBoxColumn.Name = "numberOfLectureDataGridViewTextBoxColumn";
            numberOfLectureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfAttendendLecDataGridViewTextBoxColumn
            // 
            numberOfAttendendLecDataGridViewTextBoxColumn.DataPropertyName = "NumberOfAttendendLec";
            resources.ApplyResources(numberOfAttendendLecDataGridViewTextBoxColumn, "numberOfAttendendLecDataGridViewTextBoxColumn");
            numberOfAttendendLecDataGridViewTextBoxColumn.Name = "numberOfAttendendLecDataGridViewTextBoxColumn";
            numberOfAttendendLecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfAbsentedLecDataGridViewTextBoxColumn
            // 
            numberOfAbsentedLecDataGridViewTextBoxColumn.DataPropertyName = "NumberOfAbsentedLec";
            resources.ApplyResources(numberOfAbsentedLecDataGridViewTextBoxColumn, "numberOfAbsentedLecDataGridViewTextBoxColumn");
            numberOfAbsentedLecDataGridViewTextBoxColumn.Name = "numberOfAbsentedLecDataGridViewTextBoxColumn";
            numberOfAbsentedLecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentCourseAttandanceBindingSource
            // 
            studentCourseAttandanceBindingSource.DataSource = typeof(StudentCourseAttandance);
            // 
            // attandanceBindingSource
            // 
            attandanceBindingSource.DataSource = typeof(Attandance);
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            resources.ApplyResources(comboBox2, "comboBox2");
            comboBox2.Name = "comboBox2";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // courseAttendanceBindingSource
            // 
            courseAttendanceBindingSource.DataSource = typeof(CourseAttendance);
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            resources.ApplyResources(panel2, "panel2");
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
            pictureBox1.Image = Properties.Resources.user;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 154, 240);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // StudentDashboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView1);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentDashboard";
            WindowState = FormWindowState.Maximized;
            Load += FormDashborad_Load;
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentCourseAttandanceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)attandanceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseAttendanceBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelBack;
        private Label labelTime;
        private Button Dashborad;



        private System.Windows.Forms.Timer timerDateAndTime;

#endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dateOfDayDataGridViewTextBoxColumn;
        private BindingSource attandanceBindingSource;
        private ComboBox comboBox2;
        private Label label5;
        private BindingSource studentCourseAttandanceBindingSource;
        private BindingSource courseAttendanceBindingSource;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel1;
        private Label label7;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfLectureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfAttendendLecDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberOfAbsentedLecDataGridViewTextBoxColumn;
        private Panel panelTop;
        private Label JoiningDateValue;
        private Label JoiningDate;
        private Label ClassValue;
        private Label label8;
        private Label labelRole;
        private Label label6;
        private Label labelUsername;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panelExpand;
        private Button buttonMinimiz;
        private Button buttonLogout2;
        private Panel panel6;
        private PictureBox pictureBoxExpand;
    }
}