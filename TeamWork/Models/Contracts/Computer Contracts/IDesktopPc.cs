namespace ElectronicsShop.Models.Interfaces
{
    public interface IDesktopPc : IProduct
    {
        string Brand { get; }

        string Model { get; }

        string Processor { get; }

        int Ram { get; }

        int Hdd { get; }

        int VideoCard { get; }

    }
}
