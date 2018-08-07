using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Exceptions;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    internal class CommandHandler : ICommandHandler
    {
        private IProductFactory factory;
        private readonly Category category = new Category("Products");
        private ShoppingCart shoppingCart;
        private ILogger logger;

        public CommandHandler(IProductFactory factory,ILogger logger)
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
                    var smartphone = factory.CreateSmartphone(commandParameters);
                    
                    this.category.addProduct(smartphone);

                    this.logger.Log($"Smartphone with ID:{smartphone.RealID} created!");

                    break;

                case "landlinephone":
                    var landlinePhone = factory.CreateLandlinePhone(commandParameters);

                    this.category.addProduct(landlinePhone);

                    this.logger.Log($"Landline phone with ID:{landlinePhone.RealID} created!");

                    break;

                case "laptop":
                    var laptop = factory.CreateLaptop(commandParameters);

                    this.category.addProduct(laptop);  

                    this.logger.Log($"Laptop with ID:{laptop.RealID} created!");

                    break;
                case "desktoppc":
                    var desktopPc = factory.CreateDesktopComputer(commandParameters);

                    this.category.addProduct(desktopPc);

                    this.logger.Log($"Desktop computer with ID:{desktopPc.RealID} created!");

                    break;

                default:
                    throw new ProductTypeNotExistException("Cannot create product of this type!");

            }
        }

        public void AddToShopingCart(int id)
        {
            var prod = FindProduct(id);

            this.shoppingCart.AddProduct(prod);

            this.logger.Log($"{prod.GetType().Name} with ID:{id} added to shopping cart!");
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
                throw new ItemNotFoundException($"Product with ID:{id} doesnt exist!");
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
                    this.AddToShopingCart(int.Parse(commands[0]));
                    break;
                case "remove":
                    this.RemoveFromShopingCart(int.Parse(commands[0]));
                    break;
                case "show":
                    if (commands[0] == "cart")
                    {
                        this.logger.Log(Decorator.DecorateShoppingCartProducts(shoppingCart));
                        break;
                    }
                    this.logger.Log(category.GetListOf(commands[0]));
                    break;
                default:
                    break;
            }
        }

        private void RemoveFromShopingCart(int id)
        {
            this.shoppingCart.RemoveProduct(id);
            Console.WriteLine($"Product with ID:{id} removed from shopping cart!");
        }
    }
}
