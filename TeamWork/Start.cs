using System;
using System.Collections.Generic;
using ElectronicsShop.Core;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using System.Linq;
using ElectronicsShop.Core.Contracts;

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
            ProductFactory factory = new ProductFactory();
            ConsoleLogger logger = new ConsoleLogger();
            CommandHandler commandHandler = new CommandHandler(factory,logger);
            var engine = Engine.Instance(factory, commandHandler,logger);
            engine.Start();
            //ShopingCart sh = new ShopingCart();
            //sh.AddProduct(new Laptop("SDASD", "ujhs", "ksjdzfn", 52, 1521, "fas", 42, 54, 65, 2));
            //sh.AddProduct(new Laptop("SDASD", "ujhs", "ksjdzfn", 52, 1521, "fas", 42, 54, 65, 4));
            //sh.AddProduct(new Laptop("SDASD", "ujhs", "ksjdzfn", 52, 1521, "fas", 42, 54, 65, 1));
            //Console.WriteLine(sh.TotalPrice()); 
        }
    }
}
