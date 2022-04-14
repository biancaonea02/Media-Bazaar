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
    public partial class FormRemoveProduct : Form
    {
        private ProductAdministration prodAdmin;
        private int id;
        private Product product;
        public FormRemoveProduct(ProductAdministration prodAdmin, int id)
        {
            InitializeComponent();
            this.prodAdmin = prodAdmin;
            this.id = id;
            foreach(Product p in DatabaseHelper.GetAllProducts())
            {
                if(p.Id == id)
                {
                    this.product = p;
                }
            }

            //adding information about that product in the textbox and listbox
            this.tbId.Text = this.id.ToString();
            this.lbProduct.Items.Clear();
            this.lbProduct.Items.Add(product);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            foreach (RestockRequest r in DatabaseHelper.GetAllStockRequests())
            {
                if (r.IdProduct == id && r.Status == "PENDING")
                {
                    DatabaseHelper.DeleteStockRequest(r.Id);
                }
            }
            DatabaseHelper.DeleteExistingProduct(this.id);
            MessageBox.Show("Product successfully removed!");
            this.Close();
        }
    }
}
