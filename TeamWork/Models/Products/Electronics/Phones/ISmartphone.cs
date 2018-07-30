using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Products.Electronics.Phones
{
    public interface ISmartphone:IProducts
    {
        string Processor { get; set; }
        int Ram { get; set; }
    }
}
