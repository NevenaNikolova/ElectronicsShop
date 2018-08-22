using System;
using System.IO;
using System.Text;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Core.Tools;

namespace ElectronicsShop.Core.Loggers
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"../../LogFile.txt", message);
        }

        public void LogProductInfo(IProduct product)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(product.Print());

            this.Log(sb.ToString());
        }
    }
}
