using System;
using System.Collections.Generic;
using ElectronicsShop.Core;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using System.Linq;

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

            //////Console.WriteLine(string.Join(" ", shopingCart));
            ////Console.WriteLine(Printer.LaptopInfoToShortString(laptop));
            ////Console.WriteLine("---------------------------------------");
            ////Console.WriteLine(Printer.LaptopInfoLongString(laptop));
            //category.addProduct(laptop);
            CommandHandler commandHandler = new CommandHandler();
            ProductFactory factory = new ProductFactory();
            var engine = Engine.Instance(factory, commandHandler);
            engine.Start();
        }
    }
}
