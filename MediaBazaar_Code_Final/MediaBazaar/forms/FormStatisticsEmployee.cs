using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.classes;

namespace MediaBazaar.forms
{
    public partial class FormStatisticsEmployee : Form
    {
        private EmployeeAdministration empAdmin;
        private Employee employee;
        public FormStatisticsEmployee(EmployeeAdministration empAdmin, Employee employee)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.employee = employee;

            label1.Text = employee.Name;
            lblEmail.Text = employee.Email;
            lblWage.Text = "€" + employee.HourlyWage.ToString();
            lblHours.Text = employee.HoursWorked.ToString() + " hours";
            lblFree.Text = (employee.HolidayDays + employee.SickDays).ToString() + " days";
            lblDep.Text = employee.Department;

            SeeCharts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime GetStartWeek()
        {
            DateTime currentDate = DateTime.Today;
            DateTime startWeek = DateTime.Today;
            if (currentDate.DayOfWeek.ToString() == "Monday")
            {
                startWeek = currentDate;
            }
            else if (currentDate.DayOfWeek.ToString() == "Tuesday")
            {
                startWeek = currentDate.AddDays(-1);
            }
            else if (currentDate.DayOfWeek.ToString() == "Wednesday")
            {
                startWeek = currentDate.AddDays(-2);
            }
            else if (currentDate.DayOfWeek.ToString() == "Thursday")
            {
                startWeek = currentDate.AddDays(-3);
            }
            else if (currentDate.DayOfWeek.ToString() == "Friday")
            {
                startWeek = currentDate.AddDays(-4);
            }
            else if (currentDate.DayOfWeek.ToString() == "Saturday")
            {
                startWeek = currentDate.AddDays(-5);
            }
            else if (currentDate.DayOfWeek.ToString() == "Sunday")
            {
                startWeek = currentDate.AddDays(-6);
            }

            return startWeek;
        }


        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriod.SelectedItem.ToString() == "Last week")
            {
                label6.Text = $"Period: Week: {GetStartWeek().AddDays(-7).ToShortDateString()} - {GetStartWeek().AddDays(-1).ToShortDateString()}";
                int nrPresent = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ON TIME", GetStartWeek().AddDays(-7));
                int nrLate = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "LATE", GetStartWeek().AddDays(-7));
                int nrAbsent = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ABSENT", GetStartWeek().AddDays(-7));
                lblPresent.Text = $"Present: {nrPresent} shifts";
                lblAbsent.Text = $"Absent: {nrAbsent} shifts";
                lblLate.Text = $"Late: {nrLate} shifts";


            }
            else if (cbPeriod.SelectedItem.ToString() == "Last 2 weeks")
            {
                label6.Text = $"Period: Week: {GetStartWeek().AddDays(-14).ToShortDateString()} - {GetStartWeek().AddDays(-8).ToShortDateString()}";
                int nrPresent = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ON TIME", GetStartWeek().AddDays(-14));
                int nrLate = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "LATE", GetStartWeek().AddDays(-14));
                int nrAbsent = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ABSENT", GetStartWeek().AddDays(-14));
                lblPresent.Text = $"Present: {nrPresent} shifts";
                lblAbsent.Text = $"Absent: {nrAbsent} shifts";
                lblLate.Text = $"Late: {nrLate} shifts";
            }
        }

        public void SeeCharts()
        {
            DateTime start = GetStartWeek();

            int week1P = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "PRESENT", start );
            int week1A = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ABSENT", start);
            int week1L = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "LATE", start);
            chartAttendence.Series["Present"].Points.AddXY($"{start.ToShortDateString()} - {start.AddDays(6).ToShortDateString()}", week1P);
            chartAttendence.Series["Absent"].Points.AddXY($"{start.ToShortDateString()} - {start.AddDays(6).ToShortDateString()}", week1A);
            chartAttendence.Series["Late"].Points.AddXY($"{start.ToShortDateString()} - {start.AddDays(6).ToShortDateString()}", week1L);

            int week2P = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "PRESENT", start.AddDays(-7));
            int week2A = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ABSENT", start.AddDays(-7));
            int week2L = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "LATE", start.AddDays(-7));
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-7).ToShortDateString()} - {start.AddDays(-1).ToShortDateString()}", week2P);
            chartAttendence.Series["Absent"].Points.AddXY($"{start.AddDays(-7).ToShortDateString()} - {start.AddDays(-1).ToShortDateString()}", week2A);
            chartAttendence.Series["Late"].Points.AddXY($"{start.AddDays(-7).ToShortDateString()} - {start.AddDays(-1).ToShortDateString()}", week2L);

            int week3P = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "PRESENT", start.AddDays(-14));
            int week3A = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ABSENT", start.AddDays(-14));
            int week3L = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "LATE", start.AddDays(-14));
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-14).ToShortDateString()} - {start.AddDays(-8).ToShortDateString()}", week3P);
            chartAttendence.Series["Absent"].Points.AddXY($"{start.AddDays(-14).ToShortDateString()} - {start.AddDays(-8).ToShortDateString()}", week3A);
            chartAttendence.Series["Late"].Points.AddXY($"{start.AddDays(-14).ToShortDateString()} - {start.AddDays(-8).ToShortDateString()}", week3L);

            int week4P = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "PRESENT", start.AddDays(-21));
            int week4A = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ABSENT", start.AddDays(-21));
            int week4L = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "LATE", start.AddDays(-21));
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-21).ToShortDateString()} - {start.AddDays(-15).ToShortDateString()}", week4P);
            chartAttendence.Series["Absent"].Points.AddXY($"{start.AddDays(-21).ToShortDateString()} - {start.AddDays(-15).ToShortDateString()}", week4A);
            chartAttendence.Series["Late"].Points.AddXY($"{start.AddDays(-21).ToShortDateString()} - {start.AddDays(-15).ToShortDateString()}", week4L);

            int week5P = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "PRESENT", start.AddDays(-28));
            int week5A = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "ABSENT", start.AddDays(-28));
            int week5L = this.empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(this.employee, "LATE", start.AddDays(-28));
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-28).ToShortDateString()} - {start.AddDays(-22).ToShortDateString()}", week5P);
            chartAttendence.Series["Absent"].Points.AddXY($"{start.AddDays(-28).ToShortDateString()} - {start.AddDays(-22).ToShortDateString()}", week5A);
            chartAttendence.Series["Late"].Points.AddXY($"{start.AddDays(-28).ToShortDateString()} - {start.AddDays(-22).ToShortDateString()}", week5L);
        }

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            string directory = $"../../../Employees_Statistics/{employee.Name}_Statistics";
            // If directory does not exist, create it
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string fileName = $"../../../Employees_Statistics/{employee.Name}_Statistics/{employee.Name}_Statistics.txt";
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine($"Name: {employee.Name}");
                sw.WriteLine($"E-mail: {employee.Email}");
                sw.WriteLine($"Hourly Wage: €{employee.HourlyWage}");
                sw.WriteLine($"Hours Worked: {employee.HoursWorked}");
                sw.WriteLine($"Number of free days: {employee.HolidayDays + employee.SickDays}");
                sw.WriteLine($"Department: {employee.HoursWorked}");
                lblDep.Text = employee.Department;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error writing file");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

            string dir = $"../../../Employees_Statistics/{employee.Name}_Statistics/charts";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string pathChart1 = $"../../../Employees_Statistics//{employee.Name}_Statistics/charts/Attendence_For_Last_5_Weeks_{employee.Name}.png";
            chartAttendence.SaveImage(pathChart1, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            MessageBox.Show($"The overview of {employee.Name} was saved!");
        }
    }
}
