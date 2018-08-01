using System;
using TeamWork.Models.AbstractClasses;
using TeamWork.Models.Electronics.AbstractClasses;
using TeamWork.Models.Interfaces;
using TeamWork.Models.Products.Common;
using TeamWork.Models.Products.Electronics.Common;
using TeamWork.Models.Products.Electronics.Phones;

namespace TeamWork.Models.Electronics.Phones
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
