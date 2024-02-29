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
            TAttendanceGridView1.AllowUserToDeleteRows = false;
            TAttendanceGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TAttendanceGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            TAttendanceGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TAttendanceGridView1.Columns.AddRange(new DataGridViewColumn[] { Student_name, status, status_written });
            TAttendanceGridView1.GridColor = SystemColors.InactiveCaptionText;
            TAttendanceGridView1.Location = new Point(0, 208);
            TAttendanceGridView1.Margin = new Padding(4, 5, 4, 5);
            TAttendanceGridView1.Name = "TAttendanceGridView1";
            TAttendanceGridView1.ReadOnly = true;
            TAttendanceGridView1.RowHeadersWidth = 51;
            TAttendanceGridView1.Size = new Size(1449, 413);
            TAttendanceGridView1.TabIndex = 0;
            TAttendanceGridView1.CellContentClick += TAttendanceGridView1_CellContentClick;
            // 
            // Student_name
            // 
            Student_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Student_name.Frozen = true;
            Student_name.HeaderText = "Student_name";
            Student_name.MinimumWidth = 6;
            Student_name.Name = "Student_name";
            Student_name.ReadOnly = true;
            Student_name.Width = 214;
            // 
            // status
            // 
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // status_written
            // 
            status_written.HeaderText = "status_written";
            status_written.MinimumWidth = 6;
            status_written.Name = "status_written";
            status_written.ReadOnly = true;
            // 
            // CompoCourse
            // 
            CompoCourse.ForeColor = Color.FromArgb(51, 154, 240);
            CompoCourse.FormattingEnabled = true;
            CompoCourse.IntegralHeight = false;
            CompoCourse.ItemHeight = 25;
            CompoCourse.Location = new Point(341, 58);
            CompoCourse.Margin = new Padding(4, 3, 4, 3);
            CompoCourse.Name = "CompoCourse";
            CompoCourse.Size = new Size(205, 33);
            CompoCourse.TabIndex = 9;
            CompoCourse.SelectedIndexChanged += CompoClass_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(239, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 10;
            label1.Text = "Filter";
            // 
            // CompoClass
            // 
            CompoClass.ForeColor = Color.FromArgb(51, 154, 240);
            CompoClass.FormattingEnabled = true;
            CompoClass.IntegralHeight = false;
            CompoClass.ItemHeight = 25;
            CompoClass.Location = new Point(557, 58);
            CompoClass.Margin = new Padding(4, 3, 4, 3);
            CompoClass.Name = "CompoClass";
            CompoClass.Size = new Size(205, 33);
            CompoClass.TabIndex = 9;
            CompoClass.SelectedIndexChanged += CompoClass_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(51, 154, 240);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(51, 154, 240);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(51, 154, 240);
            dateTimePicker1.Location = new Point(829, 58);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 154, 240);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(370, 12);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 12;
            textBox1.Text = "courses";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(51, 154, 240);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(596, 12);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 13;
            textBox2.Text = "classes";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(51, 154, 240);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(536, 669);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(201, 55);
            buttonSave.TabIndex = 14;
            buttonSave.Tag = "";
            buttonSave.Text = "save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(859, 755);
            btnPDF.Margin = new Padding(4, 5, 4, 5);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(217, 52);
            btnPDF.TabIndex = 15;
            btnPDF.Text = "export PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += button1_Click;
            // 
            // btnEXCELL
            // 
            btnEXCELL.Location = new Point(88, 755);
            btnEXCELL.Margin = new Padding(4, 5, 4, 5);
            btnEXCELL.Name = "btnEXCELL";
            btnEXCELL.Size = new Size(217, 52);
            btnEXCELL.TabIndex = 16;
            btnEXCELL.Text = "export EXCELL";
            btnEXCELL.UseVisualStyleBackColor = true;
            btnEXCELL.Click += button2_Click;
            // 
            // UserControlAttendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserControlAttendance";
            Size = new Size(1449, 1037);
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
