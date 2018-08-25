using System.Collections.Generic;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Contracts.ComputerContracts;

namespace ElectronicsShop.Core.Factories
{
    public interface IProductFactory
    {        
        ISmartphone CreateSmartphone(IList<string> parameters);       
        ILandlinePhone CreateLandlinePhone(IList<string> parameters);

        ILaptop CreateLaptop(IList<string> parameters);
        IDesktopComputer CreateDesktopComputer(IList<string> parameters);

    }
}
