using System.Collections.Generic;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Contracts.ComputerContracts;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Core.Factories
{
    public interface IProductFactory
    {

        ILandlinePhone CreateLandlinePhone(int Id, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size, int analogueLines);


        ISmartphone CreateSmartphone(decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize,
            PhoneSize size, string processor, int ram);

        IDesktopComputer CreateDesktopComputer(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price);


        ILaptop CreateLaptop(string brand, string model, int displaySize, int batteryCapacity,
            string procesor, int ram, int hdd, int videoCard, int price);

    }
}
