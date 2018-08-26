using ElectronicsShop.Models.ComputerContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Models.Contracts
{
    interface IDatabase
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        string GetList(string typeOfProduct);
        IProduct GetProduct(int id);
        bool Contains(int id);
        List<IProduct> Products { get; }
    }
}
