using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models.Products.Electronics.Phones
{
    public interface ISmartphone : IProduct, IPhone
    {
        string Processor { get; set; }

        int Ram { get; set; }
    }
}
