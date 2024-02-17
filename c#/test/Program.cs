using System.Xml.Linq;
using static test.ListGenerators;
namespace test
{

    public static class ListGenerators
    {
        public static List<Student> students;
        public static readonly string  filePath= "D:\\PD(ITI Mansoura)\\C#\\project-attendance Management\\ProjectCode\\xml\\SystemData.xml";
        static ListGenerators()
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
                        DateOfJoining = (string)student.Element("date_of_joining"),
                        Email = (string)student.Element("email"),
                        PassWord = (string)student.Element("password"),
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
                new XElement("password", newStudent.PassWord),
                new XElement("class_id", newStudent.ClassID)
            );

            // Add the new student element to the XML document
            doc.Root.Element("users").Element("students").Add(newStudentElement);

            // Save the modified XML document back to the file
            doc.Save(xmlFilePath);

            Console.WriteLine("New student added and XML file updated successfully.");
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfJoining { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string ClassID { get; set; }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{DateOfJoining}:{Email}:{PassWord}:{ClassID}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            //// Add a new student to the XML document
            //Student newStudent = new Student()
            //{
            //    Id = 1000,
            //    Name = "Ali emad aboshosha",
            //    Age = 25,
            //    DateOfJoining = "2024-02-16",
            //    Email = "ali@gmail.com.com",
            //    PassWord = "AliEmad123#",
            //    ClassID = "PD"
            //};
            //AddNewStudent(newStudent);
        }

      
    }
}
