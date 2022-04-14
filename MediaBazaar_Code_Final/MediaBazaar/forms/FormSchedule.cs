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
    public partial class FormSchedule : Form
    {
        private EmployeeAdministration empAdmin;
        private ProductAdministration prodAdmin;
        private Manager managerLoggedIn;

        public FormSchedule(EmployeeAdministration empAdmin, Manager m, ProductAdministration prodAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.prodAdmin = prodAdmin;
            this.managerLoggedIn = m;

            this.ScheduleTable.ForeColor = Color.Black;
            btnSeeShiftsToday.Visible = false;

            foreach(Employee employee in DatabaseHelper.GetAllEmployees())
            {
                cbEmployee.Items.Add(employee.Name);
            }

            AddShiftInTableBasedOnDate(DateTime.Today);
            lblDate.Text = DateTime.Today.ToShortDateString();
            btnSeeShiftsToday.Visible = false;
        }
        //methods

        private void AddShiftInTableBasedOnDate(DateTime date)
        {
            ScheduleTable.Rows.Clear();
            DataTable s = new DataTable();
            s.Columns.Add("Name");
            s.Columns.Add("Email");
            s.Columns.Add("Date");
            s.Columns.Add("Moment of the day");
            s.Columns.Add("Department");

            foreach (Shift sh in DatabaseHelper.GetAllShifts())
            {
                if (sh.Date == date)
                {
                    DataRow row = s.NewRow();
                    Employee e = this.empAdmin.GetEmployeeByNameEmail(sh.Name, sh.Email);
                    row["Name"] = e.Name;
                    row["Email"] = e.Email;
                    row["Date"] = sh.Date.ToShortDateString();
                    row["Moment of the day"] = sh.Sh;
                    row["Department"] = e.Department;
                    s.Rows.Add(row);
                }
            }

            foreach (DataRow dataRow in s.Rows)
            {
                int num = ScheduleTable.Rows.Add();
                ScheduleTable.Rows[num].Cells[0].Value = dataRow["Name"].ToString();
                ScheduleTable.Rows[num].Cells[1].Value = dataRow["Email"].ToString();
                ScheduleTable.Rows[num].Cells[2].Value = dataRow["Date"].ToString();
                ScheduleTable.Rows[num].Cells[3].Value = dataRow["Moment of the day"].ToString();
                ScheduleTable.Rows[num].Cells[4].Value = dataRow["Department"].ToString();

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ScheduleTable.Rows.Clear();
            lblSiftsOn.Visible = true;
            lblSiftsOn.Text = "Shifts on";
            lblDate.Visible = true;
            lblEmployeeName.Visible = false;
            DateTime date = Convert.ToDateTime(lblDate.Text).AddDays(-1);
            lblDate.Text = date.ToShortDateString();

            AddShiftInTableBasedOnDate(date);

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            ScheduleTable.Rows.Clear();
            ScheduleTable.Rows.Clear();
            lblSiftsOn.Visible = true;
            lblSiftsOn.Text = "Shifts on";
            lblDate.Visible = true;
            lblEmployeeName.Visible = false;
            DateTime date = Convert.ToDateTime(lblDate.Text).AddDays(1);
            lblDate.Text = date.ToShortDateString();

            AddShiftInTableBasedOnDate(date);
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                            FormAddShift addShift = new FormAddShift(empAdmin, emp.Id, ScheduleTable, lblDate);
                            addShift.Show();
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
                            FormUpdateShift formUpdateShift = new FormUpdateShift(empAdmin, emp.Id, ScheduleTable, lblDate);
                            formUpdateShift.Show();
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

        private void btnRemove_Click(object sender, EventArgs e)
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
                            FormRemoveShift removeShift = new FormRemoveShift(empAdmin, emp.Id, ScheduleTable, lblDate);
                            removeShift.Show();
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

        private void btnSeeShifts_Click(object sender, EventArgs e)
        {
            ScheduleTable.Rows.Clear();
            lblDate.Visible = true;
            lblSiftsOn.Visible = true;
            lblSiftsOn.Text = "Shifts on:";
            lblEmployeeName.Visible = false;
            DateTime date = monthCalendar1.SelectionStart;
            lblDate.Text = date.ToShortDateString();

            AddShiftInTableBasedOnDate(date);
        }

        private void btnSeeShiftsOfEmployee_Click(object sender, EventArgs e)
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
                            btnNext.Visible = false;
                            btnPrevious.Visible = false;
                            ScheduleTable.Rows.Clear();
                            btnSeeShiftsToday.Visible = true;
                            lblSiftsOn.Visible = false;
                            lblDate.Visible = false;
                            lblEmployeeName.Visible = true;
                            lblEmployeeName.Text = $"Shifts of {emp.Name}";

                            DataTable s = new DataTable();
                            s.Columns.Add("Name");
                            s.Columns.Add("Email");
                            s.Columns.Add("Date");
                            s.Columns.Add("Moment of the day");
                            s.Columns.Add("Department");

                            foreach (Shift shift in DatabaseHelper.GetAllShifts())
                            {
                                Employee empl = this.empAdmin.GetEmployeeByNameEmail(shift.Name, shift.Email);
                                if (emp.Name == empl.Name && emp.Email == empl.Email)
                                {
                                    DataRow row = s.NewRow();
                                    row["Name"] = emp.Name;
                                    row["Email"] = emp.Email;
                                    row["Date"] = shift.Date.ToShortDateString();
                                    row["Moment of the day"] = shift.Sh;
                                    row["Department"] = emp.Department;
                                    s.Rows.Add(row);
                                }
                            }

                            foreach (DataRow dataRow in s.Rows)
                            {
                                int num = ScheduleTable.Rows.Add();
                                ScheduleTable.Rows[num].Cells[0].Value = dataRow["Name"].ToString();
                                ScheduleTable.Rows[num].Cells[1].Value = dataRow["Email"].ToString();
                                ScheduleTable.Rows[num].Cells[2].Value = dataRow["Date"].ToString();
                                ScheduleTable.Rows[num].Cells[3].Value = dataRow["Moment of the day"].ToString();
                                ScheduleTable.Rows[num].Cells[4].Value = dataRow["Department"].ToString();
                            }
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

        private void btnSeeShiftsToday_Click(object sender, EventArgs e)
        {
            btnNext.Visible = true;
            btnPrevious.Visible = true;
            AddShiftInTableBasedOnDate(DateTime.Today);
            lblEmployeeName.Visible = false;
            lblDate.Visible = true;
            lblDate.Text = DateTime.Today.ToShortDateString();
            lblSiftsOn.Visible = true;
            lblSiftsOn.Text = "Shifts on:";
            btnSeeShiftsToday.Visible = false;
        }


    }
}
