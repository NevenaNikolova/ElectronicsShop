using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Interfaces
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
