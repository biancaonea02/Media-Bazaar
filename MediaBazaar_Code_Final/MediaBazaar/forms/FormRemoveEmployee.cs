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
    public partial class FormRemoveEmployee : Form
    {
        private Employee emp;
        private DataGridView dataGrid;
        public FormRemoveEmployee(Employee emp, DataGridView dataGrid)
        {
            InitializeComponent();
            this.emp = emp;
            this.dataGrid = dataGrid;

            this.lbId.Text = emp.Id.ToString();
            this.lbName.Text = emp.Name;
            this.lbEmail.Text = emp.Email;
            this.lbGender.Text = emp.Gender.ToString();
            this.lbPhoneNumber.Text = emp.PhoneNumber;
            this.lbAddress.Text = emp.Address;
            this.lbHourlyWage.Text = emp.HourlyWage.ToString();
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

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            foreach (FreeDay f in DatabaseHelper.GetAllFreeDays())
            {
                if (f.Id == emp.Id && f.Status == "PENDING")
                {
                    DatabaseHelper.DeleteFreeDayRequest(f.Id, f.Name, f.Email, f.Date, f.Shift, f.Reason, f.SickDay, "ACCEPTED");
                }
            }

            foreach(Shift sh in DatabaseHelper.GetAllShifts())
            {
                if(sh.Name == emp.Name && sh.Email == emp.Email)
                {
                    DatabaseHelper.DeleteExistingShift(sh.Id, sh.Name, sh.Email, sh.Date, sh.Sh, sh.EmployeeStatus);
                }
            }
            DatabaseHelper.DeleteExistingUser(emp.Id);
            DatabaseHelper.DeleteExistingPrefferedShifts(emp.Email);
            MessageBox.Show("Employee successfully removed!");
            AddEmployeesInDataGrid(this.dataGrid);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
