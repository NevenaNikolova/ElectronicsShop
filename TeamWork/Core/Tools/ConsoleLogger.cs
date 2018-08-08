using System;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
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
                    sb.Append(Decorator.DecorateProduct((LandlinePhone)product));
                    break;
                default:
                    throw new Exception("There is no such type!");

            }

            this.Log(sb.ToString());
        }
    }
}
