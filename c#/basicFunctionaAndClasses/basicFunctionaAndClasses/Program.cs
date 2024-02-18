using System;
using System.Collections.Generic;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public override string ToString()
    {
        return $"Username: {Username}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        User other = (User)obj;
        return Username == other.Username && Password == other.Password;
    }

    public override int GetHashCode()
    {
        return Username.GetHashCode() ^ Password.GetHashCode();
    }
}

public class Student : User
{
    public string TrackName { get; set; }
    public string Grade { get; set; }

    public void ViewData()
    {
        Console.WriteLine($"Username: {Username}, Track Name: {TrackName}, Grade: {Grade}");
    }

    public void ViewAttendancePerCourse(string courseName)
    {
        Console.WriteLine($"Viewing attendance for course: {courseName}");
    }
}

public class Teacher : User
{
    public DateTime HiringDate { get; set; }
    public decimal Salary { get; set; }
    public List<string> Courses { get; set; }
    public List<int> TrackNumbers { get; set; }

    public override string ToString()
    {
        return $"Username: {Username}, Hiring Date: {HiringDate}, Salary: {Salary}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Teacher other = (Teacher)obj;
        return base.Equals(obj) && HiringDate == other.HiringDate && Salary == other.Salary &&
               Courses.SequenceEqual(other.Courses) && TrackNumbers.SequenceEqual(other.TrackNumbers);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode() ^ HiringDate.GetHashCode() ^ Salary.GetHashCode() ^
               Courses.GetHashCode() ^ TrackNumbers.GetHashCode();
    }

    public void ViewPersonalData()
    {
        Console.WriteLine($"Hiring Date: {HiringDate}, Salary: {Salary}");
        Console.WriteLine("Courses taught:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course);
        }
        Console.WriteLine("Tracks assigned:");
        foreach (var trackNumber in TrackNumbers)
        {
            Console.WriteLine(trackNumber);
        }
    }

    public void MarkAttendance(List<Student> students, string courseName, string date)
    {
        Console.WriteLine($"Marking attendance for course {courseName} on {date}");
        foreach (var student in students)
        {
            // Here you would implement logic to mark attendance for each student
            // For this example, let's just print the student's username
            Console.WriteLine($"Marking attendance for student: {student.Username}");
        }
    }
}

public class Admin : User
{
    private List<Student> students = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void DeleteStudent(string username)
    {
        Student student = students.Find(s => s.Username == username);
        if (student != null)
            students.Remove(student);
        else
            Console.WriteLine($"Student with username {username} not found.");
    }

    public void DeleteTeacher(string username)
    {
        Teacher teacher = teachers.Find(t => t.Username == username);
        if (teacher != null)
            teachers.Remove(teacher);
        else
            Console.WriteLine($"Teacher with username {username} not found.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student
        {
            Username = "student1",
            Password = "password",
            TrackName = "Track A",
            Grade = "A"
        };

        Teacher teacher = new Teacher
        {
            Username = "teacher1",
            Password = "password",
            HiringDate = new DateTime(2010, 1, 1),
            Salary = 50000,
            Courses = new List<string> { "Math", "Science" },
            TrackNumbers = new List<int> { 1, 2 }
        };

        Admin admin = new Admin
        {
            Username = "admin1",
            Password = "password"
        };

        admin.AddStudent(student);
        admin.AddTeacher(teacher);

        // Mark attendance
        teacher.MarkAttendance(new List<Student> { student }, "Math", DateTime.Now.ToShortDateString());
    }
}
