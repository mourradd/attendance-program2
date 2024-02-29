using AttendanceManagement.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static AttendanceManagement.AllClasses.StudentsListGenerators;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using OfficeOpenXml.Style;


using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml.Core.ExcelPackage;
namespace AttendanceManagement.Attendance.Student
{
    public partial class StudentCourseAttendaceDashboard : Form
    {
        public string CourseName;
        public string Username, Role, ClassName, JoinDate;
        public static AttendanceManagement.AllClasses.Student Student;


        public static StudentCourseAttendaceDashboard St;
        public static StudentCourseAttendaceDashboard GetForm
        {
            get
            {
                if (St == null)
                {
                    St = new StudentCourseAttendaceDashboard();

                }
                return St;
            }
        }

        public StudentCourseAttendaceDashboard()
        {
            InitializeComponent();
            timerDateAndTime.Start();



            var Student = StudentsListGenerators.students.FirstOrDefault((x) => x.Email == "ali@gmail.com" && x.Password == "AliEmad123#");
            Username = Student.Name;
            Role = "Student";
            ClassName = StudentsListGenerators.AllClasses.FirstOrDefault(x => x.ID == Student.ClassID).Name;
            JoinDate = Student.DateOfJoining;
            List<Courses> comboBoxValues = new List<Courses>();
            comboBoxValues.Add(new Courses { ID = 0, Name = "All Courses", });
            foreach (var item in LoadClassCourses(Student.ClassID, StudentsListGenerators.Courses))
            {
                comboBoxValues.Add(item);

            }
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;



        }
        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString();
        }


        private void FormDashborad_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
            labelRole.Text = Role;
            ClassValue.Text = ClassName;
            JoiningDateValue.Text = JoinDate;
            CourseName = StudentDashboard.selectedRow.Cells[0].Value.ToString();
            Student = StudentDashboard.Student;
            var comboBoxValues = new List<string>();
            comboBoxValues.Add("PDF");
            comboBoxValues.Add("Excel");
            comboBoxValues.Add("Web Page");
            comboBox1.DataSource = comboBoxValues;
            CoursNaneValue.Text = CourseName;


            #region gett all this coure attend for the the current student 
            var courseID = StudentsListGenerators.Courses.FirstOrDefault(x => x.Name == CourseName).ID;
            var teacherId = StudentsListGenerators.Classes_Courses.FirstOrDefault(cls => cls.ClassId == Student.ClassID).Courses.FirstOrDefault(cours => cours.CourseId == courseID).TeacherId;
            var teacherName = TeacherListGenerators.teachers.FirstOrDefault(teacher => teacher.Id == teacherId).Name;
            List<StudentDayAttend> courseAttendance = new List<StudentDayAttend>();
            foreach (var dayAttend in StudentsListGenerators.Attandances)
            {
                foreach (var course in dayAttend.CoursesAttendance)
                {
                    if (course.Class_id == Student.ClassID && course.Course_id == courseID)
                    {
                        StudentDayAttend studentDayAttend = new StudentDayAttend();
                        string dayName = DateTime.Parse(dayAttend.DateOfDay).DayOfWeek.ToString();
                        studentDayAttend.Day_Date = dayAttend.DateOfDay + " " + dayName;

                        if (course.Students.Any(studentId => studentId == Student.Id))
                        {
                            studentDayAttend.Attendance_State = "Absent";
                        }
                        else studentDayAttend.Attendance_State = "Attend";

                        courseAttendance.Add(studentDayAttend);
                        break;
                    }


                }



            }

            dataGridView1.DataSource = courseAttendance;








            //  dataGridView1.Rows[0].Cells[0].Value = teacherName;

            #endregion



        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonReport_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "PDF":
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                        saveFileDialog.FileName = $"{CourseName}.pdf";
                        bool ErrorMassage = false;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            if (File.Exists(saveFileDialog.FileName))
                            {
                                try
                                {
                                    File.Delete(saveFileDialog.FileName);

                                }
                                catch (Exception ex)
                                {
                                    ErrorMassage = true;
                                    MessageBox.Show("Unable to write data in the disk" + ex.Message);

                                }
                            }
                            if (!ErrorMassage)
                            {

                                try
                                {
                                    PdfPTable PTable = new PdfPTable(dataGridView1.Columns.Count);
                                    PTable.DefaultCell.Padding = 2;
                                    PTable.WidthPercentage = 100;
                                    PTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                                    {
                                        PdfPCell pCell = new PdfPCell(new Phrase(column.HeaderText));
                                        // Apply styles from the DataGridView to the PDF cell
                                        pCell.BackgroundColor = new BaseColor(dataGridView1.ColumnHeadersDefaultCellStyle.BackColor);
                                        pCell.HorizontalAlignment = Element.ALIGN_CENTER; // Align header text to center
                                        PTable.AddCell(pCell);

                                    }
                                    foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                                    {
                                        foreach (DataGridViewCell dCell in viewRow.Cells)
                                        {
                                            PdfPCell dataCell = new PdfPCell(new Phrase(dCell.Value?.ToString() ?? ""));
                                            string attendanceState = dCell.Value.ToString();

                                            if (attendanceState == "Attend")
                                            {
                                                dataCell.BackgroundColor = BaseColor.GREEN; // Set background color to green for "Attend"
                                            }
                                            else if (attendanceState == "Absent")
                                            {

                                                dataCell.BackgroundColor = BaseColor.RED; // Set background color to red for "Absent"
                                            }

                                            PTable.AddCell(dataCell);
                                        }
                                    }


                                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                                    {
                                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                        PdfWriter.GetInstance(document, fileStream);

                                        document.Open();
                                        document.Add(PTable);
                                        document.Close();
                                        fileStream.Close();

                                    }
                                    MessageBox.Show("Data saved successfully", "info");
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("An error happend while saving the data" + ex.Message);
                                }
                            }
                        }

                        break;

                    case "Excel":
                        // Your existing code...
                        SaveFileDialog saveFileDialogExcel = new SaveFileDialog();
                        saveFileDialogExcel.Filter = "Excel (*.xlsx)|*.xlsx";
                        saveFileDialogExcel.FileName = $"Result.xlsx";
                        bool errorMassageExcel = false;

                        if (saveFileDialogExcel.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                using (OfficeOpenXml.ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage())
                                {
                                    // Specify the namespace for ExcelWorksheet
                                    OfficeOpenXml.ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                                    // Add column headers
                                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                    {
                                        worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                                    }

                                    // Add row data with styles
                                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                                    {
                                        for (int column = 0; column < dataGridView1.Columns.Count; column++)
                                        {
                                            string attendanceState = dataGridView1.Rows[row].Cells[column].Value.ToString();

                                            worksheet.Cells[row + 2, column + 1].Value = attendanceState;

                                            // Apply cell styling based on attendance state
                                            if (attendanceState == "Attend")
                                            {
                                                worksheet.Cells[row + 2, column + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                                worksheet.Cells[row + 2, column + 1].Style.Fill.BackgroundColor.SetColor(Color.Green);
                                            }
                                            else if (attendanceState == "Absent")
                                            {
                                                worksheet.Cells[row + 2, column + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                                worksheet.Cells[row + 2, column + 1].Style.Fill.BackgroundColor.SetColor(Color.Red);
                                            }
                                        }
                                    }

                                    excelPackage.SaveAs(new FileInfo(saveFileDialogExcel.FileName));
                                    MessageBox.Show("Data saved successfully", "Info");
                                }
                            }
                            catch (Exception ex)
                            {
                                errorMassageExcel = true;
                                MessageBox.Show("An error occurred while saving the data: " + ex.Message);
                            }
                        }
                        break;
                }
              



            }
            else
            {
                MessageBox.Show("No data is here to save ", "Info");
            }


        }










        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }



        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the "Attendance_State" column and the current cell is not in the header row
            if (dataGridView1.Columns[e.ColumnIndex].Name == "attendanceStateDataGridViewTextBoxColumn" && e.RowIndex >= 0)
            {
                // Get the value of the current cell
                string attendanceState = e.Value.ToString();

                // Set the background color based on the attendance state
                if (attendanceState == "Attend")
                {
                    e.CellStyle.BackColor = Color.Green; // Set background color to green for "Attend"
                    e.CellStyle.ForeColor = Color.White; // Set text color to white for better visibility
                }
                else if (attendanceState == "Absent")
                {
                    e.CellStyle.BackColor = Color.Red; // Set background color to red for "Absent"
                    e.CellStyle.ForeColor = Color.White; // Set text color to white for better visibility
                }
            }
        }

       
    }
}
