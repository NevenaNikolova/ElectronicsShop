using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Contracts.Phone_Contracts
{
    interface ISmartphone : IPhone
    {
        int Ram { get; }


        string Processor { get; }
        //string Brand { get; }
        //string Model { get; }
        //Colour Colour { get; }
        //BatteryType Battery { get; }
        //int DisplaySize
        //{
        //    get;
        //}
        //PhoneSize Size { get; }
    }
}
