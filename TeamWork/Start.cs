using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using TeamWork.Core.Tools;
using TeamWork.Models;
using TeamWork.Models.Electronics.AbstractClasses;
using TeamWork.Models.Products;
=======
using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Products;
>>>>>>> b664ffc50c38c229d941edde162ca4da720dc095

namespace ElectronicsShop
{
    class Start
    {
        public static void Main()
        {
            Category category = new Category("Electronics");
            Laptop laptop = new Laptop("ASUS","ZenBook",16,2500,"Intel i7-UXJS",4,512,2,1000);
            //ShopingCart shopingCart = new ShopingCart();
            //shopingCart.AddProduct(laptop);
            //Console.WriteLine(string.Join(" ", shopingCart));
            Console.WriteLine(Printer.LaptopInfoToShortString(laptop));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(Printer.LaptopInfoLongString(laptop));
        }
    }
}
