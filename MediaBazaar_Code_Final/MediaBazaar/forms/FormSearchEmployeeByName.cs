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
    public partial class FormSearchEmployeeByName : Form
    {
        List<Employee> employeeByName;
        public FormSearchEmployeeByName(List<Employee> employeeByName)
        {
            InitializeComponent();
            this.employeeByName = employeeByName;

            foreach (Employee e in employeeByName)
            {
                cbEmployeesByName.Items.Add(e);
            }
        }

        private void btnShowOfSelected_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)cbEmployeesByName.SelectedItem;

            this.lblId.Text = emp.Id.ToString();
            this.lblName.Text = emp.Name;
            this.lblEmail.Text = emp.Email;
            this.lblGender.Text = emp.Gender.ToString();
            this.lblPhoneNumber.Text = emp.PhoneNumber;
            this.lblAddress.Text = emp.Address;
            this.lblHourlyWage.Text = emp.HourlyWage.ToString();
            this.lblHoursWorked.Text = emp.HoursWorked.ToString();
        }
    }
}
