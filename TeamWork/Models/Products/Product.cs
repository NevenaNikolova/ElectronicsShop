using System;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models.Products
{
    public abstract class Product : IProduct
    {

        private string name;
        private decimal price;
        private int id;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else this.name = value;
            }
        }

        public virtual decimal Price
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

        public int ID
        {
            get;
        }

    }
}
