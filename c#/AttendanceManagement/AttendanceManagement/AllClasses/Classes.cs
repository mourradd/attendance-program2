using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AttendanceManagement.AllClasses
{

    public class Classes
    {
        private readonly string xmlFilePath;
        private Dictionary<string, string> classIdMap;

        public Classes(string filePath)
        {
            xmlFilePath = filePath;
            LoadClassIdMap();
        }

        private void LoadClassIdMap()
        {
            classIdMap = new Dictionary<string, string>();

            try
            {
                XDocument doc = XDocument.Load(xmlFilePath);

                foreach (var classElement in doc.Descendants("Class"))
                {
                    string classId = classElement.Element("id").Value;
                    string className = classElement.Element("name").Value;
                    classIdMap.Add(className, classId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading class data: " + ex.Message);
            }
        }

        public List<string> GetClassNames()
        {
            return classIdMap.Keys.ToList();
        }

        public void AddClass(string className)
        {
            if (!classIdMap.ContainsKey(className))
            {
                // Generate a unique ID for the new class
                string classId = GenerateUniqueId();

                // Add the new class to the XML file
                try
                {
                    XDocument doc = XDocument.Load(xmlFilePath);

                    XElement newClassElement = new XElement("Class",
                        new XElement("id", classId),
                        new XElement("name", className)
                    );

                    doc.Root.Element("Classes").Add(newClassElement);
                    doc.Save(xmlFilePath);

                    // Update the class ID map
                    classIdMap.Add(className, classId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding class: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Class already exists.");
            }
        }

        public void DeleteClass(string className)
        {
            if (classIdMap.ContainsKey(className))
            {
                string classId = classIdMap[className];

                try
                {
                    XDocument doc = XDocument.Load(xmlFilePath);

                    // Find and remove the class element from the XML file
                    XElement classElementToRemove = doc.Descendants("Class")
                        .FirstOrDefault(x => x.Element("id").Value == classId && x.Element("name").Value == className);

                    classElementToRemove?.Remove();
                    doc.Save(xmlFilePath);

                    // Update the class ID map
                    classIdMap.Remove(className);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting class: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Class does not exist.");
            }
        }

        public static string GetClassIdByName(string className)
        {
            XDocument doc = XDocument.Load("..\\..\\..\\xml\\SystemData.xml");

            XElement classElement = doc.Descendants("Class")
                                       .FirstOrDefault(e => e.Element("name").Value == className);

            if (classElement != null)
            {
                return classElement.Element("id").Value;
            }
            else
            {
                return string.Empty;
            }
        }


        private string GenerateUniqueId()
        {
            // Generate a unique ID based on the current date and time
            string uniqueIdString = DateTime.Now.ToString("yyyyMMddHHmmss");
            return uniqueIdString;
        }
    }
}
