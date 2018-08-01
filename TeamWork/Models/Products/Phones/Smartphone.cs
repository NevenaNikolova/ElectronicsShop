using System;
using ElectronicsShop.Models.AbstractClasses;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;
using ElectronicsShop.Models.Products.Electronics.Phones;

namespace ElectronicsShop.Models.Electronics.Phones
{
    public class Smartphone : Phone, ISmartphone
    {
        private string processor;
        private int ram;

        public Smartphone(string name, decimal price) : base(name, price)
        {
        }

        public Smartphone(string productName, decimal price, string brand, string model, Colour colour, BatteryType battery,
            int displaySize, double height, double width, double thickness, string processor, int ram) 
            : base(productName, price, brand, model, colour, battery, displaySize, height, width, thickness)
        {
            this.Processor = processor;
            this.Ram = ram;
        }

        public int Ram { get; set; }

        public string Processor { get; set; }
        

       

    }
}
