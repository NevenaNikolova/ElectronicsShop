using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;

namespace ElectronicsShop.Models.Interfaces
{
    public interface IPhone : IProduct

    {
        string Brand { get;}
        string Model { get;}
        Colour Colour { get;}
        BatteryType Battery { get;}
        int DisplaySize { get;}
        PhoneSize Size { get;}
    }
}
