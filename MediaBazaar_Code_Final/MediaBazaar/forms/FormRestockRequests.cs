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
    public partial class FormRestockRequests : Form
    {
        private EmployeeAdministration empAdmin;
        private Manager managerLoggedIn;
        private ProductAdministration prodAdmin;
        public FormRestockRequests(EmployeeAdministration empAdmin, Manager managerLoggedIn, ProductAdministration prodAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.managerLoggedIn = managerLoggedIn;
            this.prodAdmin = prodAdmin;
            ShowPendingRequests();
        }

        private void ShowPendingRequests()
        {
            lbRequests.Items.Clear();
            foreach (RestockRequest r in DatabaseHelper.GetAllStockRequests())
            {
                if (r.Status == "PENDING")
                {
                    lbRequests.Items.Add(r);
                }
            }
        }

        private void lbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RestockRequest request = (RestockRequest)lbRequests.SelectedItem;
                Product p = this.prodAdmin.GetProductById(request.IdProduct);
                this.tbProductName.Text = p.Name;
                this.tbQuantity.Text = request.Quantity.ToString();

            }

            catch
            {

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            RestockRequest request = (RestockRequest)lbRequests.SelectedItem;
            request.Status = "ACCEPTED";
            Product p = prodAdmin.GetProductById(request.IdProduct);
            p.Quantity = p.Quantity + request.Quantity;
            DatabaseHelper.UpdateExistingProduct(p.Id, p.Name, p.Category, p.Price, p.Description, p.Quantity, p.Distributor, p.EmailDistributor, p.PhoneNumberDistributor, p.QuantitySold);
            DatabaseHelper.UpdateRestockRequest(request.Id, "ACCEPTED");
            tbProductName.Clear();
            tbQuantity.Clear();
            ShowPendingRequests();
            MessageBox.Show("The request was successfully accepted!");
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            RestockRequest request = (RestockRequest)lbRequests.SelectedItem;
            request.Status = "DECLINED";
            DatabaseHelper.UpdateRestockRequest(request.Id, request.Status);
            tbProductName.Clear();
            tbQuantity.Clear();
            ShowPendingRequests();
            MessageBox.Show("The request was successfully accepted!");
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            ShowPendingRequests();
            groupBox1.Visible = true;
            groupBox2.Location = new Point(882, 333);
            label1.Text = "Pending Restock Requests";
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Location = new Point(882, 180);
            lbRequests.Items.Clear();
            foreach (RestockRequest r in DatabaseHelper.GetAllStockRequests())
            {
                if (r.Status == "ACCEPTED")
                {
                    lbRequests.Items.Add(r.ToString());
                }
            }

            label1.Text = "Accepted Restock Requests";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            lbRequests.Items.Clear();
            groupBox1.Visible = false;
            groupBox2.Location = new Point(882, 100);
            foreach (RestockRequest r in DatabaseHelper.GetAllStockRequests())
            {
                lbRequests.Items.Add(r.ToString());
            }

            label1.Text = "All Restock Requests";
        }

        private void btnDeclined_Click(object sender, EventArgs e)
        {
            lbRequests.Items.Clear();
            groupBox1.Visible = false;
            groupBox2.Location = new Point(615, 180);
            foreach (RestockRequest r in DatabaseHelper.GetAllStockRequests())
            {
                if (r.Status == "DECLINED")
                {
                    lbRequests.Items.Add(r.ToString());
                }
            }

            label1.Text = "Declined Restock Requests";
        }
    }
}
