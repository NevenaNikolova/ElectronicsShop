using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.Phone_Contracts;
using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicsShop.Models
{
    public class Database : IDatabase
    {
        private readonly List<IProduct> products;

        public Database()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
            product.ID = products.IndexOf(product);
        }

        public void RemoveProduct(IProduct product)
        {
            if (this.products.Contains(product))
            {
                this.products.Remove(product);
            }
        }

        public string GetList(string typeOfProduct)
        {
            throw new NotImplementedException("not implemented Database method GetList()");
            StringBuilder sb = new StringBuilder();
            this.products.Where(x => x.GetType() == typeof(ILandlinePhone)).Select(x => sb.Append(x.Print()));

            return sb.ToString();
        }

        public IProduct GetProduct(int id)
        {
            return this.products.First(p => p.ID == id);
        }

        public bool Contains(int id)
        {
            if (products.Any(x => x.ID == id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
