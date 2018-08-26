using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Contracts.PhoneContracts
{
    public interface ISmartphone : IPhone
    {
        string Battery { get; }
        int Ram { get; }
    }
}
