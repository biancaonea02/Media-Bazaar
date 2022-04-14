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
    public partial class FormEmployees : Form
    {
        private EmployeeAdministration empAdmin;
        public FormEmployees(EmployeeAdministration empAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            AddEmployeesInDataGrid();
            foreach(Employee e in DatabaseHelper.GetAllEmployees())
            {
                cbEmployee.Items.Add(e.Name);
            }
        }

        private void AddEmployeesInDataGrid()
        {
            //adding the columns in the data table
            dataGridEmployees.Rows.Clear();
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
                int num = dataGridEmployees.Rows.Add();
                dataGridEmployees.Rows[num].Cells[0].Value = dataRow["Id"].ToString();
                dataGridEmployees.Rows[num].Cells[1].Value = dataRow["Name"].ToString();
                dataGridEmployees.Rows[num].Cells[2].Value = dataRow["Email"].ToString();
                dataGridEmployees.Rows[num].Cells[3].Value = dataRow["Phone Number"].ToString();
                dataGridEmployees.Rows[num].Cells[4].Value = dataRow["Hourly Wage"].ToString();
                dataGridEmployees.Rows[num].Cells[5].Value = dataRow["Hours Worked"].ToString();
                dataGridEmployees.Rows[num].Cells[6].Value = dataRow["Department"].ToString();

            }

        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(this.tbSearchId.Text);
            Employee emp = this.empAdmin.GetEmployeeById(searchId);
            if (emp != null)
            {
                FormSearchEmployeeById formSearchIdEmployee = new FormSearchEmployeeById(emp);
                formSearchIdEmployee.Show();
            }
            else
            {
                MessageBox.Show("The employee that you searched for does not exist. Please check the id again.");
            }
        }

        private void btnSearchName_Click_1(object sender, EventArgs e)
        {
            string nameSearch = this.tbSearchName.Text;
            List<Employee> employeeByName = new List<Employee>();

            foreach (Employee emp in DatabaseHelper.GetAllEmployees())
            {
                if (emp.Name.Contains(nameSearch) || emp.Name == nameSearch)
                {
                    employeeByName.Add(emp);
                }
            }

            if (employeeByName.Count() == 0)
            {
                MessageBox.Show("No employees with that name found. Please enter another name");
            }
            else
            {
                FormSearchEmployeeByName formSearchNameEmployee = new FormSearchEmployeeByName(employeeByName);
                formSearchNameEmployee.Show();
            }
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee(dataGridEmployees);
            formAddEmployee.Show();
        }

        private void btnRemoveEmployee_Click_1(object sender, EventArgs e)
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
                            FormRemoveEmployee formRemoveEmployee = new FormRemoveEmployee(emp, dataGridEmployees);
                            formRemoveEmployee.Show();
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

        private void btnUpdateEmployee_Click_1(object sender, EventArgs e)
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
                            FormUpdateEmployee formUpdateEmployee = new FormUpdateEmployee(emp, dataGridEmployees);
                            formUpdateEmployee.Show();
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

        private void btnAssign_Click(object sender, EventArgs e)
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
                            FormAssignEmployees formAssignEmployees = new FormAssignEmployees(this.empAdmin, emp);
                            formAssignEmployees.Show();
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
