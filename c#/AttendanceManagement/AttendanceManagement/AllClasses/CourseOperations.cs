using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.AllClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

 

    public static class CourseOperations
    {
        public static readonly string filePath = "C:\\Users\\lap0\\OneDrive\\Desktop\\MainFinal\\attendance-program2\\c#\\AttendanceManagement\\AttendanceManagement\\xml\\SystemData.xml";

        public static List<Courses> LoadCoursesFromXml()
        {
            List<Courses> courses = new List<Courses>();

            try
            {
                XDocument doc = XDocument.Load(filePath);

                courses = doc.Root.Element("courses").Elements("course").Select(course => new Courses
                {
               
                    Name = course.Element("name").Value,
                    Details = course.Element("details").Value,
                     ID = int.Parse(course.Element("id").Value)

                }).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading courses from XML: " + ex.Message);
            }

            return courses;
        }

        public static void AddNewCourse(Courses newCourse)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);

                XElement newCourseElement = new XElement("course",
                    new XElement("id", newCourse.ID),
                    new XElement("name", newCourse.Name),
                    new XElement("details", newCourse.Details)
                );

                // Add the new course element to the "courses" section
                doc.Root.Element("courses").Add(newCourseElement);

                doc.Save(filePath);

                Console.WriteLine("New course added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding new course: " + ex.Message);
            }
        }

        public static void UpdateCourse(Courses updatedCourse)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);

                // Search for the course element to update
                XElement courseElement = (
                    from course in doc.Root.Element("courses").Elements("course")
                    where (int)course.Element("id") == updatedCourse.ID
                    select course
                ).FirstOrDefault();

                if (courseElement != null)
                {
                    courseElement.Element("name").Value = updatedCourse.Name;
                    courseElement.Element("details").Value = updatedCourse.Details;

                    doc.Save(filePath);
                    Console.WriteLine("Course updated successfully.");
                }
                else
                {
                    Console.WriteLine("Course not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating course: " + ex.Message);
            }
        }

        public static void DeleteCourse(int courseId)
        {
            try
            {
                XDocument doc = XDocument.Load(filePath);

                // تحديد العنصر الذي يحتوي على معرف الكورس المطلوب حذفه
                XElement courseElement = doc.Root
                    .Element("courses")
                    .Elements("course")
                    .FirstOrDefault(c => (int)c.Element("id") == courseId);

                if (courseElement != null)
                {
                    // حذف العنصر
                    courseElement.Remove();
                    doc.Save(filePath);
                    MessageBox.Show("Course deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Course not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting course: " + ex.Message);
            }
        }



        public static int CountCourses()
        {
            int count = 0;
            try
            {
                XDocument doc = XDocument.Load(filePath);

                count = doc.Root.Element("courses").Elements("course").Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting courses: " + ex.Message);
            }

            return count;
        }

    }

}
