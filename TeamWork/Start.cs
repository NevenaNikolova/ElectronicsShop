using ElectronicsShop.Core;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;

namespace ElectronicsShop
{
    class Start
    {
        public static void Main()
        {
            //Category category = new Category("Electronics");
            //Laptop laptop = new Laptop("ASUS", " ", "af", 16, 2500, "Intel i7-UXJS", 4, 512, 2, 1000);
            //ShoppingCart shopingCart = new ShoppingCart();
            //shopingCart.AddProduct(laptop);

            //Console.WriteLine(string.Join(" ", shopingCart));
            //Console.WriteLine(Decorator.DecorateProduct(laptop));
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine(Printer.LaptopInfoLongString(laptop));
            //category.addProduct(laptop);
            
            ProductFactory factory = new ProductFactory();
            ConsoleLogger logger = new ConsoleLogger();
           // ILogger logger = new FileLogger();
            CommandHandler commandHandler = new CommandHandler(factory, logger);
            var engine = Engine.Instance(factory, commandHandler, logger);
            engine.Start();
            //ShopingCart sh = new ShopingCart();
            //sh.AddProduct(new Laptop("SDASD", "ujhs", "ksjdzfn", 52, 1521, "fas", 42, 54, 65, 2));
            //sh.AddProduct(new Laptop("SDASD", "ujhs", "ksjdzfn", 52, 1521, "fas", 42, 54, 65, 4));
            //sh.AddProduct(new Laptop("SDASD", "ujhs", "ksjdzfn", 52, 1521, "fas", 42, 54, 65, 1));
            //Console.WriteLine(sh.TotalPrice()); 
        }
    }
}
