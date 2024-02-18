﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AttendanceManagement.Resources
{
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
    public static class UsersOfSystem
    {
        // public static List<Student> Students;
        public static List<Student> students;
        public static readonly string filePath = "C:\\Users\\lap0\\OneDrive\\Desktop\\C#Project\\attendance-program2\\xml\\SystemData.xml";
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

    }
}
