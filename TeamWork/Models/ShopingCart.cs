using System.Collections.Generic;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models
{
    class ShopingCart
    {
        private readonly List<IProduct> productList;

        public ShopingCart()
        {
            this.productList = new List<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get { return new List<IProduct>(this.productList); }
        }

        public void AddProduct(IProduct product)
        {

            this.productList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {

            this.productList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.productList.Contains(product))
            {
                return true;
            }
            else return false;
        }

        public double TotalPrice()
        {
            return 0;
        }

    }
}
