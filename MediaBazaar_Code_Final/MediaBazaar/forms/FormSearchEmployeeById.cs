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
    public partial class FormSearchEmployeeById : Form
    {
        Employee emp;
        public FormSearchEmployeeById(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;

            this.lblId.Text = this.emp.Id.ToString();
            this.lblName.Text = this.emp.Name;
            this.lblEmail.Text = this.emp.Email;
            this.lblGender.Text = this.emp.Gender.ToString();
            this.lblPhoneNumber.Text = this.emp.PhoneNumber;
            this.lblAddress.Text = this.emp.Address;
            this.lblHourlyWage.Text = this.emp.HourlyWage.ToString();
            this.lblHoursWorked.Text = this.emp.HoursWorked.ToString();


        }
    }
}
