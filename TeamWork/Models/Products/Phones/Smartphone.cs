using System;
using ElectronicsShop.Models.Contracts.Phone_Contracts;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.Products.Phones
{
    public class Smartphone : Phone
    {
        private const string ProductName = "Smartphone";
        private string processor;
        private int ram;

        public Smartphone(decimal price) : base(ProductName, price)
        {
        }

        public Smartphone(decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size, string processor,
       int ram) :
            base(ProductName, price, brand, model, colour, battery, displaySize, size)
        {
            this.Processor = processor;
            this.Ram = ram;
        }
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
    }
}

