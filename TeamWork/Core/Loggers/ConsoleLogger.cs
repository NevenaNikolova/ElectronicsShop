using System;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Models.ComputerContracts;
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

            sb.Append(product.Print());
            
            this.Log(sb.ToString());
        }

    }
}

