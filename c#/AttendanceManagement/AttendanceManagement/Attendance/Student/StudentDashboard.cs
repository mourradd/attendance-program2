using AttendanceManagement.Attendance.Forms.AdminDashborad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttendanceManagement.Attendance.Student
{
    public partial class StudentDashboard : Form
    {
        public string Username, Role;

        public StudentDashboard()
        {
            InitializeComponent();
            timerDateAndTime.Start();

        }
        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 211);
            panelSide1.Location = new Point(button.Location.X, button.Location.Y);
            panelSide2.Location = new Point(button.Location.X, button.Location.Y + 45);
        }



        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);

        }




        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            //Close();
            DialogResult dialogResult = MessageBox.Show("Are you want to log out", "log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panelExpand.Hide();
            }
        }


        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }


        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
            {
                panelExpand.Visible = false;
            }
            else
                panelExpand.Visible = true;
        }


        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString();
        }


        private void FormDashborad_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;


        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            if(dataGridView1.Rows.Count > 1)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog() ;
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "Result.pdf";
                bool ErrorMassage= false;
                if (saveFileDialog.ShowDialog()==DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);

                        }
                        catch (Exception ex)
                        {
                            ErrorMassage = true;
                            MessageBox.Show("Unable to write data in the disk" + ex.Message);

                        }
                    }
                    if (!ErrorMassage)
                    {

                        try
                        {
                            PdfPTable PTable = new PdfPTable(dataGridView1.Columns.Count);
                            PTable.DefaultCell.Padding = 2;
                            PTable.WidthPercentage = 100;
                            PTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        
                        foreach (DataGridViewColumn  column in dataGridView1.Columns) 
                            {
                                PdfPCell pCell= new PdfPCell(new Phrase(column.HeaderText));
                                PTable.AddCell(pCell);
                            
                            }
                        foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dCell in viewRow.Cells)
                                {
                                    PTable.AddCell(dCell.Value.ToString());
                                }
                            }


                        using(FileStream fileStream=new FileStream(saveFileDialog.FileName, FileMode.Create)) 
                            {
                            Document document = new Document(PageSize.A4,8f,16f,16f,8f);
                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();
                                document.Add(PTable);
                                document.Close();   
                                fileStream.Close(); 

                            }
                            MessageBox.Show("Data saved successfully","info");
                        }
                        catch (Exception ex) 
                        {

                            MessageBox.Show("An error happend while saving the data" + ex.Message);
                        }
                    }
                }



            }
            else
            {
                MessageBox.Show("No data is here to save ", "Info");
            }


        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
