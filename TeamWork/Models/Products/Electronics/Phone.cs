using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models;
using TeamWork.Models.Interfaces;
using TeamWork.Models.Products.Electronics.Common;

namespace TeamWork.Models.Electronics.AbstractClasses
{
    public abstract class Phone : Product, IPhone
    {
        private string brand;
        private string model;
        private Colours colour;
        private BatteryType battery;
        private int displaySize;
        private double height;
        private double width;
        private double thickness;

        public Phone(string productName, decimal price) : base(productName, price)
        {

        }

        public Phone(string productName, decimal price, string brand, string model, Colours colour, BatteryType battery, int displaySize, double height, double width, double thickness)
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
                this.brand = model;
            }
        }
        public Colours Colour { get; set; }

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
        public override string ToString()
        {
            return string.Format("Phone: {0}, price: {1}, brand: {2}, model: {3}, colour: {4}, battery: {5}, display size: {6}, height: {7}, width: {8}, thickness: {9}",
                this.ProductName, this.Price, this.Brand, this.Model, this.Colour, this.Battery, this.DisplaySize, this.Height, this.Width, this.Thickness);
        }       
    }
}
