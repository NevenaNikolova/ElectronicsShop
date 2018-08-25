using System;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.Products.Phones
{
    public class Smartphone : ISmartphone, IPrintable
    {
        private const string ProductName = "Smartphone";
        private int displaySize;
        private string processor;
        private int ram;
        private string brand;
        private string name;
        private decimal price;
        private int id;
        private string model;
        private BatteryType battery;
        private Colour colour;
        private PhoneSize size;

        public int Ram
        {
            get
            {
                return this.ram;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value must be positive!");
                }
                this.ram = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The processor should be specified!");
                }
                this.processor = value;
            }
        }
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
            get
            {
                return this.colour;
            }
            set
            {
                this.colour = value;
            }
        }
        public BatteryType Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }

        }
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


        public Smartphone(decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize,
            PhoneSize size, string processor, int ram)
        {
            this.Price = price;
            this.Brand = brand;
            this.Model = model;
            this.Colour = colour;
            this.Battery = battery;
            this.DisplaySize = displaySize;
            this.Size = size;
            this.Processor = processor;
            this.Ram = ram;

        }

        public string Print()
        {
            return "\n-----------------------" + $"\nProduct: {this.GetType().Name}" + $"\nID: {this.ID}" + $"\nBrand: {this.Brand}" + $"\nModel: {this.Model}" + $"\nColor: {this.Colour}"
                + $"\nDisplay size: {this.DisplaySize}'" + $"\nProcessor: {this.Processor}" + $"\nRam: {this.Ram}GB" +
                $"\nHeight: {this.Size.Height}'" + $"\nWidth: {this.Size.Width}'" + $"\nTickness: {this.Size.Thickness}'"
                + $"\nBattery: {this.Battery}" + $"\nPrice: {this.Price}$" + "\n-----------------------";
        }
    }
}

