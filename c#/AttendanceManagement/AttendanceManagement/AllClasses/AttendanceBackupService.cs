using System;
using System.IO;
using System.Xml.Linq;
using Timer = System.Timers.Timer; // Alias for System.Timers.Timer
using System.Windows.Forms;
using System.Timers;

public class AttendanceBackupService
{
    private Timer timer;
    private string[] sourceFilePaths;
    private string backupDirPath;

    public AttendanceBackupService(string[] sourceFilePaths, string backupDirPath)
    {
        this.sourceFilePaths = sourceFilePaths;
        this.backupDirPath = backupDirPath;

        if (!Directory.Exists(backupDirPath))
        {
            Directory.CreateDirectory(backupDirPath);
            Console.WriteLine("Backup directory created.");
        }

        timer = new Timer();
        timer.Interval = TimeSpan.FromHours(24).TotalMilliseconds; // 24 hours
        timer.Elapsed += Timer_Elapsed;
        timer.Start();

        BackupAttendanceData();

        Console.WriteLine("Attendance data backup scheduled to run periodically.");
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        BackupAttendanceData();
        Console.WriteLine("Attendance data backup completed successfully.");
        MessageBox.Show("Attendance data backup completed successfully.", "Backup Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BackupAttendanceData()
    {
        try
        {
            Console.WriteLine("Starting attendance data backup...");
            foreach (string sourceFilePath in sourceFilePaths)
            {
                // Generate a backup file name with a timestamp
                string backupFileName = $"Backup_{Path.GetFileNameWithoutExtension(sourceFilePath)}_{DateTime.Now:yyyyMMddHHmmss}.xml";
                string backupFilePath = Path.Combine(backupDirPath, backupFileName);

                // Load the XML file
                XDocument doc = XDocument.Load(sourceFilePath);

                // Save a copy of the XML file to the backup location
                doc.Save(backupFilePath);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred during backup: {ex.Message}");
            MessageBox.Show($"Error occurred during backup: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}