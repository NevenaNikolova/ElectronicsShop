using System;
using ElectronicsShop.Core;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;

namespace ElectronicsShop
{
    class Start
    {
        public static void Main()
        {
            //Category category = new Category("Electronics");
            ////Laptop laptop = new Laptop("ASUS","ZenBook",16,2500,"Intel i7-UXJS",4,512,2,1000);
            //ShopingCart shopingCart = new ShopingCart();
            //shopingCart.AddProduct(laptop);
<<<<<<< HEAD
            //////Console.WriteLine(string.Join(" ", shopingCart));
            ////Console.WriteLine(Printer.LaptopInfoToShortString(laptop));
            ////Console.WriteLine("---------------------------------------");
            ////Console.WriteLine(Printer.LaptopInfoLongString(laptop));
            //category.addProduct(laptop);

            var engine = Engine.Instance;
            engine.Start();
=======
            //Console.WriteLine(string.Join(" ", shopingCart));
            Console.WriteLine(Printer.LaptopInfoToShortString(laptop));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(Printer.LaptopInfoLongString(laptop));

>>>>>>> 9f8fea30c9abe4d74d86a4855317421269cf6458
        }
    }
}
