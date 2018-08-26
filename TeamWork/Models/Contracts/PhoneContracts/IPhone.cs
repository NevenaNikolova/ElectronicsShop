using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.ComputerContracts
{
    public interface IPhone : IProduct
    {
        string Brand { get; }
        string Model { get; }
        string Colour { get; }
        string Battery { get; }
        int DisplaySize { get; }
        PhoneSize Size { get; }
    }
}
