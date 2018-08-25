using ElectronicsShop.Models.Contracts;

namespace ElectronicsShop.Models.ComputerContracts
{
    public interface IProduct : IPrintable
    {
        string Name { get; }

        decimal Price { get; }

        int ID { get; set; }
    }
}