using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;

namespace ElectronicsShop.Models.Interfaces
{
    public interface IPhone : IProduct

    {
        string Brand { get; set; }
        string Model { get; set; }
        Colour Colour { get; set; }
        BatteryType Battery { get; set; }
        int DisplaySize { get; set; }
        PhoneSize Size { get; set; }
    }
}
