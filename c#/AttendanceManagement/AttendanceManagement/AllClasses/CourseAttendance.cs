namespace AttendanceManagement.AllClasses
{
    public class CourseAttendance
    {
        public int Course_id { get; set; }
        public int Class_id { get; set; }
         public List<int> Students { get; set; }=new List<int>();
    }
}