﻿using System;
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
<<<<<<< HEAD
        public static readonly string filePath = "C:\\Users\\lap0\\OneDrive\\Desktop\\C#\\attendance-program2\\c#\\AttendanceManagement\\AttendanceManagement\\xml\\SystemData.xml";
=======
        public static readonly string filePath = "C:\\Users\\lap0\\OneDrive\\Desktop\\C#\\attendance-program2\\xml\\SystemData.xml";
>>>>>>> 56ceb819a22515df11b75679e9c09e737f9351f9
    static StudentsListGenerators()
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
}  

