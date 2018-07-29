using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Electronics;
using TeamWork.Models.Electronics.AbstractClasses;
using TeamWork.Models.Products.Electronics.Common;

namespace TeamWork.Models.Electronics.Phones
{
    public class Smartphone:Phone
    {
        private string processor;
        private int ram;

        public Smartphone(string productName, decimal price) : base(productName, price)
        {
        }

        public Smartphone(string productName, decimal price, string brand, string model, Colours colour, BatteryType battery, 
            int displaySize, double height, double width, double thickness, string processor, int ram) : base(productName, price, brand, model, colour, battery, displaySize, height, width, thickness)
        {
            this.Procesor = processor;
            this.Ram = ram;
        }
        public string Procesor { get; set; }
        public int Ram { get; set; }

        public override string ToString()
        {
            return string.Format("Phone: {0}, price: {1}, brand: {2}, model: {3}, colour: {4}, battery: {5}, " +
                "display size: {6}, height: {7}, width: {8}, thickness: {9}, processor: {10}, ram: {11}",
                this.ProductName, this.Price, this.Brand, this.Model, this.Colour, this.Battery, this.DisplaySize, this.Height, this.Width, this.Thickness, this.Procesor, this.Ram);
        }
    }
}
