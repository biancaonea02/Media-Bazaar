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
    public partial class FormUpdateProduct : Form
    {
        private ProductAdministration prodAdmin;
        private int id;
        private Product product;
        public FormUpdateProduct(ProductAdministration prodAdmin, int id)
        {
            InitializeComponent();
            this.prodAdmin = prodAdmin;
            this.id = id;
            this.product = this.prodAdmin.GetProductById(this.id);

            this.cbCategory.Items.Add("LAPTOPS");
            this.cbCategory.Items.Add("SPEAKERS");
            this.cbCategory.Items.Add("GAMES");
            this.cbCategory.Items.Add("CONSOLES");
            this.cbCategory.Items.Add("HEADPHONES");
            this.cbCategory.Items.Add("CABLES");
            this.cbCategory.Items.Add("CHARGES");
            this.cbCategory.Items.Add("ACCESSORIES");

            ShowInfoProduct();
        }
        public void ShowInfoProduct()
        {
            this.lblId.Text = this.id.ToString();
            this.tbName.Text = this.product.Name;
            this.cbCategory.SelectedItem = this.product.Category;
            this.tbPrice.Text = this.product.Price.ToString();
            this.tbQuantity.Text = this.product.Quantity.ToString();
            this.tbDescription.Text = this.product.Description;
            this.tbDistributorName.Text = this.product.Distributor;
            this.tbDistributorEmail.Text = this.product.EmailDistributor;
            this.tbPhoneNumber.Text = this.product.PhoneNumberDistributor;

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            String category = this.cbCategory.SelectedItem.ToString();

            if (this.tbName.Text != this.product.Name || category != this.product.Category || this.tbPrice.Text != this.product.Price.ToString()
                || this.tbQuantity.Text != this.product.Quantity.ToString() || this.tbDescription.Text != this.product.Description ||
                this.tbDistributorName.Text != this.product.Distributor || this.tbDistributorEmail.Text != this.product.EmailDistributor ||
                this.tbPhoneNumber.Text != this.product.PhoneNumberDistributor)
            {
                try
                {
                    this.product.Name = this.tbName.Text;
                    this.product.Category = category;
                    this.product.Price = Convert.ToInt32(this.tbPrice.Text);
                    this.product.Quantity = Convert.ToInt32(this.tbQuantity.Text);
                    this.product.Description = this.tbDescription.Text;
                    this.product.Distributor = this.tbDistributorName.Text;
                    this.product.EmailDistributor = this.tbDistributorEmail.Text;
                    this.product.PhoneNumberDistributor = this.tbPhoneNumber.Text;

                    if (String.IsNullOrEmpty(this.tbName.Text) || String.IsNullOrEmpty(this.cbCategory.Text) ||
                        String.IsNullOrEmpty(this.tbDescription.Text) || String.IsNullOrEmpty(this.tbDistributorEmail.Text) ||
                        String.IsNullOrEmpty(this.tbDistributorName.Text) || String.IsNullOrEmpty(this.tbPhoneNumber.Text))
                    {
                        MessageBox.Show("Not all fields filled in!");
                    }
                    else
                    {
                        DatabaseHelper.UpdateExistingProduct(this.id, this.tbName.Text, category, Convert.ToDouble(this.tbPrice.Text), this.tbDescription.Text, Convert.ToInt32(this.tbQuantity.Text), this.tbDistributorName.Text, this.tbDistributorEmail.Text, this.tbPhoneNumber.Text, this.product.QuantitySold);
                        MessageBox.Show("The product was successfully updated!");
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
            else
            {
                MessageBox.Show("Nothing is changed. The product will stay the same");
            }
        }
    }
}
