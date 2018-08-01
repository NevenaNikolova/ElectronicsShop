using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.Electronics.Phones;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;
using ElectronicsShop.Models.Products.Electronics.Phones;

namespace ElectronicsShop.Core.Factories
{
    public class ProductFactory : IProductFactory
    {
        private static IProductFactory instanceHolder = new ProductFactory();

        public ProductFactory()
        {

        }

        public static IProductFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ILandlinePhone CreateLandlinePhone(string name, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, double height, double width, double thickness, int analogueLines, bool wallMounting)
        {
            return new LandlinePhone(name, price, brand, model, colour, battery, displaySize, height, width, thickness, analogueLines, wallMounting);
        }

        public ISmartphone CreateSmartphone(string name, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, double height, double width, double thickness, string processor, int ram)
        {
            return new Smartphone(name, price, brand, model, colour, battery, displaySize, height, width, thickness, processor, ram);
        }
    }
}
