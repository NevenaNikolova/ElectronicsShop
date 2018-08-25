using System;
using System.Collections.Generic;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.Contracts.ComputerContracts;

namespace ElectronicsShop.Core.Factories
{
    public class ProductFactory : IProductFactory
    {


        //smartphone command
        //create smartphone gosho 900 Asus ZenPhone Black LiIon 16 3 3 3 Atom 4

        //lanlinePhone command
        //create landlinephone gosho 9 VIVACOM Home White LiIon 16 3 3 3 10

        //laptop command
        //create laptop MyLaptop Lenovo ThinkPad 14 4500 i5 8 500 4 1200
        public ProductFactory()
        {

        }
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

        public IDesktopComputer CreateDesktopComputer(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price)
        {
            return new DesktopPC(brand, model, processor, ram, hdd, videoCard, price);
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
