using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Tools
{
    public class UserException : Exception
    {
        public UserException() : base()
        { }
        public UserException(String message)
        {
            Console.WriteLine(message);
        }
    }
}
