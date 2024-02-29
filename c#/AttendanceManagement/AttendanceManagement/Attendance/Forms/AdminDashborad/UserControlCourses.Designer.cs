namespace AttendanceManagement.Attendance.Forms.AdminDashborad
{
    partial class UserControlCourses
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
            tabControlAddCourse = new TabControl();
            tabPageAddCourse = new TabPage();
            buttonAddCoure = new Button();
            textBoxDetails = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBoxName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            textBoxID = new TextBox();
            label1 = new Label();
            labelAdd = new Label();
            tabPageSearchCourse = new TabPage();
            labelCountCoures = new Label();
            label8 = new Label();
            dataGridViewCourses = new DataGridView();
            textBoxSearch = new TextBox();
            pictureBoxSearch = new PictureBox();
            panel6 = new Panel();
            label6 = new Label();
            label7 = new Label();
            tabPageUDCourse = new TabPage();
            textBoxDetails1 = new TextBox();
            textBoxName1 = new TextBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label12 = new Label();
            panel10 = new Panel();
            label13 = new Label();
            panel11 = new Panel();
            textBoxID1 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            toolTip = new ToolTip(components);
            tabControlAddCourse.SuspendLayout();
            tabPageAddCourse.SuspendLayout();
            tabPageSearchCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            tabPageUDCourse.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddCourse
            // 
            tabControlAddCourse.Alignment = TabAlignment.Bottom;
            tabControlAddCourse.Controls.Add(tabPageAddCourse);
            tabControlAddCourse.Controls.Add(tabPageSearchCourse);
            tabControlAddCourse.Controls.Add(tabPageUDCourse);
            tabControlAddCourse.Dock = DockStyle.Fill;
            tabControlAddCourse.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            tabControlAddCourse.Location = new Point(0, 0);
            tabControlAddCourse.Name = "tabControlAddCourse";
            tabControlAddCourse.SelectedIndex = 0;
            tabControlAddCourse.Size = new Size(1230, 867);
            tabControlAddCourse.TabIndex = 2;
            tabControlAddCourse.Leave += tabControlAddCourse_Leave;
            // 
            // tabPageAddCourse
            // 
            tabPageAddCourse.Controls.Add(buttonAddCoure);
            tabPageAddCourse.Controls.Add(textBoxDetails);
            tabPageAddCourse.Controls.Add(label3);
            tabPageAddCourse.Controls.Add(panel2);
            tabPageAddCourse.Controls.Add(textBoxName);
            tabPageAddCourse.Controls.Add(label2);
            tabPageAddCourse.Controls.Add(panel1);
            tabPageAddCourse.Controls.Add(textBoxID);
            tabPageAddCourse.Controls.Add(label1);
            tabPageAddCourse.Controls.Add(labelAdd);
            tabPageAddCourse.Location = new Point(4, 4);
            tabPageAddCourse.Name = "tabPageAddCourse";
            tabPageAddCourse.Padding = new Padding(3);
            tabPageAddCourse.Size = new Size(1222, 827);
            tabPageAddCourse.TabIndex = 0;
            tabPageAddCourse.Text = "Add Course";
            tabPageAddCourse.UseVisualStyleBackColor = true;
            tabPageAddCourse.Leave += tabPageAddCourse_Leave;
            // 
            // buttonAddCoure
            // 
            buttonAddCoure.Anchor = AnchorStyles.None;
            buttonAddCoure.BackColor = Color.LightBlue;
            buttonAddCoure.FlatAppearance.BorderSize = 0;
            buttonAddCoure.FlatStyle = FlatStyle.Flat;
            buttonAddCoure.Location = new Point(657, 435);
            buttonAddCoure.Name = "buttonAddCoure";
            buttonAddCoure.Size = new Size(113, 37);
            buttonAddCoure.TabIndex = 0;
            buttonAddCoure.Text = "Add";
            buttonAddCoure.UseVisualStyleBackColor = false;
            buttonAddCoure.Click += buttonAddCoure_Click;
            // 
            // textBoxDetails
            // 
            textBoxDetails.Anchor = AnchorStyles.None;
            textBoxDetails.BorderStyle = BorderStyle.None;
            textBoxDetails.Location = new Point(207, 356);
            textBoxDetails.Multiline = true;
            textBoxDetails.Name = "textBoxDetails";
            textBoxDetails.Size = new Size(421, 116);
            textBoxDetails.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(207, 325);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 0;
            label3.Text = "Details:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(660, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Location = new Point(657, 270);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 29);
            textBoxName.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(657, 239);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(210, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 0;
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.None;
            textBoxID.BorderStyle = BorderStyle.None;
            textBoxID.Location = new Point(210, 272);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(270, 29);
            textBoxID.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(207, 241);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.BackColor = Color.LightSkyBlue;
            labelAdd.Location = new Point(12, 11);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(151, 28);
            labelAdd.TabIndex = 0;
            labelAdd.Text = "Add Course";
            // 
            // tabPageSearchCourse
            // 
            tabPageSearchCourse.Controls.Add(labelCountCoures);
            tabPageSearchCourse.Controls.Add(label8);
            tabPageSearchCourse.Controls.Add(dataGridViewCourses);
            tabPageSearchCourse.Controls.Add(textBoxSearch);
            tabPageSearchCourse.Controls.Add(pictureBoxSearch);
            tabPageSearchCourse.Controls.Add(panel6);
            tabPageSearchCourse.Controls.Add(label6);
            tabPageSearchCourse.Controls.Add(label7);
            tabPageSearchCourse.Location = new Point(4, 4);
            tabPageSearchCourse.Name = "tabPageSearchCourse";
            tabPageSearchCourse.Padding = new Padding(3);
            tabPageSearchCourse.Size = new Size(1222, 827);
            tabPageSearchCourse.TabIndex = 1;
            tabPageSearchCourse.Text = "Search Course";
            tabPageSearchCourse.UseVisualStyleBackColor = true;
            tabPageSearchCourse.Enter += tabPageSearchCourse_Enter;
            // 
            // labelCountCoures
            // 
            labelCountCoures.AutoSize = true;
            labelCountCoures.Font = new Font("Century Gothic", 12F);
            labelCountCoures.Location = new Point(1187, 766);
            labelCountCoures.Name = "labelCountCoures";
            labelCountCoures.Size = new Size(35, 23);
            labelCountCoures.TabIndex = 0;
            labelCountCoures.Text = "(0)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1015, 763);
            label8.Name = "label8";
            label8.Size = new Size(162, 28);
            label8.TabIndex = 0;
            label8.Text = "Total Coures:";
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.AllowUserToAddRows = false;
            dataGridViewCourses.AllowUserToDeleteRows = false;
            dataGridViewCourses.AllowUserToResizeColumns = false;
            dataGridViewCourses.AllowUserToResizeRows = false;
            dataGridViewCourses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCourses.BackgroundColor = Color.White;
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(25, 137);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCourses.ShowCellErrors = false;
            dataGridViewCourses.ShowEditingIcon = false;
            dataGridViewCourses.ShowRowErrors = false;
            dataGridViewCourses.Size = new Size(1178, 620);
            dataGridViewCourses.TabIndex = 0;
            dataGridViewCourses.CellDoubleClick += dataGridViewCourses_CellDoubleClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Location = new Point(192, 77);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(252, 29);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Image = Properties.Resources.search;
            pictureBoxSearch.Location = new Point(450, 76);
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
            panel6.Location = new Point(192, 108);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 50);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 0;
            label6.Text = "Search:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightGreen;
            label7.Location = new Point(12, 11);
            label7.Name = "label7";
            label7.Size = new Size(181, 28);
            label7.TabIndex = 0;
            label7.Text = "Search Course";
            // 
            // tabPageUDCourse
            // 
            tabPageUDCourse.Controls.Add(textBoxDetails1);
            tabPageUDCourse.Controls.Add(textBoxName1);
            tabPageUDCourse.Controls.Add(buttonDelete);
            tabPageUDCourse.Controls.Add(buttonUpdate);
            tabPageUDCourse.Controls.Add(label12);
            tabPageUDCourse.Controls.Add(panel10);
            tabPageUDCourse.Controls.Add(label13);
            tabPageUDCourse.Controls.Add(panel11);
            tabPageUDCourse.Controls.Add(textBoxID1);
            tabPageUDCourse.Controls.Add(label14);
            tabPageUDCourse.Controls.Add(label15);
            tabPageUDCourse.Font = new Font("Century Gothic", 15F, FontStyle.Bold);
            tabPageUDCourse.Location = new Point(4, 4);
            tabPageUDCourse.Name = "tabPageUDCourse";
            tabPageUDCourse.Padding = new Padding(3);
            tabPageUDCourse.Size = new Size(1222, 827);
            tabPageUDCourse.TabIndex = 2;
            tabPageUDCourse.Text = "Update and Delete";
            tabPageUDCourse.UseVisualStyleBackColor = true;
            // 
            // textBoxDetails1
            // 
            textBoxDetails1.Anchor = AnchorStyles.None;
            textBoxDetails1.BorderStyle = BorderStyle.None;
            textBoxDetails1.Location = new Point(207, 331);
            textBoxDetails1.Multiline = true;
            textBoxDetails1.Name = "textBoxDetails1";
            textBoxDetails1.Size = new Size(421, 116);
            textBoxDetails1.TabIndex = 2;
            // 
            // textBoxName1
            // 
            textBoxName1.Anchor = AnchorStyles.None;
            textBoxName1.BorderStyle = BorderStyle.None;
            textBoxName1.Location = new Point(657, 239);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(270, 31);
            textBoxName1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.BackColor = Color.DarkRed;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(817, 409);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(113, 37);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.None;
            buttonUpdate.BackColor = Color.Wheat;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Location = new Point(657, 409);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 37);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(207, 299);
            label12.Name = "label12";
            label12.Size = new Size(101, 29);
            label12.TabIndex = 0;
            label12.Text = "Details:";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.BackColor = Color.LightGray;
            panel10.Location = new Point(660, 271);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 2);
            panel10.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(657, 213);
            label13.Name = "label13";
            label13.Size = new Size(94, 29);
            label13.TabIndex = 0;
            label13.Text = "Name:";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.BackColor = Color.LightGray;
            panel11.Location = new Point(210, 272);
            panel11.Name = "panel11";
            panel11.Size = new Size(270, 2);
            panel11.TabIndex = 0;
            // 
            // textBoxID1
            // 
            textBoxID1.Anchor = AnchorStyles.None;
            textBoxID1.BorderStyle = BorderStyle.None;
            textBoxID1.Location = new Point(210, 246);
            textBoxID1.Name = "textBoxID1";
            textBoxID1.Size = new Size(270, 31);
            textBoxID1.TabIndex = 0;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(207, 215);
            label14.Name = "label14";
            label14.Size = new Size(45, 29);
            label14.TabIndex = 0;
            label14.Text = "ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Bisque;
            label15.Location = new Point(12, 11);
            label15.Name = "label15";
            label15.Size = new Size(196, 29);
            label15.TabIndex = 0;
            label15.Text = "Update Course";
            // 
            // UserControlCourses
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddCourse);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            Margin = new Padding(0);
            Name = "UserControlCourses";
            Size = new Size(1230, 867);
            tabControlAddCourse.ResumeLayout(false);
            tabPageAddCourse.ResumeLayout(false);
            tabPageAddCourse.PerformLayout();
            tabPageSearchCourse.ResumeLayout(false);
            tabPageSearchCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            tabPageUDCourse.ResumeLayout(false);
            tabPageUDCourse.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddCourse;
        private TabPage tabPageAddCourse;
        private Button buttonAddCoure;
        private TextBox textBoxDetails;
        private Label label3;
        private Panel panel2;
        private TextBox textBoxName;
        private Label label2;
        private Panel panel1;
        private TextBox textBoxID;
        private Label label1;
        private Label labelAdd;
        private TabPage tabPageSearchCourse;
        private Label labelCountCoures;
        private Label label8;
        private DataGridView dataGridViewCourses;
        private TextBox textBoxSearch;
        private PictureBox pictureBoxSearch;
        private Panel panel6;
        private Label label6;
        private Label label7;
        private TabPage tabPageUDCourse;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label12;
        private Panel panel10;
        private Label label13;
        private Panel panel11;
        private TextBox textBoxID1;
        private Label label14;
        private Label label15;
        private ToolTip toolTip;
        private TextBox textBoxDetails1;
        private TextBox textBoxName1;
    }
}
