using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;
using ElectronicsShop.Models.ComputerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicsShop.Models
{
    public class Database : IDatabase
    {
        private readonly List<IProduct> products;

        public List<IProduct> Products
        {
            get
            {
                return new List<IProduct>(products);
            }
        }

        public Database()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Product");
            }
            this.products.Add(product);
            product.ID = products.IndexOf(product);
        }

        public void RemoveProduct(IProduct product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("Invalid product value!");
            }
            if (!products.Contains(product))
            {
                throw new ArgumentException("Trying to remove unexisting product!");
            }

            if (this.products.Contains(product))
            {
                this.products.Remove(product);
            }
        }

        public string GetList(string typeOfProduct)
        {
            if (!products.Any(x => x.GetType().Name.Contains(typeOfProduct)))
            {
                throw new ArgumentException($"Unexisting type {typeOfProduct}!");
            }
            StringBuilder sb = new StringBuilder();
            var collection = this.products.Where(x => x.Name.ToLower().Contains(typeOfProduct)).ToList();
            collection.ForEach(x => sb.Append(x.Print()));
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
