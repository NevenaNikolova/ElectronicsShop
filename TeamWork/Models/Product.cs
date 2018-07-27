using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models
{
    public abstract class Product : IProducts 
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

    }
}
