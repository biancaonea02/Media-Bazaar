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
    public partial class FormAddEmployee : Form
    {
        private DataGridView dataGrid;
        public FormAddEmployee(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;

            this.cbGender.Items.Add("MALE");
            this.cbGender.Items.Add("FEMALE");

            foreach(Department d in DatabaseHelper.GetAllDepartments())
            {
                cbDepartment.Items.Add(d.Name);
            }
        }

        private void AddEmployeesInDataGrid(DataGridView dataGrid)
        {
            //adding the columns in the data table
            dataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Hourly Wage");
            dataTable.Columns.Add("Hours Worked");
            dataTable.Columns.Add("Department");

            foreach (Employee employee in DatabaseHelper.GetAllEmployees())
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = employee.Id;
                row["Name"] = employee.Name;
                row["Email"] = employee.Email;
                row["Phone Number"] = employee.PhoneNumber;
                row["Hourly Wage"] = employee.HourlyWage;
                row["Hours Worked"] = employee.HoursWorked;
                row["Department"] = employee.Department;
                dataTable.Rows.Add(row);
            }
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int num = dataGrid.Rows.Add();
                dataGrid.Rows[num].Cells[0].Value = dataRow["Id"].ToString();
                dataGrid.Rows[num].Cells[1].Value = dataRow["Name"].ToString();
                dataGrid.Rows[num].Cells[2].Value = dataRow["Email"].ToString();
                dataGrid.Rows[num].Cells[3].Value = dataRow["Phone Number"].ToString();
                dataGrid.Rows[num].Cells[4].Value = dataRow["Hourly Wage"].ToString();
                dataGrid.Rows[num].Cells[5].Value = dataRow["Hours Worked"].ToString();
                dataGrid.Rows[num].Cells[6].Value = dataRow["Department"].ToString();

            }

        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
            String name = this.tbName.Text;
            String password = this.tbPassword.Text;
            String email = this.tbEmail.Text;
            String gender = this.cbGender.SelectedItem.ToString();
            String phoneNumber = this.tbPhoneNumber.Text;
            String address = this.tbAddress.Text;
            double hourlyWage = Convert.ToDouble(this.tbHourlyWage.Text);
            double hoursWorked = Convert.ToDouble(this.tbHoursWorked.Text);
            int maxMonthlyHours = Convert.ToInt32(this.tbMaxMonthlyHours.Text);
            int holidayDays = Convert.ToInt32(tbHolidayDays.Text);
            int sickDays = Convert.ToInt32(tbSickDays.Text);
            int day = Convert.ToInt32(tbDay.Text);
            int month = Convert.ToInt32(tbMonth.Text);
            int year = Convert.ToInt32(tbYear.Text);
            DateTime birthDate = new DateTime(year, month, day);
            String department = cbDepartment.SelectedItem.ToString();

            try
            {

                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(phoneNumber) || String.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Not all fields filled in!");
                }
                else if (!email.Contains('@'))
                {
                    MessageBox.Show("Email is not in the correct format.");

                }
                else
                {
                    DatabaseHelper.AddNewUser(name, email, gender.ToString(), (float)hourlyWage, address, phoneNumber, (float)hoursWorked, password, holidayDays, sickDays, birthDate, department, maxMonthlyHours);
                    DatabaseHelper.AddPrefferedShifts(email);
                    MessageBox.Show("The employee was successfully added!");
                    AddEmployeesInDataGrid(this.dataGrid);
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

    }
    
}
