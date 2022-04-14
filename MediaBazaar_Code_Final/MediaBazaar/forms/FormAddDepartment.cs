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
    public partial class FormAddDepartment : Form
    {
        public FormAddDepartment()
        {
            InitializeComponent();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            String name = "";
            int requiredPersonel = 0;

            try
            {
                name = tbName.Text;
                requiredPersonel = Convert.ToInt32(tbRequiredPersonel.Text);
                foreach(Department d in DatabaseHelper.GetAllDepartments())
                {
                    if(d.Name == name)
                    {
                        throw new ExistingDepartmentName("A department with the provided name already exists.");
                    }
                }

                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(requiredPersonel.ToString()))
                {
                    MessageBox.Show("Not all are fields filled in!");
                }
                else
                {
                    DatabaseHelper.AddDepartment(name, requiredPersonel);
                    MessageBox.Show("The department was successfully added!");
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Something went wrong with the formating of the input. Did you provide all the information?");
            }
            catch (ExistingDepartmentName ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
