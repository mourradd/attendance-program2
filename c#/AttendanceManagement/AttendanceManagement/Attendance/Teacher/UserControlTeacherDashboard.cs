using System.Xml;

namespace AttendanceManagement.Attendance.Teacher
{
    public partial class UserControlTeacherDashboard : UserControl
    {
        public string userName;
        public UserControlTeacherDashboard(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void TDashboardGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void UserControlTeacherDashboard_Load(object sender, EventArgs e)
        {

            DataBindings.Clear();
            TDashboardGridView.DataSource = null;
            XmlDocument doc = new XmlDocument();

            doc.Load("..\\..\\..\\xml\\SystemData.xml");

            XmlNode Target_Teacher = doc.SelectSingleNode($"/attendance_system/users/teachers/teacher[name=\"{userName}\"]");
            string? teacherId = Target_Teacher.SelectSingleNode("id").InnerText;
            XmlNodeList coursesForTeacher = doc.SelectNodes($"/attendance_system/ClassesCourses/ClassCourses/courses/course[teacher_id=\"{teacherId}\"]");
            foreach (XmlNode course in coursesForTeacher)
            {
                string Id = course.SelectSingleNode("id").InnerText;
                XmlNode courseNode = doc.SelectSingleNode($"/attendance_system/courses/course[id=\"{Id}\"]/name");
                string? CourseName = courseNode.InnerText;

                XmlNodeList ClassesIDs = doc.SelectNodes($"/attendance_system/ClassesCourses/ClassCourses/courses/course[id=\"{Id}\"]/../../Class_id");

                foreach (XmlNode classId in ClassesIDs)
                {
                    int studentNo = doc.SelectNodes($"/attendance_system/users/students/student[class_id=\"{classId.InnerText}\"]").Count;
                    string className = doc.SelectSingleNode($"/attendance_system/Classes/Class[id=\"{classId.InnerText}\"]/name").InnerText;
                    TDashboardGridView.Rows.Add(CourseName, className, studentNo);
                }
            }

        }
    }
}
