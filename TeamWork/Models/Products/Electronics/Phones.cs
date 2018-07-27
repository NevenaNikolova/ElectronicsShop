using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models;
using TeamWork.Models.Products.Electronics.Common;

namespace TeamWork.Models.Electronics.AbstractClasses
{
    public abstract class Phones : Product
    {
        private string brand;
        private string model;
        private Colours colour;
        private BatteryType battery;
        private int displaySize;
        private double height;
        private double width;
        private double thickness;
       
        public Phones(string productName, decimal price, string brand, string model, Colours colour, BatteryType battery, int displaySize, double height, double width, double thickness) 
            : base(productName, price)
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
    }
}
