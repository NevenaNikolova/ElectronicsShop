using System;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.Contracts.ComputerContracts;

namespace ElectronicsShop.Core.Factories
{
    public class ProductFactory : IProductFactory
    {

        public ProductFactory()
        {

        }
        public ILandlinePhone CreateLandlinePhone(int Id, decimal price, string brand, string model, string colour, string battery, int displaySize, PhoneSize size, int analogueLines)
        {
            return new LandlinePhone(Id, price, brand, model, colour, displaySize, size, analogueLines);

        }

        public ISmartphone CreateSmartphone(string brand, string model, string colour, string battery, int displaySize,
            PhoneSize size, string processor, int ram, decimal price)
        {

            return new Smartphone(brand, model, colour, this.getBatteryType(battery).ToString(), displaySize, size, processor, ram, price);

        }

        public IDesktopComputer CreateDesktopComputer(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price)
        {
            return new DesktopPC(brand, model, processor, ram, hdd, videoCard, price);

        }

        public ILaptop CreateLaptop(string brand, string model, int displaySize, int batteryCapacity,
            string procesor, int ram, int hdd, int videoCard, int price)
        {
            return new Laptop(brand, model, displaySize, batteryCapacity, procesor, ram, hdd, videoCard, price);
        }

       

        private BatteryType getBatteryType(string battery)
        {
            switch (battery)
            {
                case "LiIon":
                    return BatteryType.LiIon;
                case "White":
                    return BatteryType.NiMH;
                case "Red":
                    return BatteryType.NiCd;
                default: throw new ArgumentException("Colour not set correctly!");
            }
        }
    }

}
