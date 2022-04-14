using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class Product : IComparable<Product>
    {
        //instance variables

        private int id;
        private String name;
        private String category;
        private double price;
        private String description;
        private String distributor;
        private String emailDistributor;
        private String phoneNumberDistributor;
        private int quantity;
        private int quantitySold;

        //properties

        public int Id { get { return this.id; } }
        public String Name { get { return this.name; } set { this.name = value; } }
        public String Category { get { return this.category; }  set { this.category = value; } }
        public double Price { get { return this.price; }  set { this.price = value; } }
        public String Description { get { return this.description; } set { this.description = value; } }
        public String Distributor { get { return this.distributor; }  set { this.distributor = value; } }
        public String EmailDistributor { get { return this.emailDistributor; }  set { this.emailDistributor = value; } }
        public String PhoneNumberDistributor { get { return this.phoneNumberDistributor; }  set { this.phoneNumberDistributor = value; } }

        public int Quantity { get { return this.quantity; }  set { this.quantity = value; } }
        public int QuantitySold { get { return this.quantitySold; } set { this.quantitySold = value; } }


        //constructors
        public Product(int id, String name, String category, double price, String description, int quantity, String distributor, String emailDistributor, String phoneNrDistributor, int quantitySold)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
            this.distributor = distributor;
            this.emailDistributor = emailDistributor;
            this.phoneNumberDistributor = phoneNrDistributor;
            this.quantitySold = quantitySold;
        }

        //methods

        public override string ToString()
        {
            return $"{id},{name},{category},{price},{description},{distributor},{emailDistributor},{phoneNumberDistributor}";
        }

        public int CompareTo(Product other)
        {
            int result = this.quantity.CompareTo(other.Quantity);
            if(result != 0)
            {
                return result;
            }

            return 0;
        }
    }
}
