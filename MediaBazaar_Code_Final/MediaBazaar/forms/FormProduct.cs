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
    public partial class FormProduct : Form
    {
        private ProductAdministration prodAdmin;
        private EmployeeAdministration empAdmin;
        private Manager managerLoggedIn;
       

        public FormProduct(ProductAdministration prodAdmin, Manager m, EmployeeAdministration empAdmin)
        {
            InitializeComponent();
            this.prodAdmin = prodAdmin;
            this.empAdmin = empAdmin;
            this.managerLoggedIn = m;
            ShowAllProductsInListbox();
        }

        public void ShowAllProductsInListbox()
        {
            this.lbProducts.Items.Clear();
            foreach(Product product in DatabaseHelper.GetAllProducts())
            {
                this.lbProducts.Items.Add(product);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct addProduct = new FormAddProduct(this.prodAdmin, this.lbProducts);
            addProduct.Show();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)lbProducts.SelectedItem;
            int id = product.Id;
            FormRemoveProduct removeProduct = new FormRemoveProduct(this.prodAdmin, id);
            removeProduct.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = (Product)lbProducts.SelectedItem;
            int id = product.Id;
            FormUpdateProduct updateProduct = new FormUpdateProduct(this.prodAdmin, id);
            updateProduct.Show();
        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            ShowAllProductsInListbox();
        }
        private void btnSearchByProductName_Click(object sender, EventArgs e)
        {
            string nameSearch = this.tbSearchProduct.Text;
            List<Product> productByName = new List<Product>();

            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Name.Contains(nameSearch) || p.Name == nameSearch)
                {
                    productByName.Add(p);
                }
            }
            if (productByName.Count() == 0)
            {
                MessageBox.Show("No products with that name found. Please enter another name");
            }
            else
            {
                FormSearchProductByName formSearchNameProduct = new FormSearchProductByName(productByName);
                formSearchNameProduct.Show();
            }
        }
    }
}
