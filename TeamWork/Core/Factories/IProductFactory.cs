using System.Collections.Generic;
using ElectronicsShop.Models.Products;

namespace ElectronicsShop.Core.Factories
{
    public interface IProductFactory
    {        
        Phone CreateSmartphone(IList<string> parameters);       
        Phone CreateLandlinePhone(IList<string> parameters);

        PC CreateLaptop(IList<string> parameters);
        PC CreateDesktopComputer(IList<string> parameters);

    }
}
