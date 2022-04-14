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
    public partial class FormUpdateDepartment : Form
    {
        private EmployeeAdministration empAdmin;
        private Department d;
        public FormUpdateDepartment(EmployeeAdministration empAdmin, Department d)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.d = d;

            tbName.Text = d.Name;
            tbPersonel.Text = d.RequiredPersonel.ToString();

        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            if (this.tbName.Text != this.d.Name || this.tbPersonel.Text != this.d.RequiredPersonel.ToString())
            {
                try
                {
                    this.d.Name = this.tbName.Text;
                    this.d.RequiredPersonel = Convert.ToInt32(tbPersonel.Text);

                    if (String.IsNullOrEmpty(this.tbName.Text) || String.IsNullOrEmpty(this.tbPersonel.Text))
                    {
                        MessageBox.Show("Not all fields filled in!");
                    }
                    else
                    {
                        foreach (Employee emp in this.empAdmin.EmployeesFromDepartment(d.Name))
                        {
                            DatabaseHelper.UpdateExistingEmployee(emp.Id, emp.Name, emp.Password, emp.Email, emp.Gender, emp.PhoneNumber, emp.Address, emp.HourlyWage, emp.HoursWorked, emp.BirthDate, emp.HolidayDays, emp.SickDays, tbName.Text, emp.MaxMonthlyHours);
                        }
                        DatabaseHelper.UpdateExistingDepartment(tbName.Text, Convert.ToInt32(tbPersonel.Text));
                        MessageBox.Show("The department was successfully updated!");
                        this.Close();
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Something went wrong with the formating of the input. Did you provide all the information?");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nothing is changed. The product will stay the same");
            }
        }
    }
}
