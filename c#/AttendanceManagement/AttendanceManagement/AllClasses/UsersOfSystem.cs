using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AttendanceManagement.AllClasses;

namespace AttendanceManagement.Resources
{

    public static class UsersOfSystem
    {
        // public static List<Student> Students;
        public static List<Student> students;
<<<<<<< HEAD
        public static readonly string filePath = "D:\\PD(ITI Mansoura)\\C#\\project-attendance Management\\sprint2\\attendance-program2\\xml\\SystemData.xml";
=======
        public static readonly string filePath = "C:\\Users\\lap0\\OneDrive\\Desktop\\Main\\attendance-program2\\c#\\AttendanceManagement\\AttendanceManagement\\xml\\SystemData.xml";

>>>>>>> 404af805421417d71d3f2dfd0ef4541f19fa2922
        static UsersOfSystem()
        {
            students = LoadStudentsFromXml(filePath);
        }

        private static List<Student> LoadStudentsFromXml(string filePath)
        {
            List<Student> loadedStudents = new List<Student>();

            try
            {
                XDocument doc = XDocument.Load(filePath);

 
                loadedStudents = (
                    from users in doc.Root.Elements("users")
                    from student in users.Elements("students").Elements("student")

                    select new Student
                    {
                        Id = (int)student.Element("id"),
                        Name = (string)student.Element("name"),
                        Age = (int)student.Element("age"),
                        //DateOfJoining = (DateTime)student.Element("date_of_joining"),
                        Email = (string)student.Element("email"),
                        Password = (string)student.Element("password"),
                        ClassID = (string)student.Element("class_id")
                    }
                ).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading students from XML: " + ex.Message);
            }

            return loadedStudents;
        }

    }
}