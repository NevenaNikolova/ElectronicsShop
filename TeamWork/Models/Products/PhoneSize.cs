using System;

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
                    throw new ArgumentOutOfRangeException("The height should be a possitive number!");
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
                    throw new ArgumentOutOfRangeException("The width should be a possitive number!");
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
                    throw new ArgumentOutOfRangeException("The thickness should be a possitive number!");
                }
                this.thickness = value;
            }
        }
    }
}
