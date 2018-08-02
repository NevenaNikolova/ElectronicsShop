using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    public class CommandHandler
    {
        private IProductFactory factory;

        public CommandHandler()
        {
            this.factory = new ProductFactory();
        }

        public void CreateCommand(IList<string> commandParameters)
        {
            string firstParam = commandParameters[0];
            commandParameters.RemoveAt(0);

            switch (firstParam)
            {
                case "smartphone":
                    factory.CreateSmartphone(commandParameters);
                    break;
                case "landlinephone":
                    factory.CreateLandlinePhone(commandParameters);
                    break;
                case "laptop":
                    factory.CreateLaptop(commandParameters);
                    break;
                case "desktoppc":
                    break;
                default:
                    break;
            }
        }
    }
}
