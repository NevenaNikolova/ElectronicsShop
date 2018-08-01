using System;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Products
{
    public abstract class Product : IProduct
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
            set {
                if (value.Length<=0)
                {
                    throw new ArgumentOutOfRangeException();
                } else this.name = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("too low price!");
                }
                else this.price = value;
            }
        }

        public abstract string Print();
    }
}
