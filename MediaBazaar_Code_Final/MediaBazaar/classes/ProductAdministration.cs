using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class ProductAdministration
    {
        //instance variables
        private String name;

        //constructors
        public ProductAdministration(String name)
        {
            this.name = name;
        }

        //methods
        public Product GetProductById(int id)
        {
            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Id == id)
                { return p; }
            }
            return null;
        }

        public Product GetProductByName(String name)
        {
            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Name == name)
                { return p; }
            }
            return null;
        }

        public Product GetProductByPrice(double price)
        {
            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Price == price)
                { return p; }
            }
            return null;
        }

        public int QuantityCategory(String category)
        {
            int quantity = 0;
            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Category == category)
                {
                    quantity = quantity + p.Quantity;
                }
            }
            return quantity;
        }

        public int QuantitySoldCategory(String category)
        {
            int quantitySold = 0;
            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Category == category)
                {
                    quantitySold = quantitySold + p.QuantitySold;
                }
            }
            return quantitySold;
        }

        public List<Product> Top5ProductsByQuantity()
        {
            List<Product> temp = new List<Product>();
            DatabaseHelper.GetAllProducts().Sort();
            for(int i = DatabaseHelper.GetAllProducts().Count() - 1; i > DatabaseHelper.GetAllProducts().Count() - 6; i--)
            {
                temp.Add(DatabaseHelper.GetAllProducts()[i]);
            }

            return temp;
        }

        /* STATISTICS PER CATEGORY*/
        public List<String> NameProductsCategory(String category)
        {
            List<String> temp = new List<String>();
            foreach(Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Category == category)
                {
                    temp.Add(p.Name);
                }
            }

            return temp;
        }

        public double ProfitCategory(String category)
        {
            double profit = 0;
            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Category == category)
                {
                    profit = profit + p.QuantitySold * p.Price;
                }
            }

            return profit;
        }

        public List<Product> GetProductsCategory(String category)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in DatabaseHelper.GetAllProducts())
            {
                if (p.Category == category)
                {
                    temp.Add(p);
                }
            }

            return temp;
        }


    }
}
