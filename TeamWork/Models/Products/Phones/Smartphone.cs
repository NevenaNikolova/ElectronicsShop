﻿using System;
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
        

        public override string Print()
        {
            return string.Format("Phone: {0}, price: {1}, brand: {2}, model: {3}, colour: {4}, battery: {5}, " +
                "display size: {6}, height: {7}, width: {8}, thickness: {9}, processor: {10}, ram: {11}",
                this.Name, this.Price, this.Brand, this.Model, this.Colour, this.Battery, 
                this.DisplaySize, this.Height, this.Width, this.Thickness, this.Processor, this.Ram);
        }

    }
}