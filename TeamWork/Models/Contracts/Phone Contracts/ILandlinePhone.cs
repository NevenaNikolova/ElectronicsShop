using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Products.Electronics.Phones
{
    public interface ILandlinePhone : IProduct , IPhone
    {
        int AnalogueLines { get; set; }
        bool WallMounting { get; set; }
    }
}
