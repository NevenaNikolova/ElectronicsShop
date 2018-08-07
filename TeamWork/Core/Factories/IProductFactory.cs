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
        ISmartphone CreateSmartphone(IList<string> parameters);       
        ILandlinePhone CreateLandlinePhone(IList<string> parameters);

        PC CreateLaptop(IList<string> parameters);
        PC CreateDesktopComputer(IList<string> parameters);

    }
}
