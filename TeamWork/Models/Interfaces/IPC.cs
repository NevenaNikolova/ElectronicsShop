using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models.Interfaces
{
    public interface IPC : IProduct
    {

        string Brand { get; }

        string Model { get; }

        string Processor { get; }

        int Ram { get; }

        int Hdd { get; }

        int VideoCard { get; }

    }
}
