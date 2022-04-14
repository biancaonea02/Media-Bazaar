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
    public partial class FormStatisticsInventory : Form
    {
        private EmployeeAdministration empAdmin;
        private Manager managerLoggedIn;
        private ProductAdministration prodAdmin;
        public FormStatisticsInventory(EmployeeAdministration empAdmin, Manager managerLoggedIn, ProductAdministration prodAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.managerLoggedIn = managerLoggedIn;
            this.prodAdmin = prodAdmin;

            chartCategoryQuantity.Series["CategoryQuantity"].IsValueShownAsLabel = true;
            ShowCharts();
        }

        public void ShowCharts()
        {
            //category and quantity chart
            int laptops = prodAdmin.QuantityCategory("LAPTOPS");
            int speakers = prodAdmin.QuantityCategory("SPEAKERS");
            int games = prodAdmin.QuantityCategory("GAMES");
            int consoles = prodAdmin.QuantityCategory("CONSOLES");
            int headphones = prodAdmin.QuantityCategory("HEADPHONES");
            int cables = prodAdmin.QuantityCategory("CABLES");
            int charges = prodAdmin.QuantityCategory("CHARGERS");
            int accessories = prodAdmin.QuantityCategory("ACCESSORIES");

            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Laptops", laptops);
            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Speakers", speakers);
            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Games", games);
            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Consoles", consoles);
            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Headphones", headphones);
            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Cables", cables);
            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Chargers", charges);
            chartCategoryQuantity.Series["CategoryQuantity"].Points.AddXY("Accessories", accessories);

            //top quantity chart
            List<Product> topquantity = this.prodAdmin.Top5ProductsByQuantity();
            for (int i = 0; i < topquantity.Count(); i++)
            {
                chartTopQuantity.Series["Quantity"].Points.AddXY(topquantity[i].Name, topquantity[i].Quantity);
            }

            //quantity sold chart
            int laptopsQ = prodAdmin.QuantityCategory("LAPTOPS");
            int speakersQ = prodAdmin.QuantityCategory("SPEAKERS");
            int gamesQ = prodAdmin.QuantityCategory("GAMES");
            int consolesQ = prodAdmin.QuantityCategory("CONSOLES");
            int headphonesQ = prodAdmin.QuantityCategory("HEADPHONES");
            int cablesQ = prodAdmin.QuantityCategory("CABLES");
            int chargesQ = prodAdmin.QuantityCategory("CHARGERS");
            int accessoriesQ = prodAdmin.QuantityCategory("ACCESSORIES");

            chartQuantSold.Series["Products sold"].Points.AddXY("Laptops", laptopsQ);
            chartQuantSold.Series["Products sold"].Points.AddXY("Speakers", speakersQ);
            chartQuantSold.Series["Products sold"].Points.AddXY("Games", gamesQ);
            chartQuantSold.Series["Products sold"].Points.AddXY("Consoles", consolesQ);
            chartQuantSold.Series["Products sold"].Points.AddXY("Headphones", headphonesQ);
            chartQuantSold.Series["Products sold"].Points.AddXY("Cables", cablesQ);
            chartQuantSold.Series["Products sold"].Points.AddXY("Chargers", chargesQ);
            chartQuantSold.Series["Products sold"].Points.AddXY("Accessories", accessoriesQ);
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

        private void btnStatisticsCategory_Click_1(object sender, EventArgs e)
        {
            String category = "";
            try
            {
                if (string.IsNullOrEmpty(cbCategories.Text) == false)
                {
                    category = cbCategories.Text;
                    FormStatisticsCategory formStatisticsCategory = new FormStatisticsCategory(this.prodAdmin, category);
                    openChildFormInPanel(formStatisticsCategory);
                }
                else
                {
                    MessageBox.Show("Please select a category!");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a category!");
            }
        }
    }
}
