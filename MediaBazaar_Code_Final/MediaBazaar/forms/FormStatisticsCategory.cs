using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.classes;

namespace MediaBazaar.forms
{
    public partial class FormStatisticsCategory : Form
    {
        private ProductAdministration prodAdmin;
        private String category;
        public FormStatisticsCategory(ProductAdministration prodAdmin, String category)
        {
            InitializeComponent();
            this.prodAdmin = prodAdmin;
            this.category = category;
            label1.Text = $"{this.category} Category";
            String products = "";
            foreach(String s in this.prodAdmin.NameProductsCategory(this.category))
            {
                products = products + " " + s + ",";
            }
            products = products.Remove(products.Length - 1, 1);
            lblName.Text = products;
            lblInStock.Text = this.prodAdmin.QuantityCategory(this.category).ToString();
            lblSold.Text = this.prodAdmin.QuantitySoldCategory(this.category).ToString();
            lblProfit.Text = this.prodAdmin.ProfitCategory(this.category).ToString() + " euros";
            SeeCharts();
        }

        private void SeeCharts()
        {
            //Profit chart
            foreach(Product p in this.prodAdmin.GetProductsCategory(this.category))
            {
                double profit = p.QuantitySold * p.Price;
                chartProfitProduct.Series["Profit"].Points.AddXY(p.Name, profit);
            }

            //In stock and sold chart
            foreach (Product p in this.prodAdmin.GetProductsCategory(this.category))
            {
                int stock = p.Quantity;
                int sold = p.QuantitySold;
                chartStockSold.Series["In Stock"].Points.AddXY(p.Name, p.Quantity);
                chartStockSold.Series["Sold"].Points.AddXY(p.Name, p.QuantitySold);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            string directory = $"../../../Categories_Statistics/{category}_Statistics";
            // If directory does not exist, create it
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string fileName = $"../../../Categories_Statistics//{category}_Statistics/{category}_Statistics.txt";
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine($"Name: {label1.Text}");
                sw.WriteLine($"Products: {lblName.Text}");
                sw.WriteLine($"Number of sold products: {lblSold.Text}");
                sw.WriteLine($"Overall profit: {lblProfit.Text}");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error writing file");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

            string dir = $"../../../Categories_Statistics/{category}_Statistics/charts";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string pathChart1 = $"../../../Categories_Statistics//{category}_Statistics/charts/In_Stock_And_Sold_{category}.png";
            chartStockSold.SaveImage(pathChart1, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            string pathChart2 = $"../../../Categories_Statistics//{category}_Statistics/charts/Profit_Per_Product_{category}.png";
            chartProfitProduct.SaveImage(pathChart2, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            MessageBox.Show($"The overview of {category} was saved!");
        }
    }
}
