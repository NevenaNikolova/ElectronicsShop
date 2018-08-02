using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Products
{
    public struct PhoneSize
    {
        private double height;
        private double width;
        private double thickness;

        public PhoneSize(double height, double width, double thickness):this()
        {
            this.Height = height;
            this.Width = width;
            this.Thickness = thickness;

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
