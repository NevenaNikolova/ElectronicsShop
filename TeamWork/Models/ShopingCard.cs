using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models
{
    class ShopingCard
    {
        private readonly ICollection<IProducts> productList;
        public ShopingCard()
        {
            this.productList = new List<IProducts>();
        }

        public ICollection<IProducts> ProductList
        {
            get { return new List<IProducts>(this.productList); }
        }

        public void AddProduct(IProducts product)
        {

            this.productList.Add(product);
        }

        public void RemoveProduct(IProducts product)
        {

            this.productList.Remove(product);
        }

        public bool ContainsProduct(IProducts product)
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
