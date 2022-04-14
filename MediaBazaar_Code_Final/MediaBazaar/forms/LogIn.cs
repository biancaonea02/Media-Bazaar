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
    public partial class LogIn : Form
    {
        private EmployeeAdministration empAdmin;
        private string emailUser;
        private string passwordUser;
        public LogIn()
        {
            InitializeComponent();
            this.empAdmin = new EmployeeAdministration("Employee Department");

        }

        private bool AuthenticationCheck()
        {
            Manager m = this.empAdmin.GetUserByEmailPassword(emailUser, passwordUser);
            if (m != null)
            {
                return true;
            }
            else
            {
               MessageBox.Show("The credentials are not correct. Please try again!");
                return false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                this.emailUser = this.tbEmailLogin.Text;
                this.passwordUser = this.tbPasswordLogin.Text;

                if (String.IsNullOrEmpty(this.emailUser) || String.IsNullOrEmpty(this.passwordUser))
                {
                    MessageBox.Show("Email or Password input is empty! Add your credentials there.");
                }
                else if (!this.emailUser.Contains('@'))
                {
                    MessageBox.Show("Email is not in the correct format.");
                }
                else
                {
                  if (AuthenticationCheck())
                  {
                        Manager managerLoggedIn = this.empAdmin.GetUserByEmailPassword(emailUser, passwordUser);

                        Form1 form = new Form1(this.empAdmin, managerLoggedIn);
                        form.Show();
                        this.tbEmailLogin.Clear();
                        this.tbPasswordLogin.Clear();
                  }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Something went wrong with the formating of the input. Did you provide the id?");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.ToString());
            }
        }
    }
}
