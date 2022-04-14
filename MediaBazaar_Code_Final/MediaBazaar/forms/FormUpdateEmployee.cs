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
    public partial class FormUpdateEmployee : Form
    {
        private Employee emp;
        private DataGridView dataGrid;

        public FormUpdateEmployee(Employee emp, DataGridView dataGrid)
        {
            InitializeComponent();
            this.emp = emp;
            this.dataGrid = dataGrid;

            this.cbGender.Items.Add("MALE");
            this.cbGender.Items.Add("FEMALE");

            ShowEmployeeInfo();
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

        private void ShowEmployeeInfo()
        {
            this.tbName.Text = this.emp.Name;
            this.cbGender.SelectedItem = this.emp.Gender;
            this.tbPassword.Text = this.emp.Password;
            this.tbEmail.Text = this.emp.Email;
            this.tbPhoneNumber.Text = this.emp.PhoneNumber;
            this.tbAddress.Text = this.emp.Address;
            this.tbHourlyWage.Text = Convert.ToString(this.emp.HourlyWage);
            this.tbHoursWorked.Text = Convert.ToString(this.emp.HoursWorked);
            this.tbHolidayDays.Text = Convert.ToString(this.emp.HolidayDays);
            this.tbSickDays.Text = Convert.ToString(this.emp.SickDays);
            this.tbDay.Text = Convert.ToString(this.emp.BirthDate.Day);
            this.tbMonth.Text = Convert.ToString(this.emp.BirthDate.Month);
            this.tbYear.Text = Convert.ToString(this.emp.BirthDate.Year);
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            String gender = this.cbGender.SelectedItem.ToString();

            if (this.tbName.Text != this.emp.Name || gender != this.emp.Gender || this.tbPassword.Text != this.emp.Password
                || this.tbEmail.Text != this.emp.Email ||
                this.tbPhoneNumber.Text != this.emp.PhoneNumber || this.tbAddress.Text != this.emp.Address ||
                this.tbHourlyWage.Text != this.emp.HourlyWage.ToString() || this.tbHoursWorked.Text != this.emp.HourlyWage.ToString())
            {
                try
                {
                    this.emp.Name = this.tbName.Text;
                    this.emp.Gender = gender;
                    this.emp.Password = this.tbPassword.Text;
                    this.emp.Email = this.tbEmail.Text;
                    this.emp.PhoneNumber = this.tbPhoneNumber.Text;
                    this.emp.Address = this.tbAddress.Text;
                    this.emp.HourlyWage = Convert.ToDouble(this.tbHourlyWage.Text);
                    this.emp.HoursWorked = Convert.ToDouble(this.tbHoursWorked.Text);
                    this.emp.HolidayDays = Convert.ToInt32(this.tbHolidayDays.Text);
                    this.emp.SickDays = Convert.ToInt32(this.tbSickDays.Text);
                    int day = Convert.ToInt32(this.tbDay.Text);
                    int month = Convert.ToInt32(this.tbMonth.Text);
                    int year = Convert.ToInt32(this.tbYear.Text);
                    DateTime birthDate = new DateTime(year, month, day);
                    this.emp.BirthDate = birthDate;
                    if (String.IsNullOrEmpty(this.tbName.Text) || String.IsNullOrEmpty(this.tbPassword.Text) ||
                        String.IsNullOrEmpty(this.tbEmail.Text) || String.IsNullOrEmpty(this.tbPhoneNumber.Text) ||
                        String.IsNullOrEmpty(this.tbAddress.Text))
                    {
                        MessageBox.Show("Not all fields filled in!");
                    }
                    else if (!this.tbEmail.Text.Contains('@'))
                    {
                        MessageBox.Show("Email is not in the correct format.");

                    }
                    else
                    {
                        DatabaseHelper.UpdateExistingEmployee(this.emp.Id, this.tbName.Text, this.tbPassword.Text, this.tbEmail.Text, gender, this.tbPhoneNumber.Text,
                        this.tbAddress.Text, Convert.ToDouble(this.tbHourlyWage.Text), Convert.ToDouble(this.tbHoursWorked.Text), birthDate, Convert.ToInt32(this.tbHolidayDays.Text),
                        Convert.ToInt32(this.tbSickDays.Text), this.emp.Department, this.emp.MaxMonthlyHours);
                        MessageBox.Show("The employee was successfully updated!");
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
            else
            {
                MessageBox.Show("Nothing is changed. The employee will stay the same");
            }
        }
    }
}
