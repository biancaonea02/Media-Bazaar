using MediaBazaar.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.forms
{
    public partial class FormStatistics : Form
    {
        private EmployeeAdministration empAdmin;
        public FormStatistics(EmployeeAdministration empAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;

            chartGender.Series["Gender"].IsValueShownAsLabel = true;
            ShowCharts();

            foreach(Employee e in DatabaseHelper.GetAllEmployees())
            {
                cbEmployee.Items.Add(e.Name);
            }

            this.chartEmployeesDepartment.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.chartEmployeesDepartment.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            this.chartHoursWorked.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.chartHoursWorked.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;


        }

        public void ShowCharts()
        {
            //hours worked chart
            List<Employee> bestHoursEmployees = this.empAdmin.GetBestEmployeesByHoursWorked();
            for (int i = 0; i < bestHoursEmployees.Count(); i++)
            {
                chartHoursWorked.Series["Hours Worked"].Points.AddXY(bestHoursEmployees[i].Name, bestHoursEmployees[i].HoursWorked);
            }
            //gender chart
            int percentMale = this.empAdmin.GetAllEmployees().Count() - this.empAdmin.NrFemaleEmployees();
            int percentFemale = this.empAdmin.NrFemaleEmployees();
            chartGender.Series["Gender"].Points.AddXY("Female", percentFemale);
            chartGender.Series["Gender"].Points.AddXY("Male", percentMale);

            //employees/department chart

            int sales = this.empAdmin.NrOfEmployeesPerDepartment("SALES");
            int warehouse = this.empAdmin.NrOfEmployeesPerDepartment("WAREHOUSE");
            int photovideo = this.empAdmin.NrOfEmployeesPerDepartment("PHOTO&VIDEO");
            int pclaptops = this.empAdmin.NrOfEmployeesPerDepartment("PC&LAPTOPS");
            int chargerscables = this.empAdmin.NrOfEmployeesPerDepartment("CHARGERS&CABLES");

            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Sales", sales);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Warehouse", warehouse);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Photo & Video", photovideo);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("PC & Laptops", pclaptops);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Chargers & Cables", chargerscables);

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormsContent.Controls.Add(childForm);
            panelFormsContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStatisticsEmp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbEmployee.Text) == false)
                {
                    Employee emp = null;
                    foreach (Employee em in DatabaseHelper.GetAllEmployees())
                    {
                        if (em.Name == cbEmployee.Text)
                        {
                            emp = em;
                            FormStatisticsEmployee formStatisticsEmployee = new FormStatisticsEmployee(this.empAdmin, emp);
                            openChildFormInPanel(formStatisticsEmployee);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an employee!");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an employee!");
            }
        }
    }
}
