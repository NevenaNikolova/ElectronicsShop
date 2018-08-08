using System;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.Products
{
    public abstract class Phone : Product, IPhone
    {
        private string brand;
        private string model;
        private Colour colour;
        private BatteryType battery;
        private int displaySize;

        private string processor;

        private PhoneSize size;
        
        public Phone(string name, decimal price) : base(name, price)
        {

        }

        public Phone(string name, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size)
            : this(name, price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Colour = colour;
            this.Battery = battery;
            this.DisplaySize = displaySize;
            this.Size = size;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.brand = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.model = value;
            }
        }
        public Colour Colour
        {
            get;
            set;
        }

        public BatteryType Battery { get; set; }

        public int DisplaySize
        {
            get { return this.displaySize; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.displaySize = value;
            }
        }
        public PhoneSize Size { get; set; }
    }
}
