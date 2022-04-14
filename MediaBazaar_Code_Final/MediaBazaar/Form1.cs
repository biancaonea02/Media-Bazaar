using MediaBazaar.classes;
using MediaBazaar.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class Form1 : Form
    {
        //data from the login form
        private Manager managerLoggedIn;

        private EmployeeAdministration empAdmin;
        private ProductAdministration prodAdmin;
        public Form1(EmployeeAdministration empAdmin, Manager managerLoggedIn)
        {
            InitializeComponent();
            //shift assignment form

            this.empAdmin = empAdmin;
            this.managerLoggedIn = managerLoggedIn;
            this.prodAdmin = new ProductAdministration("Product Department");

            if(managerLoggedIn.Position == "inventory manager")
            {
                pnlMenuProductM.Show();
                pnlMenuDepartmentM.Hide();
                pnlMenuEmployeeM.Hide();
                pnlMenuProductM.Dock = DockStyle.Left;
                pnlMenuProductM.Size = new Size(200, 654);
            }
            else if (managerLoggedIn.Position == "employee manager")
            {
                pnlMenuEmployeeM.Show();
                pnlMenuDepartmentM.Hide();
                pnlMenuProductM.Hide();
                pnlMenuEmployeeM.Dock = DockStyle.Left;
                pnlMenuEmployeeM.Size = new Size(265, 654);
            }
            else if (managerLoggedIn.Position == "department manager")
            {
                pnlMenuDepartmentM.Show();
                pnlMenuEmployeeM.Hide();
                pnlMenuProductM.Hide();
                pnlMenuDepartmentM.Dock = DockStyle.Left;
                pnlMenuDepartmentM.Size = new Size(225, 654);
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
       

        /* PRODUCTS MANAGER */
        private void btnHomeP_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(this.empAdmin, managerLoggedIn);
            openChildFormInPanel(formHome);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(this.prodAdmin, managerLoggedIn, empAdmin);
            openChildFormInPanel(formProduct);
        }

        private void btnRestockRequests_Click(object sender, EventArgs e)
        {
            FormRestockRequests formRestockRequests = new FormRestockRequests(this.empAdmin, this.managerLoggedIn, this.prodAdmin);
            openChildFormInPanel(formRestockRequests);
        }

        private void btnStatisticsP_Click(object sender, EventArgs e)
        {
            FormStatisticsInventory formStatisticsInventory = new FormStatisticsInventory(this.empAdmin, this.managerLoggedIn, this.prodAdmin);
            openChildFormInPanel(formStatisticsInventory);
        }

        private void btnMyProfileP_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(managerLoggedIn);
            openChildFormInPanel(formProfile);
        }

        private void btnLogOutP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* EMPLOYEE MANAGER */
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(this.empAdmin, managerLoggedIn);
            openChildFormInPanel(formHome);
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            FormEmployees formManageEmployees = new FormEmployees(this.empAdmin);
            openChildFormInPanel(formManageEmployees);
        }

        private void btnScheduleEmployees_Click(object sender, EventArgs e)
        {
            FormSchedule formSchedule = new FormSchedule(this.empAdmin, managerLoggedIn, prodAdmin);
            openChildFormInPanel(formSchedule);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics(this.empAdmin);
            openChildFormInPanel(formStatistics);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(managerLoggedIn);
            openChildFormInPanel(formProfile);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* DEPARTMENTS MANAGER*/

        private void btnHomeD_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(this.empAdmin, managerLoggedIn);
            openChildFormInPanel(formHome);
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            FormDepartments formDepartments = new FormDepartments(this.empAdmin);
            openChildFormInPanel(formDepartments);
        }

        private void btnScheduleDepartment_Click(object sender, EventArgs e)
        {
            FormSchedulePerDepartment formSchedulePerDepartment = new FormSchedulePerDepartment(this.empAdmin);
            openChildFormInPanel(formSchedulePerDepartment);
        }

        private void btnStatisticsDep_Click(object sender, EventArgs e)
        {
            FormStatisticsDepartments formStatisticsDepartments = new FormStatisticsDepartments(this.empAdmin);
            openChildFormInPanel(formStatisticsDepartments);
        }

        private void btnMyProfileD_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(managerLoggedIn);
            openChildFormInPanel(formProfile);
        }

        private void btnLogOutD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFreeDaysRequests_Click(object sender, EventArgs e)
        {
            FormFreeDaysRequest formFreeDaysRequest = new FormFreeDaysRequest(this.empAdmin);
            openChildFormInPanel(formFreeDaysRequest);
        }

        private void btnAutomaticSchedule_Click(object sender, EventArgs e)
        {
            AutomaticShiftAssignmentForm auto = new AutomaticShiftAssignmentForm();
            openChildFormInPanel(auto);
        }
    }
}
