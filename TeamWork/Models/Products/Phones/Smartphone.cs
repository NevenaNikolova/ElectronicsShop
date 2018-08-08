using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.Products.Phones
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

