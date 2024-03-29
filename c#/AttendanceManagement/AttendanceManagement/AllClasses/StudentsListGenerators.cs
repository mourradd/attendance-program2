﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AttendanceManagement.AllClasses
{
    public static class StudentsListGenerator
    {

        public static List<ClassStudents> students;


        public static readonly string filePath = "..\\..\\..\\xml\\SystemData.xml";




        static StudentsListGenerator()
        {
            students = LoadStudentsFromXml(filePath);
        }

        public static List<ClassStudents> LoadStudentsFromXml(string filePath)
        {
            List<ClassStudents> loadedStudents = new List<ClassStudents>();

            try
            {
                XDocument doc = XDocument.Load(filePath);


                loadedStudents = (
                    from users in doc.Root.Elements("users")
                    from student in users.Elements("students").Elements("student")

                    select new ClassStudents
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






        public static void AddNewStudent(ClassStudents newStudent)
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
            doc.Root.Element("users").Element("students").Add(newStudentElement);

            // Save the modified XML document back to the file
            doc.Save(xmlFilePath);

            Console.WriteLine("New student added and XML file updated successfully.");
        }



        public static void UpdateStudent(ClassStudents updatedStudent)
        {
            string xmlFilePath = filePath;

            // Load existing XML document
            XDocument doc = XDocument.Load(xmlFilePath);

            // Find the student element to update based on the student ID
            XElement studentElement = doc.Root.Element("users").Element("students")
            .Elements("student")
            .FirstOrDefault(s => int.Parse(s.Element("id").Value) == updatedStudent.Id);


            if (studentElement != null)
            {
                // Update the student's information
                studentElement.Element("name").Value = updatedStudent.Name;
                studentElement.Element("age").Value = updatedStudent.Age.ToString();
                //studentElement.Element("date_of_joining").Value = updatedStudent.DateOfJoining;
                studentElement.Element("email").Value = updatedStudent.Email;
                studentElement.Element("password").Value = updatedStudent.Password;
                studentElement.Element("class_id").Value = updatedStudent.ClassID;

                // Save the modified XML document back to the file
                doc.Save(xmlFilePath);

                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }



        public static void DeleteStudent(int studentId)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);

                XElement studentElement = doc.Descendants("student")
                    .FirstOrDefault(s => (int)s.Element("id") == studentId);

                if (studentElement != null)
                {
                    studentElement.Remove();
                    doc.Save(filePath);
                    MessageBox.Show("The student has been deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the student:" + ex.Message);
            }
        }

        public static int CountStudents()
        {
            return students.Count;
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
