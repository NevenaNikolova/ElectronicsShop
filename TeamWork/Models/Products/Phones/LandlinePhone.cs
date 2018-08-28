using System;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Core.Tools;

namespace ElectronicsShop.Models.Products.Phones
{
    public class LandlinePhone : ILandlinePhone, IPrintable
    {
        private int analogueLines;
        private PhoneSize size;
        private decimal price;
        private int id;
        private int displaySize;
        private string model;
        private string brand;

        public LandlinePhone(string brand, string model, string colour, int displaySize, PhoneSize size, int analogueLines, decimal price)
        {
            this.ID = id;
            this.Brand = brand;
            this.Model = model;
            this.Colour = colour;
            this.DisplaySize = displaySize;
            this.Size = size;
            this.AnalogueLines = analogueLines;
            this.Price = price;

        }
        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {                  
                    throw new ArgumentNullException("The brand should be specified!");
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The model should be specified!");
                }
                this.model = value;
            }
        }
        public string Colour
        {
            get;
        }
        public int DisplaySize
        {
            get { return this.displaySize; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The display size must be a positive number!");
                }
                this.displaySize = value;
            }
        }
        public PhoneSize Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public string Name
        {
            get { return this.GetType().Name; }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be a positive number!");
                }
                else this.price = value;
            }
        }
        public int ID
        {
            get => this.id;
            set => this.id = IdProvider.Instance().GetID();
        }



        public int AnalogueLines
        {
            get { return this.analogueLines; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of analogue lines should be positive!");
                }
                this.analogueLines = value;
            }
        }

        public string Print()
        {
            return "\n-----------------------" + $"\nProduct: {this.GetType().Name}" + $"\nID: {this.ID}" + $"\nBrand: {this.Brand}" + $"\nModel: {this.Model}" + $"\nColour: {this.Colour}" +
                $"\nDisplay size: {this.DisplaySize}'" + $"\nHeight: {this.Size.Height}'" + $"\nWidth: {this.Size.Width}" +
                $"\nTickness: {this.Size.Thickness}'" + $"\nAnalogueLines: {this.AnalogueLines}" + $"\nPrice: {this.Price}"
                + "\n-----------------------";
        }

    }
}
