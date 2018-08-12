using System;
using System.IO;
using System.Text;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Core.Tools
{
    internal class FileLogger : ILogger
    {        
        public void Log(string message)
        {
            File.AppendAllText(@"../../LogFile.txt", message);
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
