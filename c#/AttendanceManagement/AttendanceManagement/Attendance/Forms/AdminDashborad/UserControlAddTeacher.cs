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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceManagement.Attendance.Forms.AdminDashborad
{
    public partial class UserControlAddTeacher : UserControl
    {

        private readonly string xmlFilePath = "..\\..\\..\\xml\\SystemData.xml";

        public UserControlAddTeacher()
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
            textBoxPassword.Clear();
            textBoxAge.Clear();
            textBoxEmail.Clear();
            tabControlAddTeacher.SelectedTab = tabPageAddTeacher;
        }

        public void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxPassword1.Clear();
            textBoxAge1.Clear();
            textBoxEmail1.Clear();

        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            string namePattern = @"^.{3,}$";
            string agePattern = @"^(1[5-9]|[2-9][0-9]|30)$";
            string passwordPattern = @"^.{6,}$";

            if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                Regex.IsMatch(textBoxName.Text, namePattern) &&
                !string.IsNullOrWhiteSpace(textBoxAge.Text) &&
                Regex.IsMatch(textBoxAge.Text, agePattern) &&
                !string.IsNullOrWhiteSpace(textBoxEmail.Text) &&
                IsEmailValid(textBoxEmail.Text) &&
                !string.IsNullOrWhiteSpace(textBoxPassword.Text) &&
                Regex.IsMatch(textBoxPassword.Text, passwordPattern))
            {

                // Create a teacher object
                AttendanceManagement.AllClasses.Teacher newTeacher = new AttendanceManagement.AllClasses.Teacher
                {
                    Id = TeacherListGenerators.GenerateUniqueId(),
                    Name = textBoxName.Text,
                    Age = int.Parse(textBoxAge.Text),
                    DateOfJoining = DateTime.Now.ToString("yyyy-MM-dd"),
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
                };

                // Add the student to the XML file
                TeacherListGenerators.AddNewTeacher(newTeacher);


                MessageBox.Show("The teacher has been added successfully.");

                textBoxName.Clear();
                textBoxAge.Clear();
                textBoxEmail.Clear();
                textBoxPassword.Clear();
            }

            else
            {

                MessageBox.Show("Please fill out all items");
            }

        }

        private bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(email, pattern);
        }


        private void tabPageSearchTeacher_Enter(object sender, EventArgs e)
        {
            //Load all students from XML file
            List<User> users = LoadUserFromXML.LoadUsersFromXml(xmlFilePath);

            //View students in dataGridViewStudents
            dataGridViewTeachers.DataSource = users
                .Where(user => user.UserType == "teacher")
                .Select(user => new
                {
                    user.Id,
                    user.Name,
                    user.Age,
                    user.Email,
                    user.Password,
                    user.DateOfJoining
                })
                .ToList();


            textBoxSearch.Clear();

            labelTotalTeachers.Text = dataGridViewTeachers.Rows.Count.ToString();

        }

        private void tabPageAddTeacher_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddTeacher_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void tabControlAddTeacher_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabControlAddTeacher_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            string searchCriteria = comboBoxSearch.SelectedItem?.ToString(); // استخدام ?. للتأكد من أن القيمة ليست فارغة

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Specify the search criterion
                Func<User, bool> predicate = null;
                switch (searchCriteria)
                {
                    case "Name":
                        predicate = user => user.Name.ToLower().Contains(searchTerm.ToLower());
                        break;
                    case "Email":
                        predicate = user => user.Email.ToLower().Contains(searchTerm.ToLower());
                        break;

                    default:
                        // If nothing is selected, searches by student name
                        predicate = user => user.Name.ToLower().Contains(searchTerm.ToLower());
                        break;
                }

                // Find matching students
                List<User> filteredUsers = LoadUserFromXML.LoadUsersFromXml(xmlFilePath)
                    .Where(user => user.UserType.ToLower() == "teacher")
                    .Where(predicate)
                    .ToList();

                dataGridViewTeachers.DataSource = null;
                dataGridViewTeachers.DataSource = filteredUsers
                    .Select(user => new
                    {
                        user.Id,
                        user.Name,
                        user.Age,
                        user.Email,
                        user.Password,
                        user.DateOfJoining,
                    })
                    .ToList();
            }
            else
            {
                dataGridViewTeachers.DataSource = LoadUserFromXML.LoadUsersFromXml(xmlFilePath)
                    .Where(user => user.UserType.ToLower() == "teacher")
                    .Select(user => new
                    {
                        user.Id,
                        user.Name,
                        user.Age,
                        user.Email,
                        user.Password,
                        user.DateOfJoining,
                    })
                    .ToList();
            }
        }

        private void dataGridViewTeachers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Fill the input fields with the specified data
                textBoxName1.Text = dataGridViewTeachers.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxAge1.Text = dataGridViewTeachers.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxEmail1.Text = dataGridViewTeachers.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxPassword1.Text = dataGridViewTeachers.Rows[e.RowIndex].Cells[4].Value.ToString();
                // Switch to the edit page
                tabControlAddTeacher.SelectedTab = tabPageUDTeacher;
            }

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Update the record in the XML file
            if (dataGridViewTeachers.CurrentRow != null)
            {
                // Get updated data from input fields
                string updatedName = textBoxName1.Text;
                string updatedAge = textBoxAge1.Text;
                string updatedEmail = textBoxEmail1.Text;
                string updatedPassword = textBoxPassword1.Text;

                string namePattern = @"^.{3,}$";
                string agePattern = @"^(1[5-9]|[2-9][0-9]|30)$";
                string passwordPattern = @"^.{6,}$";

                if (!string.IsNullOrWhiteSpace(textBoxName1.Text) &&
                    Regex.IsMatch(textBoxName1.Text, namePattern) &&
                    !string.IsNullOrWhiteSpace(textBoxAge1.Text) &&
                    Regex.IsMatch(textBoxAge1.Text, agePattern) &&
                    !string.IsNullOrWhiteSpace(textBoxEmail1.Text) &&
                    IsEmailValid(textBoxEmail1.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxPassword1.Text) &&
                    Regex.IsMatch(textBoxPassword1.Text, passwordPattern))
                {
                    AttendanceManagement.AllClasses.Teacher updatedTeacher = new AttendanceManagement.AllClasses.Teacher
                    {
                        Id = int.Parse(dataGridViewTeachers.CurrentRow.Cells["Id"].Value.ToString()),
                        Name = updatedName,
                        Age = int.Parse(updatedAge),
                        Email = updatedEmail,
                        Password = updatedPassword
                    };

                    TeacherListGenerators.UpdateTeacher(updatedTeacher);

                    MessageBox.Show("The data has been updated successfully.");

                    ClearTextBox1();

                    tabControlAddTeacher.SelectedTab = tabPageSearchTeacher;

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
            if (dataGridViewTeachers.CurrentRow != null && dataGridViewTeachers.CurrentRow.Index != -1 && textBoxName1.Text != "")
            {
                int teacherId = int.Parse(dataGridViewTeachers.CurrentRow.Cells["Id"].Value.ToString());

                TeacherListGenerators.DeleteTeacher(teacherId);

                tabControlAddTeacher.SelectedTab = tabPageSearchTeacher;
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.");
            }
        }

        
    }
}
