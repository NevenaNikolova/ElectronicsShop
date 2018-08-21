using System.Collections.Generic;
using ElectronicsShop.Models.Contracts.Phone_Contracts;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;

namespace ElectronicsShop.Core.Factories
{
    public interface IProductFactory
    {        
        ISmartphone CreateSmartphone(IList<string> parameters);       
        ILandlinePhone CreateLandlinePhone(IList<string> parameters);

        ILaptop CreateLaptop(IList<string> parameters);
        IComputer CreateDesktopComputer(IList<string> parameters);

    }
}
