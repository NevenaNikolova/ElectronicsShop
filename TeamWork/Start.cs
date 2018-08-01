using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models;
using TeamWork.Models.Electronics.AbstractClasses;
using TeamWork.Models.Products;

namespace TeamWork
{
    class Start
    {
        public static void Main()
        {
            Category category = new Category("Electronics");
            Laptop laptop = new Laptop("Asus", "A5", 16, 2500, 1,"Intel I7", 8000, 500, 2, "Pesho", 1600);
            ShopingCart shopingCart = new ShopingCart();
            shopingCart.AddProduct(laptop);
            Console.WriteLine(string.Join(" ", shopingCart));
        }
    }
}
