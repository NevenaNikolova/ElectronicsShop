using ElectronicsShop.Models.Contracts;

namespace ElectronicsShop.Models.Interfaces
{
    public interface IProduct : IPrintable
    {
        string Name { get; }

        decimal Price { get; }

        int ID { get; }
    }
}