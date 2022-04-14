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
    public partial class FormAddShift : Form
    {
        private EmployeeAdministration empAdmin;
        private int id;
        private DataGridView ScheduleTable;
        Employee employee;
        private DateTime currentDate;
        public FormAddShift(EmployeeAdministration empAdmin, int id, DataGridView ScheduleTable, Label lbl)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.id = id;
            this.ScheduleTable = ScheduleTable;
            this.currentDate = Convert.ToDateTime(lbl.Text);

            employee = empAdmin.GetEmployeeById(id);

        }

        private void AddShiftInTableBasedOnDate(DateTime date)
        {
            ScheduleTable.Rows.Clear();
            DataTable s = new DataTable();
            s.Columns.Add("Name");
            s.Columns.Add("Email");
            s.Columns.Add("Date");
            s.Columns.Add("Moment of the day");

            foreach (Shift sh in DatabaseHelper.GetAllShifts())
            {
                if (sh.Date == date)
                {
                    DataRow row = s.NewRow();
                    Employee e = this.empAdmin.GetEmployeeByNameEmail(sh.Name, sh.Email);
                    row["Name"] = e.Name;
                    row["Email"] = e.Email;
                    row["Date"] = sh.Date;
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

        private void btnAddShift_Click_1(object sender, EventArgs e)
        {
            String momentOfDay = cbMomentOfDay.SelectedItem.ToString();
            DateTime dateTime = SelectDateCalendar.SelectionStart;
            DatabaseHelper.AddShift(employee.Name, employee.Email, dateTime, momentOfDay);
            MessageBox.Show("The shift was successfully added!");
            AddShiftInTableBasedOnDate(currentDate);
            this.Close();
        }
    }
}
