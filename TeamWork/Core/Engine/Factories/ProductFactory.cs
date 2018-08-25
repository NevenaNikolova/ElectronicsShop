using System;
using System.Collections.Generic;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Contracts.Phone_Contracts;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Contracts.Computer_Contracts;

namespace ElectronicsShop.Core.Factories
{
    internal class ProductFactory : IProductFactory
    {
        private static IProductFactory instanceHolder = new ProductFactory();
        //private int count;

        public ILandlinePhone CreateLandlinePhone(int Id, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size, int analogueLines)
        {
            return new LandlinePhone(Id, price, brand, model, colour, battery, displaySize, size, analogueLines);
            //count++;
        }

        public ISmartphone CreateSmartphone(decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize,
            PhoneSize size, string processor, int ram)
        {

            return new Smartphone(price, brand, model, colour, battery, displaySize, size, processor, ram);
            //count++;
        }

        public IDesktopPc CreateDesktopComputer(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price)
        {
            return new DesktopPC( brand,  model,  processor,  ram,  hdd,  videoCard,  price);
            //count++;
        }

        public ILaptop CreateLaptop(string brand, string model, int displaySize, int batteryCapacity,
            string procesor, int ram, int hdd, int videoCard, int price)
        {
            return new Laptop(brand, model, displaySize, batteryCapacity, procesor, ram, hdd, videoCard, price);
           // count++;
        }
    }

}
