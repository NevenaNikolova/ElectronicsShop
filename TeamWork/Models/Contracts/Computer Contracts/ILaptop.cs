using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Contracts.Computer_Contracts
{
    public interface ILaptop : IProduct
    {
        string Brand { get; }

        string Model { get; }

        int DisplaySize { get; }

        int BatteryCaoacity { get; }

        string Processor { get; }

        int Ram { get; }

        int Hdd { get; }

        int VideoCard { get; }
    }
}
