using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ElectronicsShop.Core.Contracts;

namespace ElectronicsShop.Core.Tools
{
    public class Logger : ILogger
    {
        public Logger()
        {

        }
        public void Log(string message)
        {
            File.AppendAllText("LogFile.txt", message);
        }
    }
}
