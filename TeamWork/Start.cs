using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Products;

namespace ElectronicsShop
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
