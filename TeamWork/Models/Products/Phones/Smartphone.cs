using System;
using ElectronicsShop.Models.AbstractClasses;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;
using ElectronicsShop.Models.Products.Electronics.Phones;

namespace ElectronicsShop.Models.Electronics.Phones
{
    public class Smartphone : Phone
    {
        private string processor;
        private int ram;

        public Smartphone(string name, decimal price) : base(name, price)
        {
        }

        public Smartphone(string productName, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size, string processor,
       int ram) :
            base(productName, price, brand, model, colour, battery, displaySize, size)
        {
            this.Processor = processor;
            this.Ram = ram;
        }
        public int Ram { get; set; }

        public string Processor { get; set; }
    }
}

