namespace AttendanceManagement.Attendance.Forms.AdminDashborad
{
    partial class UserControlAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdmin));
            panelTotalTeachers = new Panel();
            labelTotalTeachers = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            labelTotalStudents = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            labelTotalCoures = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panelTotalTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelTotalTeachers
            // 
            resources.ApplyResources(panelTotalTeachers, "panelTotalTeachers");
            panelTotalTeachers.BackColor = Color.LightSalmon;
            panelTotalTeachers.Controls.Add(labelTotalTeachers);
            panelTotalTeachers.Controls.Add(label1);
            panelTotalTeachers.Controls.Add(pictureBox1);
            panelTotalTeachers.Name = "panelTotalTeachers";
            panelTotalTeachers.UseWaitCursor = true;
            // 
            // labelTotalTeachers
            // 
            resources.ApplyResources(labelTotalTeachers, "labelTotalTeachers");
            labelTotalTeachers.Name = "labelTotalTeachers";
            labelTotalTeachers.UseWaitCursor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.teacher5;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(labelTotalStudents);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Name = "panel1";
            panel1.UseWaitCursor = true;
            // 
            // labelTotalStudents
            // 
            resources.ApplyResources(labelTotalStudents, "labelTotalStudents");
            labelTotalStudents.Name = "labelTotalStudents";
            labelTotalStudents.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.reading2;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.Violet;
            panel2.Controls.Add(labelTotalCoures);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox3);
            panel2.Name = "panel2";
            panel2.UseWaitCursor = true;
            // 
            // labelTotalCoures
            // 
            resources.ApplyResources(labelTotalCoures, "labelTotalCoures");
            labelTotalCoures.Name = "labelTotalCoures";
            labelTotalCoures.UseWaitCursor = true;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            label5.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Image = Properties.Resources.homework1;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // UserControlAdmin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelTotalTeachers);
            Name = "UserControlAdmin";
            UseWaitCursor = true;
            Load += UserControlAdmin_Load;
            panelTotalTeachers.ResumeLayout(false);
            panelTotalTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTotalTeachers;
        private PictureBox pictureBox1;
        private Label labelTotalTeachers;
        private Label label1;
        private Panel panel1;
        private Label labelTotalStudents;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label labelTotalCoures;
        private Label label5;
        private PictureBox pictureBox3;
    }
}
