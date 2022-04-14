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
    public partial class FormDepartments : Form
    {
        private EmployeeAdministration empAdmin;
        public FormDepartments(EmployeeAdministration empAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            ShowDepartments();

        }

        private void ShowDepartments()
        {
            lbDepartments.Items.Clear();
            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                lbDepartments.Items.Add(d);
            }
        }

        private void btnViewAllDepartments_Click(object sender, EventArgs e)
        {
            ShowDepartments();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            FormAddDepartment formAddDepartment = new FormAddDepartment();
            formAddDepartment.Show();
        }


        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Department d = (Department)lbDepartments.SelectedItem;
                if (d == null)
                {
                    MessageBox.Show("Please select a department!");
                }
                else
                {
                    FormRemoveDepartment formRemoveDepartment = new FormRemoveDepartment(this.empAdmin, d);
                    formRemoveDepartment.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a department!");
            }
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Department d = (Department)lbDepartments.SelectedItem;
                if(d == null)
                {
                    MessageBox.Show("Please select a department!");
                }
                else
                {
                    FormUpdateDepartment formUpdateDepartment = new FormUpdateDepartment(this.empAdmin, d);
                    formUpdateDepartment.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a department!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nameSearch = this.tbSearchDepartment.Text;
            List<Department> depByName = new List<Department>();

            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                if (d.Name.Contains(nameSearch) || d.Name == nameSearch)
                {
                    depByName.Add(d);
                }
            }
            if (depByName.Count() == 0)
            {
                MessageBox.Show("No departments found. Please enter another name");
            }
            else
            {
                FormSearchDepartment formSearchDepartment = new FormSearchDepartment(this.empAdmin, depByName);
                formSearchDepartment.Show();
            }
        }
    }
}
