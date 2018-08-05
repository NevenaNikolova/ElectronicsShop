using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Exceptions
{
    public class UserException : Exception
    {
        public UserException() : base()
        {

        }
        public UserException(String message)
        {
            Console.WriteLine(message);
        }
    }
}
