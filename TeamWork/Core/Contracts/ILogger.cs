using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Contracts
{
    public interface ILogger
    {
        void Log(string message);
        void Log(IProduct product);
    }
}
