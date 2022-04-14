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
    public partial class FormRemoveDepartment : Form
    {
        private EmployeeAdministration empAdmin;
        private Department d;
        public FormRemoveDepartment(EmployeeAdministration empAdmin, Department d)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.d = d;
            lblName.Text = d.Name;
            lblPersonel.Text = d.RequiredPersonel.ToString();

            foreach(Employee e in this.empAdmin.EmployeesFromDepartment(d.Name))
            {
                lbEmployees.Items.Add(e.Name);
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            //remove department
            if(DatabaseHelper.DeleteExistingDepartment(d.Name, d.RequiredPersonel) == true)
            {
                MessageBox.Show("The department was successfully deleted.");
                foreach (Employee emp in this.empAdmin.EmployeesFromDepartment(d.Name))
                {
                    DatabaseHelper.UpdateExistingEmployee(emp.Id, emp.Name, emp.Password, emp.Email, emp.Gender, emp.PhoneNumber, emp.Address, emp.HourlyWage, emp.HoursWorked, emp.BirthDate, emp.HolidayDays, emp.SickDays, "UNASSIGNED", emp.MaxMonthlyHours);
                }

            }
        }
    }
}
