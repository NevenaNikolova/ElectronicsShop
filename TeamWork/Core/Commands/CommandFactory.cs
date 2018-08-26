using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Exceptions;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.ComputerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using ElectronicsShop.Core.Commands.Contracts;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;
using Autofac;

namespace ElectronicsShop.Core.Commands
{
    internal class CommandFactory : ICommandFactory
    {
        private IComponentContext autofacContext;

        public CommandFactory(IComponentContext autofacContext)
        {
            this.autofacContext = autofacContext;
        }

        public ICommand GetCommand(string commandName)
        {
            return this.autofacContext.ResolveNamed<ICommand>(commandName);
        }


        //    private IProductFactory factory;k
        //    private readonly IDatabase database;
        //    private IShoppingCart shoppingCart;
        //    private ILogger logger;

        //    public CommandFactory(IProductFactory factory, ILogger logger, IShoppingCart shoppingCart, IDatabase database)
        //    {
        //        this.factory = factory;
        //        this.logger = logger;
        //        this.shoppingCart = shoppingCart;
        //        this.database = database;
        //    }

        //    public ICommand CreateCommand(IList<string> commandParameters)
        //    {
        //        string firstParam = commandParameters[0];
        //        commandParameters.RemoveAt(0);
        //        string commandName = commandParameters[0];

        //        this.autodfacContext.ResolveNamed<ICommand>(commandName);
        //        //switch (firstParam)
        //        //{
        //        //    case "smartphone":
        //        //        if (commandParameters.Count != 11)
        //        //        {
        //        //            throw new Exception("For creating smartphone you need to enter exacly 11 parameters!");
        //        //        }
        //        //        string brand = commandParameters[0];
        //        //        string model = commandParameters[1];
        //        //        string color = commandParameters[2];
        //        //        string battery = commandParameters[3];
        //        //        int displaySize = int.Parse(commandParameters[4]);
        //        //        PhoneSize phoneSize = new PhoneSize(double.Parse(commandParameters[5]), double.Parse(commandParameters[6]), double.Parse(commandParameters[7]));
        //        //        string processor = commandParameters[8];
        //        //        int ram = int.Parse(commandParameters[9]);
        //        //        decimal price = decimal.Parse(commandParameters[10]);

        //        //        var smartphone = factory.CreateSmartphone(brand, model, color, battery, displaySize, phoneSize, processor, ram, price);

        //        //        this.database.AddProduct(smartphone);

        //        //        this.logger.Log($"Smartphone with ID:{smartphone.ID} was created!");

        //        //        break;
        //        //    case "landlinephone":
        //        //        if (commandParameters.Count != 10)
        //        //        {
        //        //            throw new Exception("For creating landline phone you need to enter exacly 10 parameters!");
        //        //        }
        //        //        string brand = commandParameters[0];
        //        //        string model = commandParameters[1];
        //        //        string color = commandParameters[2];
        //        //        string battery = commandParameters[3];
        //        //        int displaySize = int.Parse(commandParameters[4]);
        //        //        PhoneSize phoneSize = new PhoneSize(double.Parse(commandParameters[5]), double.Parse(commandParameters[6]), double.Parse(commandParameters[7]));
        //        //        string processor = commandParameters[8];
        //        //        int ram = int.Parse(commandParameters[9]);
        //        //        decimal price = decimal.Parse(commandParameters[10]);

        //        //        var landlinePhone = factory.CreateLandlinePhone(commandParameters);

        //        //        this.database.AddProduct(landlinePhone);

        //        //        this.logger.Log($"Landline phone with ID:{landlinePhone.ID} was created!");

        //        //        break;

        //        //    case "laptop":
        //        //        if (commandParameters.Count != 9)
        //        //        {
        //        //            throw new Exception("For creating laptop you need to enter exacly 9 parameters!");
        //        //        }
        //        //        var laptop = factory.CreateLaptop(commandParameters);

        //        //        this.database.AddProduct(laptop);

        //        //        this.logger.Log($"Laptop with ID:{laptop.ID} was created!");

        //        //        break;
        //        //    case "desktoppc":
        //        //        if (commandParameters.Count != 7)
        //        //        {
        //        //            throw new Exception("For desktop pc you need to enter exacly 7 parameters!");
        //        //        }



        //        //        var desktopPc = factory.CreateDesktopComputer(commandParameters);

        //        //        this.logger.Log($"Desktop computer with ID:{desktopPc.ID} was created!");

        //        //        break;

        //        //    default:
        //        //        throw new ProductTypeNotExistException("Cannot create product of this type!");

        //        //}
        //    }

        //    public void AddToShopingCart(int id)
        //    {
        //        var prod = GetProduct(id);

        //        this.shoppingCart.AddProduct(prod);

        //        this.logger.Log($"{prod.GetType().Name} with ID:{id} was added to shopping cart!");
        //    }

        //    public IProduct GetProduct(int id)
        //    {

        //        if (!database.Contains(id))
        //        {
        //            throw new ItemNotFoundException($"Product with ID:{id} does not exist!");
        //        }
        //        return this.database.GetProduct(id);
        //    }

        //    public void Process(IList<string> commands)
        //    {
        //        string firstCommand = commands[0];
        //        commands.RemoveAt(0);

        //        switch (firstCommand)
        //        {
        //            // CreateProductCommand
        //            case "create":
        //                this.CreateCommand(commands);
        //                break;
        //            //
        //            // AddProductToCartCommand
        //            case "addToCart":
        //                if (commands.Count < 1)
        //                {
        //                    throw new Exception("Must enter ID of the product you want to add into your shopping cart !");
        //                }
        //                this.AddToShopingCart(int.Parse(commands[0]));
        //                break;
        //            //
        //            // RemoveProductFromShoppingCartCommand.execute();
        //            case "remove":
        //                if (commands.Count < 1)
        //                {
        //                    throw new Exception("Must enter ID of the product you want to remove from your shopping cart !");
        //                }
        //                this.RemoveFromShopingCart(int.Parse(commands[0]));
        //                break;
        //            //
        //            // ShowProductListCommand
        //            case "show":
        //                if (commands[0] == "cart")
        //                {
        //                    if (shoppingCart.Count() == 0)
        //                    {
        //                        this.logger.Log("Shopping cart is empty !");
        //                        break;
        //                    }
        //                    this.logger.Log(this.shoppingCart.Print());

        //                    this.logger.Log($"Order Y/N ?");
        //                    ConsoleKeyInfo orderInput = Console.ReadKey();

        //                    if (orderInput.Key == ConsoleKey.Y)
        //                    {
        //                        Random rnd = new Random();
        //                        decimal deliverCost = shoppingCart.TotalPrice() / 10m;

        //                        this.logger.Log($"\n\n             ORDER N:{rnd.Next(23234, 988877)}" + $"\n" + $"\nFirst name: Gosho" +
        //                            $"\nLast name : Goshov" + $"\nTel. number: (+359)870000442" +
        //                            $"\nAdress: Bulgaria ,Sofia Studentski grad, purviq blok ot lqvo na PLAZZA . A vhod !" +
        //                            $"\nProducts: " + $"\n{shoppingCart.Print()}" + $"     + {deliverCost}$ (delivery)" +
        //                            $"\n\n     T O T A L : {shoppingCart.TotalPrice() + deliverCost}$" + $"\n\nThe order will arrive within three days !" +
        //                            $"\n\n  <<< Have a nice day and continue shopping ! >>>\n");
        //                    }
        //                    else if (orderInput.Key == ConsoleKey.N)
        //                    {
        //                        this.logger.Log("\nNo purchase was made!");
        //                        break;
        //                    }
        //                    break;
        //                }
        //                this.logger.Log(database.GetList(commands[0]));
        //                if (commands[0] == "laptops")
        //                {
        //                    this.logger.Log(database.GetList(commands[0]));

        //                }
        //                break;
        //            //
        //            default:
        //                throw new InvalidOperationException("Invalid command! \nPossinble commands are :" +
        //                    "\n create [type] [args1] [arg2]... [argN]\n addToCart [id]\n remove [id]\n show [collection]");

        //        }
        //    }

        //    private void RemoveFromShopingCart(int id)
        //    {
        //        var prod = GetProduct(id);
        //        this.shoppingCart.RemoveProduct(id);
        //        Console.WriteLine($"{prod.Name} with ID:{id} was removed from shopping cart!");
        //    }
    }
}
