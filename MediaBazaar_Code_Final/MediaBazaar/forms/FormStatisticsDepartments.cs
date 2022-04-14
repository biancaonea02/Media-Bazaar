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
    public partial class FormStatisticsDepartments : Form
    {
        private EmployeeAdministration empAdmin;
        public FormStatisticsDepartments(EmployeeAdministration empAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;

            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                cbDep.Items.Add(d.Name);
            }

            chartRequiredPersonel.Series["Number of required personel"].IsValueShownAsLabel = true;
            ShowCharts();

            label5.Text = DatabaseHelper.GetAllDepartments().Count.ToString();

            int nr1 = 0;
            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                if (this.empAdmin.NrOfEmployeesPerDepartment(d.Name) < d.RequiredPersonel)
                {
                    nr1++;
                }
            }

            label6.Text = nr1.ToString();

            int nr = 0;
            foreach (Employee e in DatabaseHelper.GetAllEmployees())
            {
                if (e.Department != "UNASSIGNED")
                {
                    nr++;
                }
            }

            label7.Text = nr.ToString();
        }


        private void ShowCharts()
        {
            //nr of employees per department
            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                chartNrEmp.Series["Number of Employees"].Points.AddXY(d.Name, this.empAdmin.NrOfEmployeesPerDepartment(d.Name));
            }

            //required personel
            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                chartRequiredPersonel.Series["Number of required personel"].Points.AddXY(d.Name, d.RequiredPersonel);
            }


        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormsContent.Controls.Add(childForm);
            panelFormsContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStatisticsDepartment_Click(object sender, EventArgs e)
        {
            Department d = null;
            try
            {
                d = this.empAdmin.GetDepartmentByName(cbDep.SelectedItem.ToString());
                if (d != null)
                {
                    FormStatisticsDep formStatisticsDep = new FormStatisticsDep(this.empAdmin, d);
                    openChildFormInPanel(formStatisticsDep);
                }
                else
                {
                    MessageBox.Show("Please select a department!");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a department!");
            }
        }

    }
}
