namespace AttendanceManagement.Attendance.Teacher
{
    partial class UserControlTeacherDashboard
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
            components = new System.ComponentModel.Container();
            TDashboardGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            loadUserFromXMLBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)TDashboardGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadUserFromXMLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TDashboardGridView
            // 
            TDashboardGridView.AllowUserToDeleteRows = false;
            TDashboardGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TDashboardGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            TDashboardGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TDashboardGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            TDashboardGridView.Dock = DockStyle.Fill;
            TDashboardGridView.Location = new Point(0, 0);
            TDashboardGridView.Name = "TDashboardGridView";
            TDashboardGridView.ReadOnly = true;
            TDashboardGridView.RowHeadersWidth = 51;
            TDashboardGridView.Size = new Size(1163, 628);
            TDashboardGridView.TabIndex = 0;
            TDashboardGridView.CellContentClick += TDashboardGridView_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "course";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "class";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "number_of_students";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // loadUserFromXMLBindingSource
            // 
            loadUserFromXMLBindingSource.DataSource = typeof(AllClasses.LoadUserFromXML);
            // 
            // UserControlTeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TDashboardGridView);
            Name = "UserControlTeacherDashboard";
            Size = new Size(1163, 628);
            Load += UserControlTeacherDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)TDashboardGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadUserFromXMLBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TDashboardGridView;
        private BindingSource loadUserFromXMLBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
