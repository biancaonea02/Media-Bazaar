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
    public partial class FormSearchDepartment : Form
    {
        private List<Department> dep;
        private EmployeeAdministration empAdmin;
        public FormSearchDepartment(EmployeeAdministration empAdmin, List<Department> departments)
        {
            InitializeComponent();
            this.dep = departments;
            this.empAdmin = empAdmin;

            foreach (Department d in this.dep)
            {
                cbDepartments.Items.Add(d);
            }
        }

        private void btnShowOfSelected_Click(object sender, EventArgs e)
        {
            Department d = (Department)cbDepartments.SelectedItem;

            this.lblId.Text = d.Name;
            this.lblName.Text = d.RequiredPersonel.ToString();
            this.lblNr.Text = this.empAdmin.NrOfEmployeesPerDepartment(d.Name).ToString();

            lbEmployees.Items.Clear();
            foreach(Employee emp in this.empAdmin.EmployeesFromDepartment(d.Name))
            {
                lbEmployees.Items.Add(emp.Name);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
