using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Contracts
{
    interface IShoppingCart : IPrintable
    {
        ICollection<IProduct> ProductList { get; }

        void AddProduct(IProduct product);

        void RemoveProduct(int id);

        bool ContainsProduct(IProduct product);

        decimal TotalPrice();

        int Count();
    }
}
