using ElectronicsShop.Models.ComputerContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Contracts.ComputerContracts
{
    public interface ILaptop : IProduct, IComputer
    {
        int DisplaySize { get; }
        int BatteryCapacity { get; }
    }
}
