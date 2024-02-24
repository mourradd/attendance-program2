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
            panel1 = new Panel();
            panelSide1 = new Panel();
            panelSide2 = new Panel();
            buttonReport = new Button();
            buttonAttendance = new Button();
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
            dataGridView1 = new DataGridView();
            attandanceBindingSource = new BindingSource(components);
            dateOfDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attandanceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 154, 240);
            panel1.Controls.Add(panelSide1);
            panel1.Controls.Add(panelSide2);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonAttendance);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 645);
            panel1.TabIndex = 0;
            // 
            // panelSide1
            // 
            panelSide1.BackColor = Color.White;
            panelSide1.Location = new Point(9, 211);
            panelSide1.Margin = new Padding(4);
            panelSide1.Name = "panelSide1";
            panelSide1.Size = new Size(295, 10);
            panelSide1.TabIndex = 3;
            // 
            // panelSide2
            // 
            panelSide2.BackColor = Color.White;
            panelSide2.Location = new Point(9, 256);
            panelSide2.Margin = new Padding(4);
            panelSide2.Name = "panelSide2";
            panelSide2.Size = new Size(295, 10);
            panelSide2.TabIndex = 2;
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
            buttonReport.Location = new Point(9, 266);
            buttonReport.Margin = new Padding(4);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(294, 55);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "     Reports";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
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
            buttonAttendance.Location = new Point(9, 211);
            buttonAttendance.Margin = new Padding(4);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(294, 55);
            buttonAttendance.TabIndex = 0;
            buttonAttendance.Text = "     Attendance";
            buttonAttendance.TextAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelSide);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 211);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(9, 434);
            panel4.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(0, 0);
            panelSide.Margin = new Padding(4);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(9, 55);
            panelSide.TabIndex = 1;
            panelSide.Paint += panelSide_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 211);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(118, 152);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 0;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(51, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 18);
            label1.TabIndex = 0;
            label1.Text = "Attendance Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(38, 27);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 105);
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
            panelBack.Location = new Point(303, 0);
            panelBack.Margin = new Padding(4);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(697, 211);
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
            panelExpand.Location = new Point(527, 85);
            panelExpand.Margin = new Padding(4);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(124, 112);
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
            buttonLogOut.Location = new Point(0, 52);
            buttonLogOut.Margin = new Padding(4);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(122, 49);
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
            buttonMinimize.Location = new Point(0, 6);
            buttonMinimize.Margin = new Padding(4);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(122, 46);
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
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(122, 6);
            panel3.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.down_arrow;
            pictureBoxExpand.Location = new Point(527, 59);
            pictureBoxExpand.Margin = new Padding(4);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(31, 28);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 4;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.icons8_account_1001;
            pictureBox2.Location = new Point(450, 19);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            panelTop.BackColor = Color.FromArgb(51, 154, 240);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 94);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(697, 117);
            panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.FromArgb(51, 154, 240);
            labelRole.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(187, 66);
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
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(58, 67);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 0;
            label6.Text = "Role:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(51, 154, 240);
            labelUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(187, 26);
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
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 0;
            label4.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dateOfDayDataGridViewTextBoxColumn });
            dataGridView1.DataSource = StudentsListGenerators.Attandances;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(303, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 434);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // attandanceBindingSource
            // 
            attandanceBindingSource.DataSource = typeof(AllClasses.Attandance);
            // 
            // dateOfDayDataGridViewTextBoxColumn
            // 
            dateOfDayDataGridViewTextBoxColumn.DataPropertyName = "DateOfDay";
            dateOfDayDataGridViewTextBoxColumn.HeaderText = "DateOfDay";
            dateOfDayDataGridViewTextBoxColumn.Name = "dateOfDayDataGridViewTextBoxColumn";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 645);
            Controls.Add(dataGridView1);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "StudentDashboard";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)attandanceBindingSource).EndInit();
            ResumeLayout(false);
        }

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



        private System.Windows.Forms.Timer timerDateAndTime;

        #endregion

        private Panel panelSide2;
        private Panel panelSide1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dateOfDayDataGridViewTextBoxColumn;
        private BindingSource attandanceBindingSource;
    }
}