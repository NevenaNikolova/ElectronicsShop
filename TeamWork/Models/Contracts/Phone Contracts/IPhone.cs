using TeamWork.Models.Products.Common;
using TeamWork.Models.Products.Electronics.Common;

namespace TeamWork.Models.Interfaces
{
    public interface IPhone : IProduct

    {
        string Brand { get; set; }
        string Model { get; set; }
        Colour Colour { get; set; }
        BatteryType Battery { get; set; }
        int DisplaySize { get; set; }
        double Height { get; set; }
        double Width { get; set; }
        double Thickness { get; set; }
    }
}
