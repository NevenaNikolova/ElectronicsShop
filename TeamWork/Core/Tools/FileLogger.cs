using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ElectronicsShop.Core.Contracts;

namespace ElectronicsShop.Core.Tools
{
    public class FileLogger : ILogger
    {

        public FileLogger()
        {

        }
        public void Log(string message)
        {
            File.AppendAllText(@"C:\LogFile.txt", message);
        }
    }
}
