using System;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using System.Text;
using ElectronicsShop.Core.Tools;

namespace ElectronicsShop.Core.Loggers
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void LogProductInfo(IProduct product)
        {
            StringBuilder sb = new StringBuilder();

            switch (product.GetType().Name)
            {
                case "Laptop":
                    sb.Append(ProductInfoDecorator.DecorateProduct((Laptop)product));
                    break;
                case "DesktopPC":
                    sb.Append(ProductInfoDecorator.DecorateProduct((DesktopPC)product));
                    break;
                case "Smartphone":
                    sb.Append(ProductInfoDecorator.DecorateProduct((Smartphone)product));
                    break;
                case "LandlinePhone":
                    sb.Append(ProductInfoDecorator.DecorateProduct((LandlinePhone)product));
                    break;
                default:
                    throw new Exception("There is no such type!");

            }

            this.Log(sb.ToString());
        }
    }
}
