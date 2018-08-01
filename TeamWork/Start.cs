using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Text;
using TeamWork.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
=======
using TeamWork.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Products;
>>>>>>> e969eaba3cd32c92beff9a6a5649415b107ac992

namespace ElectronicsShop
{
    class Start
    {
        public static void Main()
        {
            Category category = new Category("Electronics");
            Laptop laptop = new Laptop("ASUS","ZenBook",16,2500,"Intel i7-UXJS",4,512,2,1000);
            //ShopingCart shopingCart = new ShopingCart();
            //shopingCart.AddProduct(laptop);
            //Console.WriteLine(string.Join(" ", shopingCart));
            Console.WriteLine(Printer.LaptopInfoToShortString(laptop));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(Printer.LaptopInfoLongString(laptop));
        }
    }
}
