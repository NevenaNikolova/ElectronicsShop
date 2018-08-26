using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.ComputerContracts;
using System.Collections.Generic;


namespace ElectronicsShop.Core.Contracts
{
    public interface IShoppingCart : IPrintable
    {
        ICollection<IProduct> ProductList { get; }

        void AddProduct(IProduct product);

        void RemoveProduct(int id);

        bool ContainsProduct(IProduct product);

        decimal TotalPrice();

        int Count();
    }
}
