using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Electronics.Phones;

namespace TeamWork
{
    class MainClass
    {
        public static void Main()
        {
            Smartphone sm = new Smartphone("usjnad", 500);
            LandlinePhone lphone = new LandlinePhone("ajsn", 100);
        }

    }
}
