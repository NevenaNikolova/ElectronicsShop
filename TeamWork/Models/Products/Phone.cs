using System;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;

namespace ElectronicsShop.Models.AbstractClasses
{
    public abstract class Phone : Product, IPhone
    {
        private string brand;
        private string model;
        private Colour colour;
        private BatteryType battery;
        private int displaySize;
        private double height;
        private double width;
        private double thickness;
        private string processor;


        public Phone(string productName, decimal price) : base(productName, price)
        {

        }

        public Phone(string productName, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, double height, double width, double thickness)
            : this(productName, price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Colour = colour;
            this.Battery = battery;
            this.DisplaySize = displaySize;
            this.Height = height;
            this.Width = width;
            this.Thickness = thickness;
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
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.height = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.width = value;
            }
        }
        public double Thickness
        {
            get { return this.thickness; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.thickness = value;
            }
        }

    }
}
