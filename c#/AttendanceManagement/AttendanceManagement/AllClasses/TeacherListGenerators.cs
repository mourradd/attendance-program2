using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AttendanceManagement.AllClasses
{
    public class TeacherListGenerators
    {

        public static List<Teacher> teachers;


        public static readonly string filePath = "..\\..\\..\\xml\\SystemData.xml";


        static TeacherListGenerators()
        {
            teachers = LoadTeachersFromXml(filePath);
        }

        public static List<Teacher> LoadTeachersFromXml(string filePath)
        {
            List<Teacher> loadedTeachers = new List<Teacher>();

            try
            {
                XDocument doc = XDocument.Load(filePath);


                loadedTeachers = (
                    from users in doc.Root.Elements("users")
                    from student in users.Elements("teachers").Elements("teacher")

                    select new Teacher
                    {
                        Id = (int)student.Element("id"),
                        Name = (string)student.Element("name"),
                        Age = (int)student.Element("age"),
                        //DateOfJoining = (DateTime)student.Element("date_of_joining"),
                        Email = (string)student.Element("email"),
                        Password = (string)student.Element("password"),
                    }
                ).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading students from XML: " + ex.Message);
            }

            return loadedTeachers;
        }






        public static void AddNewTeacher(Teacher newTeacher)
        {
            string xmlFilePath = filePath;

            // Load existing XML document
            XDocument doc = XDocument.Load(xmlFilePath);

            // Create an XElement for the new teacher
            XElement newTeachersElement = new XElement("teacher",
                new XElement("id", newTeacher.Id),
                new XElement("name", newTeacher.Name),
                new XElement("age", newTeacher.Age),
                new XElement("date_of_joining", newTeacher.DateOfJoining),
                new XElement("email", newTeacher.Email),
                new XElement("password", newTeacher.Password)
            );

            // Add the new teacher element to the XML document
            doc.Root.Element("users").Element("teachers").Add(newTeachersElement);

            // Save the modified XML document back to the file
            doc.Save(xmlFilePath);

            Console.WriteLine("New teacher added and XML file updated successfully.");
        }


        public static void UpdateTeacher(Teacher updatedTeacher)
        {
            string xmlFilePath = filePath;

            // Load existing XML document
            XDocument doc = XDocument.Load(xmlFilePath);

            // Find the student element to update based on the student ID
            XElement teacherElement = doc.Root.Element("users").Element("teachers")
            .Elements("teacher")
            .FirstOrDefault(s => int.Parse(s.Element("id").Value) == updatedTeacher.Id);


            if (teacherElement != null)
            {
                // Update the student's information
                teacherElement.Element("name").Value = updatedTeacher.Name;
                teacherElement.Element("age").Value = updatedTeacher.Age.ToString();
                //studentElement.Element("date_of_joining").Value = updatedStudent.DateOfJoining;
                teacherElement.Element("email").Value = updatedTeacher.Email;
                teacherElement.Element("password").Value = updatedTeacher.Password;

                // Save the modified XML document back to the file
                doc.Save(xmlFilePath);

                Console.WriteLine("Teacher updated successfully.");
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }



        public static void DeleteTeacher(int teacherId)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);

                XElement teacherElement = doc.Descendants("teacher")
                    .FirstOrDefault(s => (int)s.Element("id") == teacherId);

                if (teacherElement != null)
                {
                    teacherElement.Remove();
                    doc.Save(filePath);
                    MessageBox.Show("The Teacher has been deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Teachers not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the teacher:" + ex.Message);
            }
        }

        public static int CountTeachers()
        {
            return teachers.Count;
        }

        private static HashSet<int> usedIds = new HashSet<int>();
        private static Random random = new Random();

        public static int GenerateUniqueId()
        {
            while (true)
            {
                int id = random.Next(1, 1001);

                if (!usedIds.Contains(id))
                {
                    usedIds.Add(id);
                    return id;
                }
            }
        }



    }
}
