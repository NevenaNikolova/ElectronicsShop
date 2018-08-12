using System;

namespace ElectronicsShop.Core.Exceptions
{
    class ProductTypeNotExistException : Exception
    {
        public ProductTypeNotExistException()
        {

        }
        public ProductTypeNotExistException(string message)
            :base(message)
        {

        }
        public ProductTypeNotExistException(string message, Exception inner)
            : base(message,inner)
        {

        }
    }
}
