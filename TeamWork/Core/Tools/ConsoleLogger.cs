using System;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Models;
using ElectronicsShop.Models.AbstractClasses;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Electronics.Phones;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products.Electronics.Phones;
using System.Collections;
using System.Text;

namespace ElectronicsShop.Core.Tools
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Log(IProduct product)
        {
            StringBuilder sb = new StringBuilder();

            switch (product.GetType().Name)
            {
                case "Laptop":
                    sb.Append(Decorator.DecorateProduct((Laptop)product));
                    break;
                case "DesktopPC":
                    sb.Append(Decorator.DecorateProduct((DesktopPC)product));
                    break;
                case "Smartphone":
                    sb.Append(Decorator.DecorateProduct((Smartphone)product));
                    break;
                case "LandlinePhone":
                    sb.Append(Decorator.DecorateProduct((ILandlinePhone)product));
                    break;
                default:
                    throw new Exception("There is no such type!");

            }

            this.Log(sb.ToString());
        }
    }
}
