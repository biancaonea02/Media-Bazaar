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
    public partial class AutomaticShiftAssignmentForm : Form
    {
        private ShiftAssignment automaticShiftAssignment;
        private PrefferedShiftsAdministration shiftAdmin;
        public AutomaticShiftAssignmentForm()
        {
            InitializeComponent();
            automaticShiftAssignment = new ShiftAssignment();
            this.shiftAdmin = new PrefferedShiftsAdministration();
        }

        private void btnAutomaticallyAssign_Click(object sender, EventArgs e)
        {
            DateTime startDate = calendarStartDate.SelectionStart;
            if(startDate.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show("Please start scheduling from MONDAY.");
            }
            else
            {
                automaticShiftAssignment.AutomaticScheduling(startDate, shiftAdmin);
                MessageBox.Show($"Automatic shifts scheduled from {startDate.ToShortDateString()} to {startDate.AddDays(4).ToShortDateString()}");
            }
        }
    }
}
   