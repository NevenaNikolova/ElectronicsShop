using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicsShop.Models
{
    public class Database<T> where T : IProduct
    {
        private readonly List<T> products;

        public Database()
        {
            this.products = new List<T>();
        }

        public void AddProduct(T product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(T product)
        {
            if (this.products.Contains(product))
            {
                this.products.Remove(product);
            }
        }

        public string GetList()
        {
            StringBuilder sb = new StringBuilder();
            this.products.ForEach(x => sb.Append(ProductInfoDecorator.DecorateProduct(x)));

            return sb.ToString();
        }

        public T GetProduct(int id)
        {
            return this.products.First(p => p.ID == id);
        }
    }
}
