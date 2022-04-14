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
    public partial class FormStatisticsDep : Form
    {
        private EmployeeAdministration empAdmin;
        private Department d;
        public FormStatisticsDep(EmployeeAdministration empAdmin, Department d)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.d = d;

            label1.Text = d.Name + " Department";

            String employees = "";
            foreach (Employee e in this.empAdmin.EmployeesFromDepartment(d.Name))
            {
                employees = employees + " " + e.Name + ",";
            }
            employees = employees.Remove(employees.Length - 1, 1);

            lblEmp.Text = employees;
            lblPersonel.Text = d.RequiredPersonel.ToString();

            chartGender.Series["Gender"].IsValueShownAsLabel = true;

            ShowCharts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime GetStartWeek()
        {
            DateTime currentDate = DateTime.Today;
            DateTime startWeek = DateTime.Today;
            String weekDay = currentDate.DayOfWeek.ToString();
            if (weekDay == "Monday")
            {
                startWeek = currentDate;
            }
            else if (weekDay == "Tuesday")
            {
                startWeek = currentDate.AddDays(-1);
            }
            else if (weekDay.ToString() == "Wednesday")
            {
                startWeek = currentDate.AddDays(-2);
            }
            else if (weekDay == "Thursday")
            {
                startWeek = currentDate.AddDays(-3);
            }
            else if (weekDay == "Friday")
            {
                startWeek = currentDate.AddDays(-4);
            }
            else if (weekDay == "Saturday")
            {
                startWeek = currentDate.AddDays(-5);
            }
            else if (weekDay == "Sunday")
            {
                startWeek = currentDate.AddDays(-6);
            }

            return startWeek;
        }


        private void ShowCharts()
        {
            //gender chart
            int nrFemale = this.empAdmin.NrFemaleEmployeesDepartment(d);
            int nrMale = this.empAdmin.NrOfEmployeesPerDepartment(d.Name) - nrFemale;
            chartGender.Series["Gender"].Points.AddXY("Female", nrFemale);
            chartGender.Series["Gender"].Points.AddXY("Male", nrMale);

            //attendence chart for the previous week
            foreach (Employee e in empAdmin.EmployeesFromDepartment(d.Name))
            {
                chartAttendence.Series["OnTime"].Points.AddXY(e.Name, empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(e, "ON TIME", GetStartWeek()));
                chartAttendence.Series["Late"].Points.AddXY(e.Name, empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(e, "LATE", GetStartWeek()));
                chartAttendence.Series["Absent"].Points.AddXY(e.Name, empAdmin.NrShiftsOfLastWeekByStatusOfEmployee(e, "ABSENT", GetStartWeek()));

            }
        }

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            string directory = $"../../../Departments_Statistics/{d.Name}_Statistics";
            // If directory does not exist, create it
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string fileName = $"../../../Departments_Statistics/{d.Name}_Statistics/{d.Name}_Statistics.txt";
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine($"Name: {d.Name}");
                sw.WriteLine($"Employees: {lblEmp.Text}");
                sw.WriteLine($"Number of required personel: {lblPersonel.Text}");
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

            string dir = $"../../../Departments_Statistics/{d.Name}_Statistics/charts";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string pathChart1 = $"../../../Departments_Statistics/{d.Name}_Statistics/charts/Attendence_Chart_{d.Name}.png";
            chartAttendence.SaveImage(pathChart1, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            string pathChart2 = $"../../../Departments_Statistics/{d.Name}_Statistics/charts/Gneder_Chart_{d.Name}.png";
            chartGender.SaveImage(pathChart2, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            MessageBox.Show($"The overview of {label1.Text} was saved!");
        }
    }
}
