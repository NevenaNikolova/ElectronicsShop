using System;

namespace ElectronicsShop.Core.Exceptions
{
    public class UserException : Exception
    {
        public UserException() : base()
        {

        }
        public UserException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
