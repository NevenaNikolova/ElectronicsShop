using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Exceptions
{
    class ItemNotFoundException : Exception
    {
        public ItemNotFoundException()
        {

        }

        public ItemNotFoundException(string message)
            : base(message)
        {

        }

        public ItemNotFoundException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
