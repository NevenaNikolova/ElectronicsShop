using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models;
namespace TeamWork.Models.Electronics.AbstractClasses
{
    public abstract class Phones : Product
    {
        bool parameters;

        protected Phones(bool parameters, string productName, int price) : base(productName, price)
        {
            this.parameters = parameters;
        }

    }
}
