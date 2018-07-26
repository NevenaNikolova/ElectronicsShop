using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models
{
    public abstract class Product : IProducts 
    {
        private string productName;
        private decimal price;

        public Product(string name, int price)
        {
            this.ProductName = name;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

    }
}
