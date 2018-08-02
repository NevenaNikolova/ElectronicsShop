using System;
using System.Collections.Generic;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models
{
    public class Category
    {
        private readonly string name;
        private List<IProduct> products;
        private List<Laptop> laptops;

        public Category(string name)
        {
            this.name = name;
            this.products = new List<IProduct>();
            this.laptops = new List<Laptop>();
        }

        public string Name
        {
            get { return this.name; }
        }

        public void addProduct(IProduct product)
        {
            if (product.GetType().Name == "Laptop")
            {
               this.laptops.Add((Laptop)product);
            }
            
        }

        public void RemoveProduct(IProduct product)
        {
            if (this.products.Contains(product))
            {
                this.products.Remove(product);
            }
        }

    }
}
