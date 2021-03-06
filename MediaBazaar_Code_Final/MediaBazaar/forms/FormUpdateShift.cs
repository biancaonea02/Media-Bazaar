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
    public partial class FormUpdateShift : Form
    {
        private EmployeeAdministration empAdmin;
        private int id;
        private DataGridView ScheduleTable;
        private DateTime currentDate;
        private Employee emp;
        public FormUpdateShift(EmployeeAdministration empAdmin, int id, DataGridView ScheduleTable, Label lbl)
        {

            InitializeComponent();
            this.empAdmin = empAdmin;
            this.id = id;
            this.ScheduleTable = ScheduleTable;
            this.currentDate = Convert.ToDateTime(lbl.Text);
            this.emp = this.empAdmin.GetEmployeeById(this.id);

            foreach (Shift s in DatabaseHelper.GetAllShifts())
            {
                if (s.Name == emp.Name && s.Email == emp.Email)
                {
                    cbShiftsUpdate.Items.Add(s);
                }
            }
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
                    row["Name"] = emp.Name;
                    row["Email"] = emp.Email;
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

        private void btnUpdateShift_Click_1(object sender, EventArgs e)
        {
            Shift shiftToUpdate = (Shift)cbShiftsUpdate.SelectedItem;
            String momentOfTheDay = cbMoment.SelectedItem.ToString();

            if(DatabaseHelper.UpdateExistingShift(shiftToUpdate.Id, shiftToUpdate.Name, shiftToUpdate.Email, shiftToUpdate.Date, momentOfTheDay, shiftToUpdate.EmployeeStatus) == true)
            {
                AddShiftInTableBasedOnDate(currentDate);
                MessageBox.Show("The shift was succesfully updated!");
                this.Close();
            }
            else
            {
                MessageBox.Show("The shift couldn't be updated.");
            }
        }
    }
}
