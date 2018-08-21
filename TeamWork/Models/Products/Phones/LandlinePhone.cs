using System;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.Products.Phones
{
    public class LandlinePhone : IPhone, IPrintable
    {
        private int analogueLines;
        private string name;
        private PhoneSize size;
        private decimal price;
        private int id;
        private int displaySize;
        private string model;
        private string brand;
        private const string ProductName = "LandlinePhone";

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
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
            private set
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
        }

        public BatteryType Battery { get; }

        public int DisplaySize
        {
            get { return this.displaySize; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
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
        public virtual string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid name!");
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
                    throw new ArgumentException("Too low price!");
                }
                else this.price = value;
            }
        }
        public int ID
        {
            get => this.id;
            set => this.id = value;
        }

        public LandlinePhone(decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size, int analogueLines) //bool wallMounting) 
        {
            this.Price = price;
            this.Brand = brand;
            this.Model = model;
            this.Colour = colour;
            this.Battery = battery;
            this.DisplaySize = displaySize;
            this.Size = size;
            this.AnalogueLines = analogueLines;
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
            return "\n-----------------------" + $"\nProduct: {this.GetType().Name}" + $"\nID: {this.ID}" + $"\nBrand: {this.Brand}" + $"\nModel: {this.Model}" + $"\nColor: {this.Colour}" +
                $"\nDisplay size: {this.DisplaySize}'" + $"\nHeight: {this.Size.Height}'" + $"\nWidth: {this.Size.Width}" +
                $"\nTickness: {this.Size.Thickness}'" + $"\nBattery: {this.Battery}" + $"\nAnalogueLines: {this.AnalogueLines}" + $"\nPrice: {this.Price}"
                + "\n-----------------------";
        }

    }
}
