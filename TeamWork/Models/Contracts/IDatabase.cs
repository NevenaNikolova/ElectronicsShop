using ElectronicsShop.Models.ComputerContracts;
using System.Collections.Generic;


namespace ElectronicsShop.Models.Contracts
{
    public interface IDatabase
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        string GetList(string typeOfProduct);
        IProduct GetProduct(int id);
        bool Contains(int id);
        List<IProduct> Products { get; }
    }
}
