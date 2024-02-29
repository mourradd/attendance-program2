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
        public static List<Courses> Courses;
        public static List<Class_Courses> Classes_Courses;

        //  public static readonly string filePath = "D:\\attendnce project\\attendance-program\\attendance-program2\\xml\\SystemData.xml";
        public static readonly string filePath = "..\\..\\..\\xml\\SystemData.xml";
        public static readonly string AttandanceDataFileBath = "D:\\PD(ITI Mansoura)\\C#\\project-attendance Management\\sprint2\\attendance-program2\\xml\\AttendanceData.xml";

        static StudentsListGenerators()
    {
        students = LoadStudentsFromXml(filePath);
            AllClasses=LoadClasses(filePath);
          Attandances= LoadStudentsAttendace(AttandanceDataFileBath);
          Courses=LoadCourses(filePath);
            Classes_Courses=LoadClassesCourses(filePath);

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
                    ClassID = (int)student.Element("class_id"),
                    DateOfJoining=(string)student.Element("date_of_joining")
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



        public static List<Class> LoadClasses(string filePath) {
        List<Class> classes = new List<Class>();


            try
            {
                XDocument doc = XDocument.Load(filePath);


                classes = (
                    from El in doc.Root.Elements("Classes").Elements("Class")

                    select new Class
                    {
                        ID = (int)El.Element("id"),
                        Name = (string)El.Element("name")
                        
                    }
                ).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading students from XML: " + ex.Message);
            }


            return classes;
        
        }


        public static List<Courses> LoadCourses(string filePath)
        {
            List<Courses> courses = new List<Courses>();


            try
            {
                XDocument doc = XDocument.Load(filePath);


                courses = (
                    from El in doc.Root.Elements("courses").Elements("course")

                    select new Courses
                    {
                        ID = (int)El.Element("id"),
                        Name = (string)El.Element("name"),
                        Details=(string)El.Element("details")

                    }
                ).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading students from XML: " + ex.Message);
            }


            return courses;

        }

        public static List<Class_Courses> LoadClassesCourses(string filePath)
        {
            List<Class_Courses> classes_Courses = new List<Class_Courses>();


            try
            {
                XDocument doc = XDocument.Load(filePath);

                classes_Courses = (
                   from ClassesCourses in doc.Root.Elements("ClassesCourses").Elements("ClassCourses")
                   select new Class_Courses
                   {
                       ClassId = (int)ClassesCourses.Element("Class_id"),
                       Courses = (
                           from course in ClassesCourses.Elements("courses").Elements("course")
                           select new Class_Course
                           {
                               CourseId = (int)course.Element("id"),
                               TeacherId = (int)course.Element("teacher_id"),
                               LectureNumber=(int)course.Element("Lecture_number")
                           }
                       ).ToList()
                   }
               ).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading students from XML: " + ex.Message);
            }


            return classes_Courses;


        }

        public static List<Courses>LoadClassCourses(int ClassId,List<Courses> AllCourse)
        {

            var classCourses = Classes_Courses.FirstOrDefault(x => x.ClassId == ClassId);

            var coursesList = new List<Courses>();
            if (classCourses != null)
            {
                foreach (var coursID in classCourses.Courses)
                {
                    foreach (var Course in StudentsListGenerators.Courses)
                    {
                        if (coursID.CourseId == Course.ID)
                        {
                            coursesList.Add(Course);
                            break;

                        }
                    }



                }

            }
            else
            {
                coursesList = [];

            }
            return coursesList;


        }

        public static List<StudentCourseAttandance> LoadAllStudentCoursesAttendance(Student std)
        {
            var StudentClassAttendancesRawData = StudentsListGenerators.Attandances.Where(attend => attend.CoursesAttendance.Any(y => y.Class_id == std.ClassID)).ToList();
            List<StudentCourseAttandance> studentAttendances = new List<StudentCourseAttandance>();
            foreach (var DayAttendace in StudentClassAttendancesRawData)
            {
                bool findFlag = false;

                foreach (var courseAttendance in DayAttendace.CoursesAttendance)
                {

                    if (courseAttendance.Class_id == std.ClassID)
                    {
                        var courseName = StudentsListGenerators.Courses.FirstOrDefault(x => x.ID == courseAttendance.Course_id).Name;
                        if (studentAttendances.Count > 0)
                        {
                            foreach (var studentAttend in studentAttendances)
                            {
                                if (studentAttend.CourseName == courseName)
                                {
                                    if (courseAttendance.Students.Any(studentID => studentID == std.Id)) studentAttend.NumberOfAttendendLec++;
                                    else studentAttend.NumberOfAbsentedLec++;
                                    findFlag = true;
                                    break;
                                }


                            }
                            if (findFlag) { continue; }
                        }




                        StudentCourseAttandance studentCourseAtt = new StudentCourseAttandance();
                        studentCourseAtt.CourseName = courseName;
                        studentCourseAtt.NumberOfLecture = Classes_Courses.FirstOrDefault(x => x.ClassId == std.ClassID).Courses.FirstOrDefault(course => course.CourseId == courseAttendance.Course_id).LectureNumber;
                        if (courseAttendance.Students.Any(studentID => studentID == std.Id)) studentCourseAtt.NumberOfAttendendLec++;
                        else studentCourseAtt.NumberOfAbsentedLec++;

                        studentAttendances.Add(studentCourseAtt);
                        break;

                    }

                }


            }
        return studentAttendances;
        }
        
        
        
 

            public static void AddNewStudent(AttendanceManagement.AllClasses.Student newStudent)
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



        public static void UpdateStudent(Student updatedStudent)
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
                studentElement.Element("class_id").Value = updatedStudent.ClassID.ToString();

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

