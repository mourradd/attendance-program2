using AttendanceManagement.Attendance.Teacher;

namespace AttendanceManagement.Attendance.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new FormLogin());
=======
            Application.Run(new TeacherDashborad());
>>>>>>> 429a97916d41c14a77dc8343b24b21d18bb48d54
        }
    }
}