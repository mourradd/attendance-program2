using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static AttendanceManagement.AllClasses.StudentsListGenerators;

namespace AttendanceManagement.AllClasses
{
    public static class StudentsListGenerators
    {
        public static List<Student> students;
        public static List<Class> AllClasses;
        public static List<Attandance> Attandances;


        //  public static readonly string filePath = "D:\\attendnce project\\attendance-program\\attendance-program2\\xml\\SystemData.xml";
        public static readonly string filePath = "D:\\PD(ITI Mansoura)\\C#\\project-attendance Management\\sprint2\\attendance-program2\\xml\\SystemData.xml";
        public static readonly string AttandanceDataFileBath = "D:\\PD(ITI Mansoura)\\C#\\project-attendance Management\\sprint2\\attendance-program2\\xml\\AttendanceData.xml";

        static StudentsListGenerators()
    {
        students = LoadStudentsFromXml(filePath);
          //  AllClasses=new List<Class>();
          Attandances= LoadStudentsAttendace(AttandanceDataFileBath);
          

    }

    public static List<Student> LoadStudentsFromXml(string filePath)
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





        public static List<Attandance> LoadStudentsAttendace(string filePath)
        {
            List<Attandance> StudentsAttendance = new List<Attandance>();

            try
            {
                XDocument doc = XDocument.Load(filePath);

                 StudentsAttendance = (
                    from attendace in doc.Root.Elements("attendace")
                    select new Attandance
                    {
                        DateOfDay = (string)attendace.Element("date"),
                        CoursesAttendance = (
                            from courseAttendance in attendace.Elements("Courses_attendance").Elements("Course_attendance")
                            select new CourseAttendance
                            {
                                Class_id = (int)courseAttendance.Element("Class_id"),
                                Course_id = (int)courseAttendance.Element("Course_id"),
                                Students = (
                                    from student in courseAttendance.Element("students").Elements("student_id")
                                    select (int)student
                                ).ToList()
                            }
                        ).ToList()
                    }
                ).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading students from XML: " + ex.Message);
            }

            return StudentsAttendance;
        }


        public static void AddNewStudent(Student newStudent)
       {
        string xmlFilePath = filePath;

        // Load existing XML document
        XDocument doc = XDocument.Load(xmlFilePath);


        // Create an XElement for the new student
        XElement newStudentElement = new XElement("student",
            new XElement("id", newStudent.Id),
            new XElement("name", newStudent.Name),
            new XElement("age", newStudent.Age),
            new XElement("date_of_joining", newStudent.DateOfJoining),
            new XElement("email", newStudent.Email),
            new XElement("password", newStudent.Password),
            new XElement("class_id", newStudent.ClassID)
        );

        // Add the new student element to the XML document
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        doc.Root.Element("users").Element("students").Add(newStudentElement);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        // Save the modified XML document back to the file
        doc.Save(xmlFilePath);

        Console.WriteLine("New student added and XML file updated successfully.");
       }

    }
}  

