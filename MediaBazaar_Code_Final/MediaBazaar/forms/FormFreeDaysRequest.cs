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
    public partial class FormFreeDaysRequest : Form
    {
        private EmployeeAdministration empAdmin;
        public FormFreeDaysRequest(EmployeeAdministration empAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            ShowPendingRequestsInListBox();
        }

        private void ShowPendingRequestsInListBox()
        {
            lbRequests.Items.Clear();
            foreach (FreeDay f in DatabaseHelper.GetAllFreeDays())
            {
                if (f.Status == "PENDING")
                {
                    lbRequests.Items.Add(f);
                }
            }
        }


        private void lbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FreeDay freeDay = (FreeDay)lbRequests.SelectedItem;
                Employee emp = this.empAdmin.GetEmployeeByNameEmail(freeDay.Name, freeDay.Email);
                this.tbName.Text = emp.Name;
                this.tbDate.Text = freeDay.Date.ToShortDateString();
            }

            catch
            {

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FreeDay freeDays = (FreeDay)lbRequests.SelectedItem;
            if (DatabaseHelper.UpdateExistingFreeDay(freeDays.Id, freeDays.Name, freeDays.Email, freeDays.Date, freeDays.Shift, freeDays.Reason, freeDays.SickDay, "ACCEPTED") == true)
            {
                Employee emp = this.empAdmin.GetEmployeeByNameEmail(freeDays.Name, freeDays.Email);
                foreach(Shift sh in DatabaseHelper.GetAllShifts())
                {
                    if(sh.Name == emp.Name && sh.Email == emp.Email && sh.Date == freeDays.Date)
                    {
                        DatabaseHelper.DeleteExistingShift(sh.Id, sh.Name, sh.Email, sh.Date, sh.Sh, sh.EmployeeStatus);
                    }
                }
                MessageBox.Show("The request was succesfully accepted!");
                tbName.Clear();
                tbDate.Clear();
            }
            ShowPendingRequestsInListBox();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            FreeDay freeDays = (FreeDay)lbRequests.SelectedItem;
            if (DatabaseHelper.UpdateExistingFreeDay(freeDays.Id, freeDays.Name, freeDays.Email, freeDays.Date, freeDays.Shift, freeDays.Reason, freeDays.SickDay, "DECLINED") == true)
            {
                MessageBox.Show("The request was succesfully declined!");
                tbName.Clear();
                tbDate.Clear();
            }
            ShowPendingRequestsInListBox();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Location = new Point(700, 180);
            label1.Text = "All Free Days Requests";
            lbRequests.Items.Clear();
            foreach (FreeDay f in DatabaseHelper.GetAllFreeDays())
            {
                lbRequests.Items.Add(f);
            }
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Location = new Point(700, 180);
            label1.Text = "Accepted Free Days Requests";
            lbRequests.Items.Clear();
            foreach (FreeDay f in DatabaseHelper.GetAllFreeDays())
            {
                if (f.Status == "ACCEPTED")
                {
                    lbRequests.Items.Add(f);
                }
            }
        }

        private void btnDeclined_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Location = new Point(700, 180);
            label1.Text = "Declined Free Days Requests";
            lbRequests.Items.Clear();
            foreach (FreeDay f in DatabaseHelper.GetAllFreeDays())
            {
                if (f.Status == "DECLINED")
                {
                    lbRequests.Items.Add(f);
                }
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Location = new Point(700, 180);
            label1.Text = "Pending Free Days Requests";
            ShowPendingRequestsInListBox();
        }
    }
}
