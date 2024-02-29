using AttendanceManagement.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;


namespace AttendanceManagement.Attendance.Teacher
{
    public partial class UserControlAttendance : UserControl
    {
        
        private string userName;

        public UserControlAttendance(string user)
        {
            InitializeComponent();
            userName = user;
            
           
           

        }
        private void TAttendanceGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // on click switch between true or flase values
            if (TAttendanceGridView1.CurrentCell.Value == null)
            {
                TAttendanceGridView1.CurrentCell.Value = true;
            }
            else if (TAttendanceGridView1.CurrentCell.Value.ToString() == "True")
            {
                TAttendanceGridView1.CurrentCell.Value = false;
            }
            else
            {
                TAttendanceGridView1.CurrentCell.Value = true;
            }

            // Check if the clicked cell is in the "status" column
            if (e.ColumnIndex == TAttendanceGridView1.Columns["status"].Index && e.RowIndex != -1)
            {
                int lastRowIndex = TAttendanceGridView1.Rows.Count - 1;

                // Check if the clicked row is not the last row
                if (e.RowIndex != lastRowIndex)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)TAttendanceGridView1.Rows[e.RowIndex].Cells["status"];

                    // Retrieve the value of the status checkbox
                    bool statusValue = Convert.ToBoolean(checkBoxCell.Value);

                    // Update the status_written column based on the checkbox value
                    TAttendanceGridView1.Rows[e.RowIndex].Cells["status_written"].Value = statusValue ? "Present" : "Absent";
                }
            }
            // Check if attendance for the current date exists
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            if (IsAttendanceAlreadySaved(currentDate))
            {
                MessageBox.Show("Attendance for the current date already exists. You cannot modify it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




        }

        private void UpdateStatusWrittenColumn(string date, string courseId)
        {
            string filePath = "..\\..\\..\\xml\\SystemData.xml";

            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);

                // Check if attendance for the selected date exists
                if (IsAttendanceAlreadySaved(date))
                {
                    // Iterate through the DataGridView rows
                    foreach (DataGridViewRow row in TAttendanceGridView1.Rows)
                    {
                        string studentName = row.Cells["Student_name"].Value?.ToString();

                        // If student name is not empty
                        if (!string.IsNullOrEmpty(studentName))
                        {
                            // Check if the student ID is in attendance tag
                            string studentId = GetStudentIdByName(studentName, xmlDoc);
                            if (studentId != null)
                            {
                                // Check if the student ID exists in the attendance tag for the selected date
                                bool isAbsent = IsStudentAbsent(date, courseId, studentId);

                                // If the student is marked as absent and the checkbox is checked, update it
                                if (isAbsent && Convert.ToBoolean(row.Cells["status"].Value))
                                {
                                    row.Cells["status"].Value = false;
                                    row.Cells["status_written"].Value = "Absent";
                                }
                            }
                        }
                    }
                }
                else
                {
                    // If attendance for the selected date doesn't exist, ensure checkboxes are unchecked and status is set to "Absent"
                    foreach (DataGridViewRow row in TAttendanceGridView1.Rows)
                    {
                        row.Cells["status"].Value = false;
                        row.Cells["status_written"].Value = "Absent";
                    }
                }

                // Set the readonly property of the status_written column to true
                TAttendanceGridView1.Columns["status_written"].ReadOnly = true;

                // Set the readonly property of the checkbox cells to true
                foreach (DataGridViewRow row in TAttendanceGridView1.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["status"] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null)
                    {
                        checkBoxCell.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating status written column: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserControlAttendance_Load(object sender, EventArgs e)
        {
            DataBindings.Clear();
            TAttendanceGridView1.DataSource = null;
            //dateTimePicker1.Value = new DateTime(2024, 02, 20);
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\xml\\SystemData.xml");

            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedCourseName = CompoCourse.SelectedItem?.ToString() ?? "";
            string selectedCourseId = GetCourseIdByName(selectedCourseName);


            XmlNode Target_Teacher = doc.SelectSingleNode($"/attendance_system/users/teachers/teacher[name=\"{userName}\"]");
            string? teacherId = Target_Teacher.SelectSingleNode("id").InnerText;

            HashSet<string> uniqueCourses = new HashSet<string>();
            HashSet<string> uniqueClasses = new HashSet<string>();

            XmlNodeList coursesForTeacher = doc.SelectNodes($"/attendance_system/ClassesCourses/ClassCourses/courses/course[teacher_id=\"{teacherId}\"]");
            foreach (XmlNode course in coursesForTeacher)
            {
                string Id = course.SelectSingleNode("id").InnerText;
                XmlNode courseNode = doc.SelectSingleNode($"/attendance_system/courses/course[id=\"{Id}\"]/name");
                string? CourseName = courseNode.InnerText;

                // Add course name if it's not already added
                if (!uniqueCourses.Contains(CourseName))
                {
                    CompoCourse.Items.Add(CourseName);
                    uniqueCourses.Add(CourseName);
                }

                XmlNodeList ClassesIDs = doc.SelectNodes($"/attendance_system/ClassesCourses/ClassCourses/courses/course[id=\"{Id}\"]/../../Class_id");

                foreach (XmlNode classId in ClassesIDs)
                {
                    string className = doc.SelectSingleNode($"/attendance_system/Classes/Class[id=\"{classId.InnerText}\"]/name").InnerText;

                    // Add class name if it's not already added
                    if (!uniqueClasses.Contains(className))
                    {
                        CompoClass.Items.Add(className);
                        uniqueClasses.Add(className);
                    }
                }
            }

            CompoClass.SelectedIndex = 0;
            CompoCourse.SelectedIndex = 0;

            UpdateAttendanceData();

        }
        private void CompoCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompoClass_SelectedIndexChanged(sender, e);
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedCourseName = CompoCourse.SelectedItem?.ToString() ?? "";
            string selectedCourseId = GetCourseIdByName(selectedCourseName);

            UpdateAttendanceData();



        }

        private void CompoClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            TAttendanceGridView1.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\..\\xml\\SystemData.xml");

            string teacherName = "Naser"; // Example teacher name, replace with actual selected teacher's name

            // Get the teacher id from the teacher name
            XmlNode targetTeacher = doc.SelectSingleNode($"/attendance_system/users/teachers/teacher[name='{teacherName}']");
            if (targetTeacher != null)
            {
                string teacherId = targetTeacher.SelectSingleNode("id").InnerText;

                string classFromCompo = CompoClass.SelectedItem?.ToString();
                string courseFromCompo = CompoCourse.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(courseFromCompo) && !string.IsNullOrEmpty(classFromCompo))
                {
                    XmlNode currentClassId = doc.SelectSingleNode($"/attendance_system/Classes/Class[name='{classFromCompo}']/id");
                    XmlNode currentCourseId = doc.SelectSingleNode($"/attendance_system/courses/course[name='{courseFromCompo}']/id");

                    // Check if the current course is assigned to the current class and teacher
                    XmlNode actualCourse = doc.SelectSingleNode($"/attendance_system/ClassesCourses/ClassCourses[Class_id='{currentClassId.InnerText}']/courses/course[teacher_id='{teacherId}' and id='{currentCourseId.InnerText}']");

                    if (actualCourse != null)
                    {
                        // Retrieve the students for the selected class and course
                        XmlNodeList students = doc.SelectNodes($"/attendance_system/users/students/student[class_id='{currentClassId.InnerText}']");

                        // Add students to the grid view
                        foreach (XmlNode student in students)
                        {
                            string studentName = student.SelectSingleNode("name").InnerText;
                            TAttendanceGridView1.Rows.Add(studentName);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"The teacher '{teacherName}' does not teach '{courseFromCompo}' for the class '{classFromCompo}'.");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Teacher '{teacherName}' not found.");
            }

            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedCourseName = CompoCourse.SelectedItem?.ToString() ?? "";
            string selectedCourseId = GetCourseIdByName(selectedCourseName);

            UpdateAttendanceData();


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Get selected date and course information
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedCourseName = CompoCourse.SelectedItem?.ToString() ?? "";
            string selectedCourseId = GetCourseIdByName(selectedCourseName);

            // Check if a course is selected
            if (selectedCourseId == null)
            {
                MessageBox.Show("Selected course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the function if no course is selected
            }

            // Check if the attendance for the selected date and course already exists
            if (IsAttendanceAlreadySaved(selectedDate, selectedCourseId))
            {
                MessageBox.Show("Attendance for the selected date and course already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the function if attendance already exists
            }

            // Check if the button is enabled
            if (!buttonSave.Enabled)
            {
                return; // If button is disabled, exit the function
            }

            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to save at this status?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Check if the user clicked OK
            if (result != DialogResult.OK)
            {
                return; // If user didn't click OK, exit the function
            }

            // Check if the same course was selected for the same date
            if (IsSameCourseSelectedForSameDate(selectedDate, selectedCourseId))
            {
                DisableCheckBoxesInStatusColumn();
            }

            // Save the attendance data
            SaveAttendance(selectedDate, selectedCourseId, TAttendanceGridView1);
        }

        private bool IsAttendanceAlreadySaved(string date, string courseId)
        {
            string filePath = "..\\..\\..\\xml\\AttendanceData.xml";

            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);

                // Check if attendance already exists for the selected date and course
                bool attendanceExists = xmlDoc.Root
                    .Elements("attendace")
                    .Any(a =>
                    {
                        XElement dateElement = a.Element("date");
                        if (dateElement != null && dateElement.Value == date)
                        {
                            XElement coursesAttendanceElement = a.Element("Courses_attendance");
                            if (coursesAttendanceElement != null)
                            {
                                return coursesAttendanceElement
                                    .Elements("Course_attendance")
                                    .Any(c => c.Element("Course_id")?.Value == courseId);
                            }
                        }
                        return false;
                    });

                return attendanceExists;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking if attendance already exists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool IsSameCourseSelectedForSameDate(string date, string courseId)
        {
            string filePath = "..\\..\\..\\xml\\AttendanceData.xml";

            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);

                // Check if the same course was selected for the same date
                bool sameCourseSelected = xmlDoc.Root
                    .Elements("attendace")
                    .Any(a =>
                    {
                        XElement dateElement = a.Element("date");
                        if (dateElement != null && dateElement.Value == date)
                        {
                            XElement coursesAttendanceElement = a.Element("Courses_attendance");
                            if (coursesAttendanceElement != null)
                            {
                                return coursesAttendanceElement
                                    .Elements("Course_attendance")
                                    .Any(c => c.Element("Course_id")?.Value == courseId);
                            }
                        }
                        return false;
                    });

                return sameCourseSelected;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking if the same course was selected for the same date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void DisableCheckBoxesInStatusColumn()
        {
            foreach (DataGridViewRow row in TAttendanceGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["status"];
                checkBoxCell.ReadOnly = true;
                checkBoxCell.Value = false;
            }
        }

        private void SaveAttendance(string date, string courseId, DataGridView dataGridView)
        {
            string attendanceFilePath = "..\\..\\..\\xml\\AttendanceData.xml";
            string systemDataFilePath = "..\\..\\..\\xml\\SystemData.xml";

            try
            {
                XDocument attendanceXmlDoc = XDocument.Load(attendanceFilePath);
                XDocument systemDataXmlDoc = XDocument.Load(systemDataFilePath);

                // Find or create the <students_Attendance> element in the attendance XML
                XElement attendanceNode = attendanceXmlDoc.Root.Element("students_Attendance");
                if (attendanceNode == null)
                {
                    attendanceNode = new XElement("students_Attendance");
                    attendanceXmlDoc.Root.Add(attendanceNode);
                }

                // Find existing attendance for the specified date
                XElement existingAttendance = attendanceNode.Elements("attendace")
                    .FirstOrDefault(a => a.Element("date")?.Value == date);

                // If existing attendance for the date is found, append course attendance to it
                if (existingAttendance != null)
                {
                    // Check if the course attendance already exists
                    XElement existingCourseAttendance = existingAttendance.Element("Courses_attendance")
                        .Elements("Course_attendance")
                        .FirstOrDefault(c => c.Element("course")?.Value == courseId);

                    if (existingCourseAttendance != null)
                    {
                        MessageBox.Show("Attendance for the selected date and course already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    XElement coursesAttendanceElement = existingAttendance.Element("Courses_attendance");
                    AddCourseAttendance(courseId, dataGridView, coursesAttendanceElement, systemDataXmlDoc);
                }
                else
                {
                    // Create a new attendance element
                    XElement attendanceElement = new XElement("attendace",
                        new XElement("date", date),
                        new XElement("Courses_attendance")
                    );

                    // Add course attendance
                    AddCourseAttendance(courseId, dataGridView, attendanceElement.Element("Courses_attendance"), systemDataXmlDoc);

                    // Add the new attendance element to the students_Attendance node
                    attendanceNode.Add(attendanceElement);
                }

                // Save changes to the attendance XML
                attendanceXmlDoc.Save(attendanceFilePath);

                MessageBox.Show("Attendance saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCourseAttendance(string courseId, DataGridView dataGridView, XElement coursesAttendanceElement, XDocument systemDataXmlDoc)
        {
            // Find the course ID from the XML structure of SystemData.xml
            XElement course = systemDataXmlDoc.Root?.Element("courses");
            if (course != null)
            {
                course = course.Elements("course")
                    .FirstOrDefault(c => (string)c.Element("id") == courseId);
            }

            if (course != null)
            {
                string courseName = (string)course.Element("name");

                // Replace the course name with the course ID
                XElement courseElement = new XElement("Course_attendance",
                    new XElement("course", courseId), // Replace course name with course ID
                    new XElement("students")
                );

                // Add the course attendance element
                coursesAttendanceElement.Add(courseElement);

                // Add students to the course attendance
                var studentsElement = courseElement.Element("students");
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string studentName = row.Cells["Student_name"]?.Value?.ToString();
                    string statusWritten = row.Cells["status_written"]?.Value?.ToString();
                    bool status = false;
                    bool.TryParse(row.Cells["status"]?.Value?.ToString(), out status);

                    if (!string.IsNullOrEmpty(studentName) && statusWritten == "Absent" && !status)
                    {
                        string studentId = GetStudentIdByName(studentName, systemDataXmlDoc);
                        if (!string.IsNullOrEmpty(studentId))
                        {
                            // Check if the student ID is already added
                            if (!studentsElement.Elements("student_id").Any(s => (string)s == studentId))
                            {
                                studentsElement.Add(new XElement("student_id", studentId));
                            }
                        }
                    }
                }
            }
        }

        // Method to check if a student is marked as absent for a specific date and course
        private bool IsStudentAbsent(string date, string courseId, string studentId)
        {
            string filePath = "..\\..\\..\\xml\\AttendanceData.xml";

            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);

                // Check if the student is marked as absent for the specified date and course
                bool isAbsent = xmlDoc.Root
                    .Element("students_Attendance")
                    .Elements("attendance")
                    .Any(a => a.Element("date")?.Value == date && a.Element("Courses_attendance")
                        .Elements("Course_attendance")
                        .Any(c => c.Element("course")?.Value == courseId && c.Element("students")
                            .Elements("student_id")
                            .Any(s => s.Value == studentId)));

                return isAbsent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking if the student is absent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsAttendanceAlreadySaved(string date)
        {
            string filePath = "..\\..\\..\\xml\\AttendanceData.xml";

            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);

                // Check if attendance already exists for the selected date
                bool attendanceExists = xmlDoc.Root
                    .Elements("students_Attendance")
                    .Elements("attendance")
                    .Any(a => a.Element("date")?.Value == date);

                return attendanceExists;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking if attendance already exists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private string GetStudentIdByName(string studentName, XDocument xmlDoc)
        {
            if (string.IsNullOrEmpty(studentName) || xmlDoc == null)
            {
                return null;
            }

            XElement studentNode = xmlDoc.Root
                .Element("users")
                .Element("students")
                .Elements("student")
                .FirstOrDefault(s => s.Element("name")?.Value == studentName);

            return studentNode?.Element("id")?.Value;
        }

        // Method to retrieve the course ID by its name
        private string GetCourseIdByName(string courseName)
        {
            string filePath = "..\\..\\..\\xml\\SystemData.xml";

            try
            {
                XDocument xmlDoc = XDocument.Load(filePath);

                // Find the course ID by its name
                string courseId = xmlDoc.Root
                    .Element("courses")
                    .Elements("course")
                    .FirstOrDefault(c => c.Element("name")?.Value == courseName)?
                    .Element("id")?.Value;

                return courseId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving course ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void UpdateAttendanceData()
        {
            // Get the selected date from the DateTimePicker
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedCourseName = CompoCourse.SelectedItem?.ToString();
            string selectedCourseId = GetCourseIdByName(selectedCourseName);

            try
            {
                // Load attendance data for the selected date
                XDocument attendanceXml = XDocument.Load("..\\..\\..\\xml\\AttendanceData.xml");

                // Get the attendance element for the selected date
                XElement attendanceElement = attendanceXml.Root
                    .Elements("attendance")
                    .FirstOrDefault(a => a.Element("date")?.Value == selectedDate);

                if (attendanceElement != null)
                {
                    // Find the course attendance for the selected course ID
                    XElement courseAttendance = attendanceElement
                        .Element("Courses_attendance")
                        .Elements("Course_attendance")
                        .FirstOrDefault(c => c.Element("course")?.Value == selectedCourseId);

                    // If attendance data exists for the selected course
                    if (courseAttendance != null)
                    {
                        // Check if the student with ID 1000 is listed in the attendance for Course 1
                        bool isStudentPresent = courseAttendance
                            .Element("students")
                            .Elements("student_id")
                            .Any(s => s.Value == "1000");

                        // Update DataGridView based on student's presence
                        foreach (DataGridViewRow row in TAttendanceGridView1.Rows)
                        {
                            string studentId = GetStudentIdByName(row.Cells["Student_name"].Value?.ToString(), XDocument.Load("..\\..\\..\\xml\\SystemData.xml"));
                            bool isAbsent = !isStudentPresent;

                            // Update status and checkbox
                            row.Cells["status"].Value = !isAbsent;
                            row.Cells["status_written"].Value = isAbsent ? "Absent" : "Present";
                        }

                        // Disable DataGridView and save button
                        TAttendanceGridView1.Enabled = false;
                        buttonSave.Enabled = false;
                    }
                }
                else
                {
                    // If attendance data does not exist for the selected date, enable DataGridView and save button
                    TAttendanceGridView1.Enabled = true;
                    buttonSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            // Get the selected date from the DateTimePicker
            DateTime selectedDateTime = dateTimePicker1.Value;
            DateTime currentDateTime = DateTime.Now.Date; // Get the current date without time

            // Check if the selected date is different from the current date
            if (selectedDateTime.Date != currentDateTime)
            {
                // Disable save button if the date has changed from the current date
                buttonSave.Enabled = false;
                MessageBox.Show("Save button disabled because the selected date is not the current date.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the event handler
            }

            // Continue with the rest of your logic...
            string selectedDate = selectedDateTime.ToString("yyyy-MM-dd");
            string selectedCourseName = CompoCourse.SelectedItem?.ToString();
            string selectedCourseId = GetCourseIdByName(selectedCourseName);
            

            // Check if attendance for the selected date and course already exists
            if (IsAttendanceAlreadySaved(selectedDate))
            {
                try
                {
                    // Attendance for the selected date already exists
                    // Load attendance data for the selected date
                    XDocument attendanceXml = XDocument.Load("..\\..\\..\\xml\\AttendanceData.xml");

                    // Get the attendance element for the selected date
                    XElement attendanceElement = attendanceXml.Root
                        .Elements("students_Attendance")
                        .Elements("attendance")
                        .FirstOrDefault(a => a.Element("date")?.Value == selectedDate);

                    if (attendanceElement != null)
                    {
                        // Check if attendance exists for the selected course
                        XElement courseElement = attendanceElement
                            .Elements("course")
                            .FirstOrDefault(c => c.Attribute("courseID")?.Value == selectedCourseId);

                        if (courseElement != null)
                        {
                            // Attendance for the selected date and course exists
                            MessageBox.Show("Attendance for the selected date and course already exists. You cannot modify it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Disable DataGridView
                            TAttendanceGridView1.Enabled = false;

                            // Disable save button
                            buttonSave.Enabled = false;

                            // Update DataGridView based on existing attendance data
                            foreach (DataGridViewRow row in TAttendanceGridView1.Rows)
                            {
                                string studentName = row.Cells["Student_name"].Value?.ToString();
                                if (!string.IsNullOrEmpty(studentName))
                                {
                                    string studentId = GetStudentIdByName(studentName, XDocument.Load("..\\..\\..\\xml\\SystemData.xml"));
                                    bool isAbsent = IsStudentAbsent(selectedDate, selectedCourseId, studentId);
                                    row.Cells["status"].Value = !isAbsent; // If student is absent, checkbox should be unchecked
                                    row.Cells["status_written"].Value = isAbsent ? "Absent" : "Present";
                                }
                            }

                            // Show message
                            MessageBox.Show("Save button disabled because attendance data for the selected date and course already exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    // Attendance for the selected date and course does not exist
                    // Enable DataGridView
                    TAttendanceGridView1.Enabled = true;

                    // Enable save button
                    buttonSave.Enabled = true;

                    // Update DataGridView with default values
                    UpdateStatusWrittenColumn(selectedDate, selectedCourseId);

                    // Set default checkbox value depending on the data from XML
                    foreach (DataGridViewRow row in TAttendanceGridView1.Rows)
                    {
                        string studentName = row.Cells["Student_name"].Value?.ToString();
                        if (!string.IsNullOrEmpty(studentName))
                        {
                            string studentId = GetStudentIdByName(studentName, XDocument.Load("..\\..\\..\\xml\\SystemData.xml"));
                            bool isAbsent = IsStudentAbsent(selectedDate, selectedCourseId, studentId);
                            row.Cells["status"].Value = !isAbsent; // If student is absent, checkbox should be unchecked (false)
                            row.Cells["status_written"].Value = isAbsent ? "Absent" : "Present";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TAttendanceGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            // Get the selected date from the DateTimePicker
                            DateTime selectedDate = dateTimePicker1.Value;

                            // Get the class name from your component (e.g., ComboBox)
                            string className = CompoClass.Text;

                            // Get the course from another component (e.g., ComboBox)
                            string course = CompoCourse.Text;

                            // Create a paragraph for the header containing the date, class name, and course
                            Paragraph header = new Paragraph();
                            header.Add(new Phrase("Date: " + selectedDate.ToShortDateString() + "\n"));
                            header.Add(new Phrase("Class Name: " + className + "\n"));
                            header.Add(new Phrase("Course: " + course + "\n\n"));

                            // Create the PDF table
                            PdfPTable pTable = new PdfPTable(TAttendanceGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Add headers to the PDF table
                            foreach (DataGridViewColumn col in TAttendanceGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }

                            // Add data rows to the PDF table
                            foreach (DataGridViewRow viewRow in TAttendanceGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.Value != null) // Check if the cell value is not null
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                    else
                                    {
                                        pTable.AddCell(""); // Or handle null value as needed
                                    }
                                }
                            }

                            // Write the PDF document
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                // Add the header paragraph to the document
                                document.Add(header);

                                // Add the table to the document
                                document.Add(pTable);

                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TAttendanceGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel (*.xlsx)|*.xlsx";
                save.FileName = "Result";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data to disk: " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(save.FileName, SpreadsheetDocumentType.Workbook))
                            {
                                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                                workbookPart.Workbook = new Workbook();

                                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                                worksheetPart.Worksheet = new Worksheet(new SheetData());

                                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                                Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Attendance" };
                                sheets.Append(sheet);

                                // Add header information before the data
                                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                                Row headerRow = new Row();
                                headerRow.Append(CreateTextCell("Date: " + dateTimePicker1.Value.ToShortDateString()));
                                sheetData.AppendChild(headerRow);

                                Row classRow = new Row();
                                classRow.Append(CreateTextCell("Class Name: " + CompoClass.Text));
                                sheetData.AppendChild(classRow);

                                Row courseRow = new Row();
                                courseRow.Append(CreateTextCell("Course: " + CompoCourse.Text));
                                sheetData.AppendChild(courseRow);

                                // Add headers
                                Row headerDataRow = new Row();
                                foreach (DataGridViewColumn col in TAttendanceGridView1.Columns)
                                {
                                    headerDataRow.Append(CreateTextCell(col.HeaderText));
                                }
                                sheetData.AppendChild(headerDataRow);

                                // Add data
                                for (int i = 0; i < TAttendanceGridView1.Rows.Count; i++)
                                {
                                    Row newRow = new Row();
                                    foreach (DataGridViewCell cell in TAttendanceGridView1.Rows[i].Cells)
                                    {
                                        newRow.Append(CreateTextCell(cell.Value?.ToString() ?? ""));
                                    }
                                    sheetData.AppendChild(newRow);
                                }

                                workbookPart.Workbook.Save();
                            }

                            MessageBox.Show("Data Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        // Helper method to create a text cell
        private Cell CreateTextCell(string text)
        {
            Cell cell = new Cell();
            cell.DataType = CellValues.String;
            cell.CellValue = new CellValue(text);
            return cell;
        }








    }
}


























