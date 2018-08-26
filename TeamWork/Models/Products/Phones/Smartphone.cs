using System;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Core.Tools;

namespace ElectronicsShop.Models.Products.Phones
{
    public class Smartphone : ISmartphone, IPrintable
    {
        private int displaySize;
        private string processor;
        private int ram;
        private string brand;
        private string name;
        private decimal price;
        private int id;
        private string model;
        private BatteryType battery;
        private string colour;
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
                if (string.IsNullOrWhiteSpace(value))
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.model = value;
            }
        }
        public string Colour
        {
            get
            {
                return this.colour;
            }
            set
            {
                //(TEnum)Enum.Parse(typeof(TEnum), strEnumValue);
                //Enum.Parse(typeof(Colour), colour);
                Colour colour;
                if (!Enum.TryParse(value, out colour))
                {
                    throw new ArgumentException();
                }

                this.colour = value;
            }
        }
        public string Battery
        {
            get
            {
                return this.battery.ToString();
            }
        }
        public int DisplaySize
        {
            get { return this.displaySize; }
            private set
            {
                if (value <= 0)
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
                    throw new ArgumentException("Too low price!");
                }
                else this.price = value;
            }
        }
        public int ID
        {
            get => this.id;
            set => this.id = IdProvider.Instance().GetID();
        }

        public Smartphone(string brand, string model, string colour, string battery, int displaySize,
            PhoneSize size, string processor, int ram, decimal price)
        {
            this.ID = id;
            this.Price = price;
            this.Brand = brand;
            this.Model = model;
            this.Colour = colour;
            this.battery = (BatteryType)Enum.Parse(typeof(BatteryType), battery);
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

