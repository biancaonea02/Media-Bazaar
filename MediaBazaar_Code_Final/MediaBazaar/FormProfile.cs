using MediaBazaar.classes;
using MediaBazaar.forms;
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
    public partial class FormProfile : Form
    {
        private Manager managerLoggedIn;
        public FormProfile(Manager manager)
        {
            InitializeComponent();
            this.managerLoggedIn = manager;

            lblFullName.Text = managerLoggedIn.Name;
            lblJobPosition.Text = managerLoggedIn.Position;

            lblBirthdate.Text = managerLoggedIn.BirthDate.ToShortDateString();

            lblHolidayDays.Text = managerLoggedIn.HolidayDays.ToString();
            lblSickDays.Text = managerLoggedIn.SickDays.ToString();
            lblHourlyWageValue.Text = $"€{managerLoggedIn.HourlyWage.ToString()}";

        }
    }
}
