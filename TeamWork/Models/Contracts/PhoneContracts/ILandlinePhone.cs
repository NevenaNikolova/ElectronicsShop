using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Contracts.PhoneContracts
{
    public interface ILandlinePhone : IPhone
    {
        int AnalogueLines { get; }
    }
}
