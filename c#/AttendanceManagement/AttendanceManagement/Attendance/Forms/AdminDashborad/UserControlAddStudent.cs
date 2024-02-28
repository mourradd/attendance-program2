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
using AttendanceManagement.AllClasses;



namespace AttendanceManagement.Attendance.Forms.AdminDashborad
{
    public partial class UserControlAddStudent : UserControl
    {
       

        private readonly string xmlFilePath = "C:\\Users\\lap0\\OneDrive\\Desktop\\MainFinal\\attendance-program2\\c#\\AttendanceManagement\\AttendanceManagement\\xml\\SystemData.xml";
        public UserControlAddStudent()
        {
            InitializeComponent();
            LoadClassesIntoComboBox();
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
            comboBoxClass.SelectedIndex = -1;
            tabControlAddStudent.SelectedTab = tabPageAddStudent;
        }

        public void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxPassword1.Clear();
            textBoxAge1.Clear();
            textBoxEmail1.Clear();
            comboBoxClassUD.SelectedIndex = -1;
            
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
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
                Regex.IsMatch(textBoxPassword.Text, passwordPattern) &&
                comboBoxClass.SelectedItem != null)
            {
                // Get the name of the specified class from ComboBox
                string className = comboBoxClass.SelectedItem.ToString();

                // Gets the class ID based on the given class name
                string classId = Classes.GetClassIdByName(className);

               
                if (!string.IsNullOrEmpty(classId))
                {
                    // Create a student object
                    AttendanceManagement.AllClasses.Student newStudent = new AttendanceManagement.AllClasses.Student
                    {
                        Id = StudentsListGenerators.GenerateUniqueId(),
                        Name = textBoxName.Text,
                        Age = int.Parse(textBoxAge.Text),
                        DateOfJoining = DateTime.Now.ToString("yyyy-MM-dd"),
                        Email = textBoxEmail.Text,
                        Password = textBoxPassword.Text,
                        ClassID = int.Parse(classId)
                    };

                    // Add the student to the XML file
                    StudentsListGenerators.AddNewStudent(newStudent);

                    
                    MessageBox.Show("The student has been added successfully.");

                    textBoxName.Clear();
                    textBoxAge.Clear();
                    textBoxEmail.Clear();
                    textBoxPassword.Clear();
                    comboBoxClass.SelectedIndex = -1; 
                }
                else
                {
                    
                    MessageBox.Show("The category ID cannot be found.");
                }
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



        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
            //Load all students from XML file
            List<User> users = LoadUserFromXML.LoadUsersFromXml(xmlFilePath);

            //View students in dataGridViewStudents
            dataGridViewStudents.DataSource = users
                .Where(user => user.UserType == "student")
                .Select(user => new
                {
                    user.Id,
                    user.Name,
                    user.Age,
                    user.Email,
                    user.Password,
                    user.DateOfJoining,
                    ClassName = GetClassNameById(user.ClassID)
                })
                .ToList();

            
            textBoxSearch.Clear();
            comboBoxSearch.SelectedIndex = -1;

            labelCountStudents.Text = dataGridViewStudents.Rows.Count.ToString();

        }


        private string GetClassNameById(string classId)
        {
            XDocument doc = XDocument.Load(xmlFilePath);

            // Search for the item that has the specified ID
            XElement classElement = doc.Descendants("Class")
                                       .FirstOrDefault(e => e.Element("id").Value == classId);

            if (classElement != null)
            {
                // If the element exists, retrieve the class name
                return classElement.Element("name").Value;
            }
            else
            {
                return string.Empty;
            }
        }


        private void tabPageAddStudent_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void tabControlAddStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            //comboBoxClass.Items.Clear();
            //LoadClassesIntoComboBox();

        }


        private void LoadClassesIntoComboBox()
        {
            try
            {
                // Load the XML file
                XDocument doc = XDocument.Load(xmlFilePath);

                // Get the list of classes
                List<string> classes = new List<string>();
                foreach (XElement classElement in doc.Descendants("Class"))
                {
                    string className = (string)classElement.Element("name");
                    classes.Add(className);
                }

                // Add classes to the ComboBox
                comboBoxClassUD.Items.AddRange(classes.ToArray());

                comboBoxClass.Items.AddRange(classes.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message);
            }
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
                    case "Class":
                        XDocument doc = XDocument.Load(xmlFilePath);

                        predicate = user =>
                        {
                            XElement classElement = doc.Descendants("Class")
                                .FirstOrDefault(e => e.Element("id").Value == user.ClassID);

                            string className = classElement?.Element("name")?.Value ?? "";
                            return className.ToLower().Contains(searchTerm.ToLower());
                        };
                        break;
                    default:
                        // If nothing is selected, searches by student name
                        predicate = user => user.Name.ToLower().Contains(searchTerm.ToLower());
                        break;
                }

                // Find matching students
                List<User> filteredUsers = LoadUserFromXML.LoadUsersFromXml(xmlFilePath)
                    .Where(user => user.UserType.ToLower() == "student") 
                    .Where(predicate) 
                    .ToList();

                dataGridViewStudents.DataSource = null; 
                dataGridViewStudents.DataSource = filteredUsers
                    .Select(user => new
                    {
                        user.Id,
                        user.Name,
                        user.Age,
                        user.Email,
                        user.Password,
                        user.DateOfJoining,
                        ClassName = GetClassNameById(user.ClassID)
                    })
                    .ToList();
            }
            else
            {
                dataGridViewStudents.DataSource = LoadUserFromXML.LoadUsersFromXml(xmlFilePath)
                    .Where(user => user.UserType.ToLower() == "student") 
                    .Select(user => new
                    {
                        user.Id,
                        user.Name,
                        user.Age,
                        user.Email,
                        user.Password,
                        user.DateOfJoining,
                        ClassName = GetClassNameById(user.ClassID)
                    })
                    .ToList();
            }
        }



        private void comboBoxSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.Focus();
        }

        private void comboBoxClassUD_Click(object sender, EventArgs e)
        {
            comboBoxClassUD.Items.Clear();
            LoadClassesIntoComboBox();

        }



        private void tabPageUDStudent_Leave(object sender, EventArgs e)
        {

            ClearTextBox1();
        }




        private void dataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Fill the input fields with the specified data
                textBoxName1.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxAge1.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxEmail1.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxPassword1.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxClassUD.SelectedItem = dataGridViewStudents.Rows[e.RowIndex].Cells[6].Value.ToString();
                // Switch to the edit page
                tabControlAddStudent.SelectedTab = tabPageUDStudent;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Update the record in the XML file
            if (dataGridViewStudents.CurrentRow != null)
            {
                // Get updated data from input fields
                string updatedName = textBoxName1.Text;
                string updatedAge = textBoxAge1.Text;
                string updatedEmail = textBoxEmail1.Text;
                string updatedPassword = textBoxPassword1.Text;
                string updatedClass = comboBoxClassUD.SelectedItem?.ToString();

                string updatedClassId = Classes.GetClassIdByName(updatedClass);

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
                    Regex.IsMatch(textBoxPassword1.Text, passwordPattern) &&
                    comboBoxClassUD.SelectedItem != null)
                {
                    AttendanceManagement.AllClasses.Student updatedStudent = new AttendanceManagement.AllClasses.Student
                    {
                        Id = int.Parse(dataGridViewStudents.CurrentRow.Cells["Id"].Value.ToString()),
                        Name = updatedName,
                        Age = int.Parse(updatedAge),
                        Email = updatedEmail,
                        Password = updatedPassword,
                        ClassID = int.Parse(updatedClass)
                    };

                    StudentsListGenerators.UpdateStudent(updatedStudent);

                    MessageBox.Show("The data has been updated successfully.");

                    ClearTextBox1();

                    tabControlAddStudent.SelectedTab = tabPageSearchStudent;

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
            if (dataGridViewStudents.CurrentRow != null && dataGridViewStudents.CurrentRow.Index != -1 && textBoxName1.Text !="")
            {
                int studentId = int.Parse(dataGridViewStudents.CurrentRow.Cells["Id"].Value.ToString());

                StudentsListGenerators.DeleteStudent(studentId);

                tabControlAddStudent.SelectedTab = tabPageSearchStudent;
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }



        private void tabPageAddStudent_Click(object sender, EventArgs e)
        {

        }

    }
}

