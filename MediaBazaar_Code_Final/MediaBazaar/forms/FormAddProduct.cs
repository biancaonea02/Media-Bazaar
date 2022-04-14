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

    public partial class FormAddProduct : Form
    {
        private ProductAdministration prodAdmin;
        private ListBox lbProducts;

        public FormAddProduct(ProductAdministration prodAdmin, ListBox lbProducts)
        {
            InitializeComponent();
            this.prodAdmin = prodAdmin;
            this.lbProducts = lbProducts;

            this.cbCategory.Items.Add("LAPTOPS");
            this.cbCategory.Items.Add("SPEAKERS");
            this.cbCategory.Items.Add("GAMES");
            this.cbCategory.Items.Add("CONSOLES");
            this.cbCategory.Items.Add("HEADPHONES");
            this.cbCategory.Items.Add("CABLES");
            this.cbCategory.Items.Add("CHARGES");
            this.cbCategory.Items.Add("ACCESSORIES");

        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            string name = this.tbName.Text;
            String category = this.cbCategory.SelectedItem.ToString();
            double price = Convert.ToInt32(this.tbPrice.Text);
            int quantity = Convert.ToInt32(this.tbQuantity.Text);
            string description = this.tbDescription.Text;
            string distributorName = this.tbDistributorName.Text;
            string distributorEmail = this.tbDistributorEmail.Text;
            string distributorPhone = this.tbPhoneNumber.Text;
            try
            {
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(category) || String.IsNullOrEmpty(description) || String.IsNullOrEmpty(distributorEmail) 
                    || String.IsNullOrEmpty(distributorName) || String.IsNullOrEmpty(distributorPhone))
                {
                    MessageBox.Show("Not all are fields filled in!");
                }
                else
                {
                    DatabaseHelper.AddProduct(name, category, price, description, quantity, distributorName, distributorEmail, distributorPhone, 0);
                    MessageBox.Show("The product was successfully added!");
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Something went wrong with the formating of the input. Did you provide all the information?");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.ToString());
            }

        }

    }
}
