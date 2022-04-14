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
    public partial class FormSchedulePerDepartment : Form
    {
        private EmployeeAdministration empAdmin;
        public FormSchedulePerDepartment(EmployeeAdministration empAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.ScheduleTable.ForeColor = Color.Black;

            foreach(Department d in DatabaseHelper.GetAllDepartments())
            {
                cbDepartments.Items.Add(d);
            }

            cbDepartments.Text = this.empAdmin.GetDepartmentByName("SALES").ToString();

            //first show the sales department schedule for today
            lblDate.Text = DateTime.Today.ToShortDateString();
            AddShiftInTableBasedOnDate(DateTime.Today, this.empAdmin.GetDepartmentByName("SALES"));
        }

        private void AddShiftInTableBasedOnDate(DateTime date, Department d)
        {
            Department dep = (Department)cbDepartments.SelectedItem;
            lblDep.Text = dep.Name + " Department";
            ScheduleTable.Rows.Clear();
            DataTable s = new DataTable();
            s.Columns.Add("Name");
            s.Columns.Add("Email");
            s.Columns.Add("Date");
            s.Columns.Add("Moment of the day");

            foreach (Shift sh in DatabaseHelper.GetAllShifts())
            {
                Employee emp = this.empAdmin.GetEmployeeByNameEmail(sh.Name, sh.Email);
                if (sh.Date == date && emp.Department == d.Name)
                {
                    DataRow row = s.NewRow();
                    row["Name"] = emp.Name;
                    row["Email"] = emp.Email;
                    row["Date"] = sh.Date.ToShortDateString();
                    row["Moment of the day"] = sh.Sh;
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
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ScheduleTable.Rows.Clear();
            lblSiftsOn.Visible = true;
            lblSiftsOn.Text = "Shifts on";
            lblDate.Visible = true;
            DateTime date = Convert.ToDateTime(lblDate.Text).AddDays(-1);
            lblDate.Text = date.ToShortDateString();

            AddShiftInTableBasedOnDate(date, (Department)cbDepartments.SelectedItem);
        }

        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department d = (Department)cbDepartments.SelectedItem;
            lblDep.Text = d.Name + " Department";
            AddShiftInTableBasedOnDate(DateTime.Today, d);
            lblDate.Text = DateTime.Today.ToShortDateString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ScheduleTable.Rows.Clear();
            ScheduleTable.Rows.Clear();
            lblSiftsOn.Visible = true;
            lblSiftsOn.Text = "Shifts on";
            lblDate.Visible = true;
            DateTime date = Convert.ToDateTime(lblDate.Text).AddDays(1);
            lblDate.Text = date.ToShortDateString();

            AddShiftInTableBasedOnDate(date, (Department)cbDepartments.SelectedItem);
        }
    }
}
