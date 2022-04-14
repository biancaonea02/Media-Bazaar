using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class RestockRequest
    {
        private int id;
        private int idProduct;
        private int quantity;
        private DateTime date;
        private String status;

        public RestockRequest(int id, int idP, int quantity, DateTime date, String status)
        {
            this.id = id;
            this.idProduct = idP;
            this.quantity = quantity;
            this.date = date;
            this.status = status;
        }

        public String Status { get { return this.status; }  set { this.status = value; } }
        public int IdProduct { get { return this.idProduct; } }
        public int Quantity { get { return this.quantity; } }
        public DateTime Date { get { return this.date; } }
        public int Id { get { return this.id; } }

        public override string ToString()
        {
            return $"{this.status}: Product ID: {this.idProduct}, quantity: {this.quantity}, date: {this.date.ToShortDateString()}";
        }


    }
}
