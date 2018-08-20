using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Contracts
{
    interface IShoppingCart
    {
        ICollection<IProduct> ProductList { get; }

        void AddProduct(IProduct product);

        void RemoveProduct(int id);

        bool ContainsProduct(IProduct product);

        decimal TotalPrice();

        int Count();
    }
}
