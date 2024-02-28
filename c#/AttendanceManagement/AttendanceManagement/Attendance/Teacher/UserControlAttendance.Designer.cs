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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TAttendanceGridView1).BeginInit();
            SuspendLayout();
            // 
            // TAttendanceGridView1
            // 
            TAttendanceGridView1.AllowUserToAddRows = false;
            TAttendanceGridView1.AllowUserToDeleteRows = false;
            TAttendanceGridView1.Anchor = AnchorStyles.None;
            TAttendanceGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TAttendanceGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TAttendanceGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            TAttendanceGridView1.GridColor = SystemColors.MenuHighlight;
            TAttendanceGridView1.Location = new Point(153, 111);
            TAttendanceGridView1.Name = "TAttendanceGridView1";
            TAttendanceGridView1.ReadOnly = true;
            TAttendanceGridView1.Size = new Size(687, 208);
            TAttendanceGridView1.TabIndex = 0;
            TAttendanceGridView1.CellContentClick += TAttendanceGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.Frozen = true;
            Column1.HeaderText = "corse";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 215;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.Frozen = true;
            Column2.HeaderText = "Student_name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 214;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.FalseValue = "absent";
            Column3.Frozen = true;
            Column3.HeaderText = "status";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.TrueValue = "attend";
            Column3.Width = 215;
            // 
            // UserControlAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(TAttendanceGridView1);
            ForeColor = Color.Cyan;
            Name = "UserControlAttendance";
            Size = new Size(1014, 622);
            Load += UserControlAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)TAttendanceGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TAttendanceGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
    }
}
