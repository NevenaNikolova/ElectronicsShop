using ElectronicsShop.Models.ComputerContracts;

namespace ElectronicsShop.Core.Contracts
{
    public interface ILogger
    {
        void Log(string message);
        void LogProductInfo(IProduct product);
    }
}
