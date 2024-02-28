namespace AttendanceManagement.Attendance.Forms.AdminDashborad
{
    partial class UserControlAddStudent
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
            toolTip = new ToolTip(components);
            tabControlAddStudent = new TabControl();
            tabPageAddStudent = new TabPage();
            comboBoxClass = new ComboBox();
            buttonAddStudent = new Button();
            panel5 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            textBoxPassword = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            textBoxEmail = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBoxAge = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            textBoxName = new TextBox();
            label1 = new Label();
            labelAddStudent = new Label();
            tabPageSearchStudent = new TabPage();
            comboBoxSearch = new ComboBox();
            panel12 = new Panel();
            label16 = new Label();
            labelCountStudents = new Label();
            label8 = new Label();
            dataGridViewStudents = new DataGridView();
            textBoxSearch = new TextBox();
            pictureBoxSearch = new PictureBox();
            panel6 = new Panel();
            label6 = new Label();
            label7 = new Label();
            tabPageUDStudent = new TabPage();
            comboBoxClassUD = new ComboBox();
            buttonDelete = new Button();
            panel7 = new Panel();
            label10 = new Label();
            buttonUpdate = new Button();
            panel8 = new Panel();
            textBoxPassword1 = new TextBox();
            label11 = new Label();
            panel9 = new Panel();
            textBoxEmail1 = new TextBox();
            label12 = new Label();
            panel10 = new Panel();
            textBoxAge1 = new TextBox();
            label13 = new Label();
            panel11 = new Panel();
            textBoxName1 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            tabControlAddStudent.SuspendLayout();
            tabPageAddStudent.SuspendLayout();
            tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            tabPageUDStudent.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            tabControlAddStudent.Alignment = TabAlignment.Bottom;
            tabControlAddStudent.Controls.Add(tabPageAddStudent);
            tabControlAddStudent.Controls.Add(tabPageSearchStudent);
            tabControlAddStudent.Controls.Add(tabPageUDStudent);
            tabControlAddStudent.Dock = DockStyle.Fill;
            tabControlAddStudent.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            tabControlAddStudent.Location = new Point(0, 0);
            tabControlAddStudent.Name = "tabControlAddStudent";
            tabControlAddStudent.SelectedIndex = 0;
            tabControlAddStudent.Size = new Size(1230, 867);
            tabControlAddStudent.TabIndex = 0;
            tabControlAddStudent.Leave += tabControlAddStudent_Leave;
            // 
            // tabPageAddStudent
            // 
            tabPageAddStudent.Controls.Add(comboBoxClass);
            tabPageAddStudent.Controls.Add(buttonAddStudent);
            tabPageAddStudent.Controls.Add(panel5);
            tabPageAddStudent.Controls.Add(label5);
            tabPageAddStudent.Controls.Add(panel4);
            tabPageAddStudent.Controls.Add(textBoxPassword);
            tabPageAddStudent.Controls.Add(label4);
            tabPageAddStudent.Controls.Add(panel3);
            tabPageAddStudent.Controls.Add(textBoxEmail);
            tabPageAddStudent.Controls.Add(label3);
            tabPageAddStudent.Controls.Add(panel2);
            tabPageAddStudent.Controls.Add(textBoxAge);
            tabPageAddStudent.Controls.Add(label2);
            tabPageAddStudent.Controls.Add(panel1);
            tabPageAddStudent.Controls.Add(textBoxName);
            tabPageAddStudent.Controls.Add(label1);
            tabPageAddStudent.Controls.Add(labelAddStudent);
            tabPageAddStudent.Location = new Point(4, 4);
            tabPageAddStudent.Name = "tabPageAddStudent";
            tabPageAddStudent.Padding = new Padding(3);
            tabPageAddStudent.Size = new Size(1222, 827);
            tabPageAddStudent.TabIndex = 0;
            tabPageAddStudent.Text = "Add Student";
            tabPageAddStudent.UseVisualStyleBackColor = true;
            tabPageAddStudent.Click += tabPageAddStudent_Click;
            tabPageAddStudent.Enter += tabPageAddStudent_Enter;
            tabPageAddStudent.Leave += tabPageAddStudent_Leave;
            // 
            // comboBoxClass
            // 
            comboBoxClass.Anchor = AnchorStyles.None;
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "--Select--" });
            comboBoxClass.Location = new Point(141, 419);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 35);
            comboBoxClass.TabIndex = 0;
            comboBoxClass.Click += comboBoxClass_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Anchor = AnchorStyles.None;
            buttonAddStudent.BackColor = Color.LightBlue;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.Location = new Point(591, 420);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(113, 37);
            buttonAddStudent.TabIndex = 0;
            buttonAddStudent.Text = "Add";
            buttonAddStudent.UseVisualStyleBackColor = false;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(144, 455);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(141, 388);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 0;
            label5.Text = "Class:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(591, 368);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(591, 342);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(270, 29);
            textBoxPassword.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(591, 310);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(144, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Location = new Point(144, 341);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 29);
            textBoxEmail.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(141, 310);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(594, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 0;
            // 
            // textBoxAge
            // 
            textBoxAge.Anchor = AnchorStyles.None;
            textBoxAge.BorderStyle = BorderStyle.None;
            textBoxAge.Location = new Point(591, 255);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(270, 29);
            textBoxAge.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(591, 224);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 0;
            label2.Text = "Age:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(144, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Location = new Point(144, 257);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 29);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(141, 226);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // labelAddStudent
            // 
            labelAddStudent.AutoSize = true;
            labelAddStudent.BackColor = Color.LightSkyBlue;
            labelAddStudent.Location = new Point(6, 5);
            labelAddStudent.Name = "labelAddStudent";
            labelAddStudent.Size = new Size(154, 28);
            labelAddStudent.TabIndex = 0;
            labelAddStudent.Text = "Add Student";
            // 
            // tabPageSearchStudent
            // 
            tabPageSearchStudent.Controls.Add(comboBoxSearch);
            tabPageSearchStudent.Controls.Add(panel12);
            tabPageSearchStudent.Controls.Add(label16);
            tabPageSearchStudent.Controls.Add(labelCountStudents);
            tabPageSearchStudent.Controls.Add(label8);
            tabPageSearchStudent.Controls.Add(dataGridViewStudents);
            tabPageSearchStudent.Controls.Add(textBoxSearch);
            tabPageSearchStudent.Controls.Add(pictureBoxSearch);
            tabPageSearchStudent.Controls.Add(panel6);
            tabPageSearchStudent.Controls.Add(label6);
            tabPageSearchStudent.Controls.Add(label7);
            tabPageSearchStudent.Location = new Point(4, 4);
            tabPageSearchStudent.Name = "tabPageSearchStudent";
            tabPageSearchStudent.Padding = new Padding(3);
            tabPageSearchStudent.Size = new Size(1222, 827);
            tabPageSearchStudent.TabIndex = 1;
            tabPageSearchStudent.Text = "Search Student";
            tabPageSearchStudent.UseVisualStyleBackColor = true;
            tabPageSearchStudent.Enter += tabPageSearchStudent_Enter;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.Anchor = AnchorStyles.None;
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearch.FlatStyle = FlatStyle.Flat;
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "Name", "Email", "Class" });
            comboBoxSearch.Location = new Point(734, 77);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(167, 35);
            comboBoxSearch.TabIndex = 0;
            comboBoxSearch.SelectedValueChanged += comboBoxSearch_SelectedValueChanged;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.LightGray;
            panel12.Location = new Point(734, 114);
            panel12.Name = "panel12";
            panel12.Size = new Size(167, 2);
            panel12.TabIndex = 0;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Location = new Point(734, 50);
            label16.Name = "label16";
            label16.Size = new Size(134, 28);
            label16.TabIndex = 0;
            label16.Text = "Search By:";
            // 
            // labelCountStudents
            // 
            labelCountStudents.AutoSize = true;
            labelCountStudents.Font = new Font("Century Gothic", 12F);
            labelCountStudents.Location = new Point(1181, 760);
            labelCountStudents.Name = "labelCountStudents";
            labelCountStudents.Size = new Size(35, 23);
            labelCountStudents.TabIndex = 0;
            labelCountStudents.Text = "(0)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1009, 757);
            label8.Name = "label8";
            label8.Size = new Size(176, 28);
            label8.TabIndex = 0;
            label8.Text = "Total Students:";
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.AllowUserToResizeColumns = false;
            dataGridViewStudents.AllowUserToResizeRows = false;
            dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.BackgroundColor = Color.White;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(19, 131);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudents.ShowCellErrors = false;
            dataGridViewStudents.ShowEditingIcon = false;
            dataGridViewStudents.ShowRowErrors = false;
            dataGridViewStudents.Size = new Size(1178, 620);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.CellDoubleClick += dataGridViewStudents_CellDoubleClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Location = new Point(151, 83);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(252, 29);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Image = Properties.Resources.search;
            pictureBoxSearch.Location = new Point(409, 82);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(19, 26);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 5;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.MouseHover += pictureBoxSearch_MouseHover;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(151, 114);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 50);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 0;
            label6.Text = "Search:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGreen;
            label7.Location = new Point(6, 5);
            label7.Name = "label7";
            label7.Size = new Size(184, 28);
            label7.TabIndex = 0;
            label7.Text = "Search Student";
            // 
            // tabPageUDStudent
            // 
            tabPageUDStudent.Controls.Add(comboBoxClassUD);
            tabPageUDStudent.Controls.Add(buttonDelete);
            tabPageUDStudent.Controls.Add(panel7);
            tabPageUDStudent.Controls.Add(label10);
            tabPageUDStudent.Controls.Add(buttonUpdate);
            tabPageUDStudent.Controls.Add(panel8);
            tabPageUDStudent.Controls.Add(textBoxPassword1);
            tabPageUDStudent.Controls.Add(label11);
            tabPageUDStudent.Controls.Add(panel9);
            tabPageUDStudent.Controls.Add(textBoxEmail1);
            tabPageUDStudent.Controls.Add(label12);
            tabPageUDStudent.Controls.Add(panel10);
            tabPageUDStudent.Controls.Add(textBoxAge1);
            tabPageUDStudent.Controls.Add(label13);
            tabPageUDStudent.Controls.Add(panel11);
            tabPageUDStudent.Controls.Add(textBoxName1);
            tabPageUDStudent.Controls.Add(label14);
            tabPageUDStudent.Controls.Add(label15);
            tabPageUDStudent.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            tabPageUDStudent.Location = new Point(4, 4);
            tabPageUDStudent.Name = "tabPageUDStudent";
            tabPageUDStudent.Padding = new Padding(3);
            tabPageUDStudent.Size = new Size(1222, 827);
            tabPageUDStudent.TabIndex = 2;
            tabPageUDStudent.Text = "Update and Delete";
            tabPageUDStudent.UseVisualStyleBackColor = true;
            tabPageUDStudent.Leave += tabPageUDStudent_Leave;
            // 
            // comboBoxClassUD
            // 
            comboBoxClassUD.Anchor = AnchorStyles.None;
            comboBoxClassUD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClassUD.FlatStyle = FlatStyle.Flat;
            comboBoxClassUD.FormattingEnabled = true;
            comboBoxClassUD.Location = new Point(109, 413);
            comboBoxClassUD.Name = "comboBoxClassUD";
            comboBoxClassUD.Size = new Size(270, 37);
            comboBoxClassUD.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.DarkRed;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(722, 414);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(113, 37);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(112, 449);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 0;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(109, 382);
            label10.Name = "label10";
            label10.Size = new Size(84, 29);
            label10.TabIndex = 0;
            label10.Text = "Class:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.Wheat;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Location = new Point(562, 414);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 37);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(562, 362);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 0;
            // 
            // textBoxPassword1
            // 
            textBoxPassword1.Anchor = AnchorStyles.None;
            textBoxPassword1.BorderStyle = BorderStyle.None;
            textBoxPassword1.Location = new Point(562, 336);
            textBoxPassword1.Name = "textBoxPassword1";
            textBoxPassword1.Size = new Size(270, 31);
            textBoxPassword1.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(562, 304);
            label11.Name = "label11";
            label11.Size = new Size(134, 29);
            label11.TabIndex = 0;
            label11.Text = "Password:";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = Color.LightGray;
            panel9.Location = new Point(115, 362);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 0;
            // 
            // textBoxEmail1
            // 
            textBoxEmail1.Anchor = AnchorStyles.None;
            textBoxEmail1.BorderStyle = BorderStyle.None;
            textBoxEmail1.Location = new Point(115, 335);
            textBoxEmail1.Name = "textBoxEmail1";
            textBoxEmail1.Size = new Size(270, 31);
            textBoxEmail1.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(112, 304);
            label12.Name = "label12";
            label12.Size = new Size(85, 29);
            label12.TabIndex = 0;
            label12.Text = "Email:";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.LightGray;
            panel10.Location = new Point(565, 276);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 2);
            panel10.TabIndex = 0;
            // 
            // textBoxAge1
            // 
            textBoxAge1.Anchor = AnchorStyles.None;
            textBoxAge1.BorderStyle = BorderStyle.None;
            textBoxAge1.Location = new Point(562, 249);
            textBoxAge1.Name = "textBoxAge1";
            textBoxAge1.Size = new Size(270, 31);
            textBoxAge1.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(562, 218);
            label13.Name = "label13";
            label13.Size = new Size(71, 29);
            label13.TabIndex = 0;
            label13.Text = "Age:";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.BackColor = Color.LightGray;
            panel11.Location = new Point(115, 277);
            panel11.Name = "panel11";
            panel11.Size = new Size(270, 2);
            panel11.TabIndex = 0;
            // 
            // textBoxName1
            // 
            textBoxName1.Anchor = AnchorStyles.None;
            textBoxName1.BorderStyle = BorderStyle.None;
            textBoxName1.Location = new Point(115, 251);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(270, 31);
            textBoxName1.TabIndex = 0;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(112, 220);
            label14.Name = "label14";
            label14.Size = new Size(94, 29);
            label14.TabIndex = 0;
            label14.Text = "Name:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Bisque;
            label15.Location = new Point(6, 5);
            label15.Name = "label15";
            label15.Size = new Size(201, 29);
            label15.TabIndex = 0;
            label15.Text = "Update Student";
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddStudent);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Name = "UserControlAddStudent";
            Size = new Size(1230, 867);
            tabControlAddStudent.ResumeLayout(false);
            tabPageAddStudent.ResumeLayout(false);
            tabPageAddStudent.PerformLayout();
            tabPageSearchStudent.ResumeLayout(false);
            tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            tabPageUDStudent.ResumeLayout(false);
            tabPageUDStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private TabControl tabControlAddStudent;
        private TabPage tabPageAddStudent;
        private TabPage tabPageSearchStudent;
        private Label labelAddStudent;
        private TextBox textBoxName;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBoxEmail;
        private Label label3;
        private Panel panel2;
        private TextBox textBoxAge;
        private Label label2;
        private Panel panel4;
        private TextBox textBoxPassword;
        private Label label4;
        private Panel panel5;
        private TextBox textBoxClass;
        private Label label5;
        private Button buttonAddStudent;
        private Panel panel6;
        private TextBox textBoxSearch;
        private Label label6;
        private Label label7;
        private PictureBox pictureBoxSearch;
        private DataGridView dataGridViewStudents;
        private Label label8;
        private Label labelCountStudents;
        private TabPage tabPageUDStudent;
        private Button buttonUpdate;
        private Panel panel8;
        private TextBox textBoxPassword1;
        private Label label11;
        private Panel panel9;
        private TextBox textBoxEmail1;
        private Label label12;
        private Panel panel10;
        private TextBox textBoxAge1;
        private Label label13;
        private Panel panel11;
        private TextBox textBoxName1;
        private Label label14;
        private Label label15;
        private Button buttonDelete;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxSearch;
        private Panel panel12;
        private Label label16;
        private ComboBox comboBoxClassUD;
        private Panel panel7;
        private Label label10;
    }
}
