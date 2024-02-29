namespace AttendanceManagement.Attendance.Teacher
{
    partial class UserControlAttendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAttendance));
            TAttendanceGridView1 = new DataGridView();
            Student_name = new DataGridViewTextBoxColumn();
            status = new DataGridViewCheckBoxColumn();
            status_written = new DataGridViewTextBoxColumn();
            CompoCourse = new ComboBox();
            label1 = new Label();
            CompoClass = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonSave = new Button();
            btnPDF = new Button();
            btnEXCELL = new Button();
            ((System.ComponentModel.ISupportInitialize)TAttendanceGridView1).BeginInit();
            SuspendLayout();
            // 
            // TAttendanceGridView1
            // 
            resources.ApplyResources(TAttendanceGridView1, "TAttendanceGridView1");
            TAttendanceGridView1.AllowUserToDeleteRows = false;
            TAttendanceGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TAttendanceGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            TAttendanceGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TAttendanceGridView1.Columns.AddRange(new DataGridViewColumn[] { Student_name, status, status_written });
            TAttendanceGridView1.GridColor = SystemColors.InactiveCaptionText;
            TAttendanceGridView1.Name = "TAttendanceGridView1";
            TAttendanceGridView1.ReadOnly = true;
            TAttendanceGridView1.UseWaitCursor = true;
            TAttendanceGridView1.CellContentClick += TAttendanceGridView1_CellContentClick;
            // 
            // Student_name
            // 
            Student_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Student_name.Frozen = true;
            resources.ApplyResources(Student_name, "Student_name");
            Student_name.Name = "Student_name";
            Student_name.ReadOnly = true;
            // 
            // status
            // 
            resources.ApplyResources(status, "status");
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // status_written
            // 
            resources.ApplyResources(status_written, "status_written");
            status_written.Name = "status_written";
            status_written.ReadOnly = true;
            // 
            // CompoCourse
            // 
            resources.ApplyResources(CompoCourse, "CompoCourse");
            CompoCourse.ForeColor = Color.FromArgb(51, 154, 240);
            CompoCourse.FormattingEnabled = true;
            CompoCourse.Name = "CompoCourse";
            CompoCourse.UseWaitCursor = true;
            CompoCourse.SelectedIndexChanged += CompoClass_SelectedIndexChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.DarkSlateGray;
            label1.Name = "label1";
            label1.UseWaitCursor = true;
            // 
            // CompoClass
            // 
            resources.ApplyResources(CompoClass, "CompoClass");
            CompoClass.ForeColor = Color.FromArgb(51, 154, 240);
            CompoClass.FormattingEnabled = true;
            CompoClass.Name = "CompoClass";
            CompoClass.UseWaitCursor = true;
            CompoClass.SelectedIndexChanged += CompoClass_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.CalendarForeColor = Color.FromArgb(51, 154, 240);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(51, 154, 240);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(51, 154, 240);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.UseWaitCursor = true;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.BackColor = Color.FromArgb(51, 154, 240);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Name = "textBox1";
            textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.BackColor = Color.FromArgb(51, 154, 240);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Name = "textBox2";
            textBox2.UseWaitCursor = true;
            // 
            // buttonSave
            // 
            resources.ApplyResources(buttonSave, "buttonSave");
            buttonSave.BackColor = Color.FromArgb(51, 154, 240);
            buttonSave.ForeColor = Color.White;
            buttonSave.Name = "buttonSave";
            buttonSave.Tag = "";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.UseWaitCursor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // btnPDF
            // 
            resources.ApplyResources(btnPDF, "btnPDF");
            btnPDF.Name = "btnPDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.UseWaitCursor = true;
            btnPDF.Click += button1_Click;
            // 
            // btnEXCELL
            // 
            resources.ApplyResources(btnEXCELL, "btnEXCELL");
            btnEXCELL.Name = "btnEXCELL";
            btnEXCELL.UseVisualStyleBackColor = true;
            btnEXCELL.UseWaitCursor = true;
            btnEXCELL.Click += button2_Click;
            // 
            // UserControlAttendance
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnEXCELL);
            Controls.Add(btnPDF);
            Controls.Add(buttonSave);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(CompoClass);
            Controls.Add(CompoCourse);
            Controls.Add(TAttendanceGridView1);
            ForeColor = Color.Cyan;
            Name = "UserControlAttendance";
            UseWaitCursor = true;
            Load += UserControlAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)TAttendanceGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TAttendanceGridView1;
        private ComboBox CompoCourse;
        private Label label1;
        private ComboBox CompoClass;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonSave;
        private Button btnPDF;
        private Button btnEXCELL;
        private DataGridViewTextBoxColumn Student_name;
        private DataGridViewCheckBoxColumn status;
        private DataGridViewTextBoxColumn status_written;
    }
}
