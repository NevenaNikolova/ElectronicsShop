using System;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models.Products
{
    public abstract class Product : IProduct
    {

        private string name;
        private decimal price;
        private int realId;
        public static int staticID;

        private int StaticId
        {
            get { return staticID; }
            set { staticID++; }
        }

        public int RealID
        {
            get { return this.realId; }
            set { this.realId = staticID; }
        }
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            this.StaticId = staticID;
            this.RealID = realId;
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
