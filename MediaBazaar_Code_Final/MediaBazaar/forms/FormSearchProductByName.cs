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
    public partial class FormSearchProductByName : Form
    {
        private List<Product> productByName;
        public FormSearchProductByName(List<Product> productByName)
        {
            InitializeComponent();
            this.productByName = productByName;
            foreach (Product p in this.productByName)
            {
                cbProductsByName.Items.Add(p);
            }
        }

        private void btnShowOfSelected_Click(object sender, EventArgs e)
        {
            Product p = (Product)cbProductsByName.SelectedItem;

            this.lblId.Text = p.Id.ToString();
            this.lblName.Text = p.Name;
            this.lblCategory.Text = p.Category.ToString();
            this.lblPrice.Text = p.Price.ToString();
            this.lblDescription.Text = p.Description;
            this.lblQuantity.Text = p.Quantity.ToString();
            this.lblDistributor.Text = p.Distributor;
            this.lblEmailDistributor.Text = p.EmailDistributor;
            this.lblPhoneDistributor.Text = p.PhoneNumberDistributor;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
