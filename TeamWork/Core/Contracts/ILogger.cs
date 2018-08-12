using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Core.Contracts
{
    public interface ILogger
    {
        void Log(string message);
        void Log(IProduct product);
    }
}
