using AttendanceManagement.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceManagement.Attendance.Forms.AdminDashborad
{
    public partial class UserControlCourses : UserControl
    {
        private readonly string xmlFilePath = "..\\..\\..\\xml\\SystemData.xml";

        public UserControlCourses()
        {
            InitializeComponent();
        }


        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }

        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxID.Clear();
            textBoxDetails.Clear();
            tabControlAddCourse.SelectedTab = tabPageAddCourse;
        }

        public void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxID1.Clear();
            textBoxDetails1.Clear();

        }

        private void buttonAddCoure_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(textBoxID.Text) && int.TryParse(textBoxID.Text, out int courseId) && courseId > 100 && !string.IsNullOrWhiteSpace(textBoxName.Text) && textBoxName.Text.Length >= 3 && !string.IsNullOrWhiteSpace(textBoxDetails.Text) && textBoxDetails.Text.Length >= 3)
            {

                // Create a teacher object
                Courses newCourse = new Courses
                {
                    ID = int.Parse(textBoxID.Text),
                    Name = textBoxName.Text,
                    Details = textBoxDetails.Text

                };

                // Add the student to the XML file
                CourseOperations.AddNewCourse(newCourse);


                MessageBox.Show("The Course has been added successfully.");

                textBoxName.Clear();
                textBoxID.Clear();
                textBoxDetails.Clear();
            }

            else
            {

                MessageBox.Show("Please fill out all items");
            }

        }



        private void tabPageSearchCourse_Enter(object sender, EventArgs e)
        {
            // تحميل الكورسات من ملف XML
            List<Courses> courses = CourseOperations.LoadCoursesFromXml();

            // عرض الكورسات في DataGridView
            dataGridViewCourses.DataSource = courses;

            // عرض عدد الكورسات في Label
            labelCountCoures.Text = courses.Count.ToString();
        }

        private void tabPageAddCourse_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddCourse_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }


        private void tabControlAddCourse_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower(); // تحويل النص المدخل إلى حالة صغيرة

            // تحميل الكورسات من ملف XML
            List<Courses> courses = CourseOperations.LoadCoursesFromXml();

            // فلترة الكورسات بناءً على الاسم
            List<Courses> filteredCourses = courses
                .Where(course => course.Name.ToLower().Contains(searchText))
                .ToList();

            // عرض الكورسات المفلترة في DataGridView
            dataGridViewCourses.DataSource = filteredCourses;

            // عرض عدد الكورسات في Label
            labelCountCoures.Text = filteredCourses.Count.ToString();
        }



        private void dataGridViewCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Fill the input fields with the specified data
                textBoxID1.Text = dataGridViewCourses.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                textBoxName1.Text = dataGridViewCourses.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBoxDetails1.Text = dataGridViewCourses.Rows[e.RowIndex].Cells["Details"].Value.ToString();
                // Switch to the edit page
                tabControlAddCourse.SelectedTab = tabPageUDCourse;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Update the record in the XML file
            if (dataGridViewCourses.CurrentRow != null)
            {
                // Get updated data from input fields
                string updatedID = textBoxID1.Text;
                string updatedName = textBoxName1.Text;
                string updatedDetails = textBoxDetails1.Text;


                if(textBoxName1.Text != "")
                {
                    Courses updatedCourse = new Courses
                    {
                        ID = int.Parse(dataGridViewCourses.CurrentRow.Cells["ID"].Value.ToString()),
                        Name = updatedName,
                        Details = updatedDetails

                    };

                    CourseOperations.UpdateCourse(updatedCourse);

                    MessageBox.Show("The data has been updated successfully.");

                    ClearTextBox1();

                    tabControlAddCourse.SelectedTab = tabPageSearchCourse;

                }
                else
                {
                    MessageBox.Show("Please verify that the entered data is correct.");
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.CurrentRow != null && dataGridViewCourses.CurrentRow.Index != -1 && textBoxName1.Text != "")
            {
                int courseId = int.Parse(dataGridViewCourses.CurrentRow.Cells["Id"].Value.ToString());

                CourseOperations.DeleteCourse(courseId);

                tabControlAddCourse.SelectedTab = tabPageSearchCourse;
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

     
    }
}
