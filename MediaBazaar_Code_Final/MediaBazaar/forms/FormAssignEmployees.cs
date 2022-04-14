using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.classes;

namespace MediaBazaar.forms
{
    public partial class FormAssignEmployees : Form
    {
        private EmployeeAdministration empAdmin;
        private Employee emp;
        public FormAssignEmployees(EmployeeAdministration empAdmin, Employee emp)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.emp = emp;
            SeeInfo();
        }

        private void SeeInfo()
        {
            label4.Text = emp.Department;
            label1.Text = $"Assign {emp.Name} to a department";
            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                if (this.empAdmin.NrOfEmployeesPerDepartment(d.Name) < d.RequiredPersonel)
                {
                    cbDepartments.Items.Add(d.Name);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Department dep = this.empAdmin.GetDepartmentByName(cbDepartments.SelectedItem.ToString());

            DatabaseHelper.UpdateExistingEmployee(emp.Id, emp.Name, emp.Password, emp.Email, emp.Gender, emp.PhoneNumber, emp.Address, emp.HourlyWage, emp.HoursWorked, emp.BirthDate, emp.HolidayDays, emp.SickDays, dep.Name, emp.MaxMonthlyHours);
            MessageBox.Show("The employee was successfully assigned!");
            SeeInfo();
        }
    }
}
