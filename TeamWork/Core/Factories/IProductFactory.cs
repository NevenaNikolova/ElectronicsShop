using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;
using ElectronicsShop.Models.Products.Electronics.Phones;

namespace ElectronicsShop.Core.Factories
{
    public interface IProductFactory
    {
        ISmartphone CreateSmartphone(IList<string> parameters/*string name, decimal price, string brand, string model, Colour colour, BatteryType battery,
            int displaySize, double height, double width, double thickness, string processor, int ram*/);
        ILandlinePhone CreateLandlinePhone(IList<string> parameters/*string name, decimal price, string brand, string model, Colour colour, BatteryType battery,
            int displaySize, double height, double width, double thickness, int analogueLines, bool wallMounting*/);
        //ILaptop CreateLaptop
        //IDesctopPC CreateDesctopPC
        PC CreateLaptop(IList<string> parameters);

    }
}
