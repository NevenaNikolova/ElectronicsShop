using ElectronicsShop.Core.Exceptions;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    public class CommandHandler : ICommandHandler
    {
        private IProductFactory factory;
        private readonly Category category = new Category("Products");
        private ShopingCart shoppintCart;

        public CommandHandler()
        {
            this.factory = new ProductFactory();
            
            this.shoppintCart = new ShopingCart();
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
                    break;
                case "landlinephone":
                    var landlinePhone = factory.CreateLandlinePhone(commandParameters);
                    this.category.addProduct(landlinePhone);
                    break;
                case "laptop":
                    var laptop = factory.CreateLaptop(commandParameters);
                    this.category.addProduct(laptop);
                    break;
                case "desktoppc":
                    var desktopPc = factory.CreateDesktopComputer(commandParameters);
                    this.category.addProduct(desktopPc);
                    
                    break;
                default:
                    throw new ProductTypeNotExistException("Cannot create product of this type!");

            }
        }

        public void Add(int id)
        {
            var prod = FindProduct(id);

            this.shoppintCart.AddProduct(prod);
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
                throw new ItemNotFoundException("This ID dont exist!");
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
                    this.Add(int.Parse(commands[0]));
                    break;
                case "remove":
                    break;
                case "logout":
                    break;
                case "show":
                    Console.WriteLine(category.ShowList(commands[0]));
                    break;
                default:
                    break;
            }
        }
    }
}
