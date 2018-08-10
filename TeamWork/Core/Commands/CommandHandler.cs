using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Exceptions;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;



namespace ElectronicsShop.Core.Commands
{
    internal class CommandHandler : ICommandHandler
    {
        private IProductFactory factory;
        private readonly Category category = new Category("Products");
        private ShoppingCart shoppingCart;
        private ILogger logger;

        public CommandHandler(IProductFactory factory, ILogger logger)
        {
            this.factory = factory;
            this.logger = logger;
            this.shoppingCart = new ShoppingCart();
        }

        public void CreateCommand(IList<string> commandParameters)
        {
            string firstParam = commandParameters[0];
            commandParameters.RemoveAt(0);

            switch (firstParam)
            {
                case "smartphone":
                    if (commandParameters.Count != 11)
                    {
                        throw new Exception("For creating smartphone you need to enter exacly 11 parameters!");
                    }
                    var smartphone = factory.CreateSmartphone(commandParameters);

                    this.category.AddProduct(smartphone);

                    this.logger.Log($"Smartphone with ID:{smartphone.RealID} was created!");

                    break;
                case "landlinephone":
                    if (commandParameters.Count != 10)
                    {
                        throw new Exception("For creating landline phone you need to enter exacly 10 parameters!");
                    }
                    var landlinePhone = factory.CreateLandlinePhone(commandParameters);

                    this.category.AddProduct(landlinePhone);

                    this.logger.Log($"Landline phone with ID:{landlinePhone.RealID} was created!");

                    break;

                case "laptop":
                    if (commandParameters.Count != 9)
                    {
                        throw new Exception("For creating laptop you need to enter exacly 9 parameters!");
                    }
                    var laptop = factory.CreateLaptop(commandParameters);

                    this.category.AddProduct(laptop);

                    this.logger.Log($"Laptop with ID:{laptop.RealID} was created!");

                    break;
                case "desktoppc":
                    if (commandParameters.Count != 9)
                    {
                        throw new Exception("For desktop pc you need to enter exacly 9 parameters!");
                    }
                    var desktopPc = factory.CreateDesktopComputer(commandParameters);

                    this.category.AddProduct(desktopPc);

                    this.logger.Log($"Desktop computer with ID:{desktopPc.RealID} was created!");

                    break;

                default:
                    throw new ProductTypeNotExistException("Cannot create product of this type!");

            }
        }

        public void AddToShopingCart(int id)
        {
            var prod = FindProduct(id);

            this.shoppingCart.AddProduct(prod);

            this.logger.Log($"{prod.Name} with ID:{id} was added to shopping cart!");
        }

        public IProduct FindProduct(int id)
        {
            if (this.category.DesktopPCs.Any(x => x.RealID == id))
            {
                return this.category.DesktopPCs.First(x => x.RealID == id);
            }
            else if (this.category.Laptops.Any(x => x.RealID == id))
            {
                return this.category.Laptops.First(x => x.RealID == id);
            }
            else if (this.category.LandlinePhones.Any(x => x.RealID == id))
            {
                return this.category.LandlinePhones.First(x => x.RealID == id);
            }
            else if (this.category.Smartphones.Any(x => x.RealID == id))
            {
                return this.category.Smartphones.First(x => x.RealID == id);
            }
            else
            {
                throw new ItemNotFoundException($"Product with ID:{id} does not exist!");
            }
        }

        public void Proccess(IList<string> commands)
        {
            string firstCommand = commands[0];
            commands.RemoveAt(0);

            switch (firstCommand)
            {
                case "create":
                    this.CreateCommand(commands);
                    break;
                case "addToCart":
                    if (commands.Count < 1)
                    {
                        throw new Exception("Must enter ID of the product you want to add into your shopping cart !");
                    }
                    this.AddToShopingCart(int.Parse(commands[0]));
                    break;
                case "remove":
                    if (commands.Count < 1)
                    {
                        throw new Exception("Must enter ID of the product you want to remove from your shopping cart !");
                    }
                    this.RemoveFromShopingCart(int.Parse(commands[0]));
                    break;
                case "show":
                    if (commands[0] == "cart")
                    {
                        if (shoppingCart.Count() == 0)
                        {
                            this.logger.Log("Shopping cart is empty !");
                            break;
                        }
                        this.logger.Log(Decorator.DecorateShoppingCartProducts(shoppingCart));
                        ConsoleKeyInfo orderInput;
                        this.logger.Log($"Order Y/N ?");
                        orderInput = Console.ReadKey();

                        if (orderInput.Key == ConsoleKey.Y)
                        {
                            Random rnd = new Random();
                            decimal deliverCost = shoppingCart.TotalPrice() / 10m;
                            this.logger.Log($"\n\n             ORDER N:{rnd.Next(234234, 988877)}" + $"\n" + $"\nFirst name: Gosho" +
                                $"\nLast name : Goshov" + $"\nTel. number: (+359)870000442" +
                                $"\nAdress: Bulgaria ,Sofia Studentski grad, purviq blok ot lqvo na PLAZZA . A vhod !" +
                                $"\nProducts: " + $"\n{Decorator.DecorateShoppingCartProducts(shoppingCart)}" + $"     + {deliverCost}$ (delivery)" +
                                $"\n\n     T O T A L : {shoppingCart.TotalPrice() + deliverCost}$" + $"\n\nThe order will arrive within three days !" +
                                $"\n\n  <<< Have a nice day and continue shopping ! >>>\n");
                        }
                        else if (orderInput.Key == ConsoleKey.N)
                        {
                            this.logger.Log("\n");
                            break;
                        }
                        break;
                    }
                    this.logger.Log(category.GetListOf(commands[0]));
                    break;
                default:
                    throw new InvalidOperationException("Invalid command! \nPossinble commands are :" +
                        "\n create [type] [args1] [arg2]... [argN]\n addToCart [id]\n remove [id]\n show [collection]");

            }
        }

        private void RemoveFromShopingCart(int id)
        {
            var prod = FindProduct(id);
            this.shoppingCart.RemoveProduct(id);
            Console.WriteLine($"{prod.Name} with ID:{id} was removed from shopping cart!");
        }
    }
}
