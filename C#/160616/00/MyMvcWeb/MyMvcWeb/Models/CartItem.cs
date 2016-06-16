using System;
using System.Collections.Generic;
using System.Web;

namespace MyMvcWeb.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

        private double price;
        public double Price
        {
            get { return this.price; }
            set { 
                this.price = value;
                this.subTotal = this.price * this.quantity;
            }
        }

        private int quantity;
        public int Quantity
        {
            get { return this.quantity; }
            set { 
                this.quantity = value;
                this.subTotal = this.price * this.quantity;
            }
        }

        private double subTotal;
        public double SubTotal
        {
            get { return this.subTotal; }            
        }


    }
}