using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Contracts.Phone_Contracts
{
    public interface ILandlinePhone : IPhone
    {
        int AnalogueLines { get; }
    }
}
