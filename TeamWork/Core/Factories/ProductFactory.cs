using System;
using System.Collections.Generic;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Core.Factories
{
    internal class ProductFactory : IProductFactory
    {


        //smartphone command
        //create smartphone gosho 900 Asus ZenPhone Black LiIon 16 3 3 3 Atom 4

        //lanlinePhone command
        //create landlinephone gosho 9 VIVACOM Home White LiIon 16 3 3 3 10

        //laptop command
        //create laptop MyLaptop Lenovo ThinkPad 14 4500 i5 8 500 4 1200

        private static IProductFactory instanceHolder = new ProductFactory();
        private int count;

        public ProductFactory()
        {

        }

        public static IProductFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }
    

        public Phone CreateLandlinePhone(IList<string> parameters)
        {
            PhoneSize phoneSize = new PhoneSize(double.Parse(parameters[6]), double.Parse(parameters[7]), double.Parse(parameters[8]));

            var landlinePhone = new LandlinePhone(decimal.Parse(parameters[0]), parameters[1],
                parameters[2], (Colour)Enum.Parse(typeof(Colour), parameters[3]), (BatteryType)Enum.Parse(typeof(BatteryType), parameters[4]),
                int.Parse(parameters[5]), phoneSize, int.Parse(parameters[9]));

            count++;
            return landlinePhone;
        }

        public Phone CreateSmartphone(IList<string> parameters)
        {

            PhoneSize phoneSize = new PhoneSize(double.Parse(parameters[6]), double.Parse(parameters[7]), double.Parse(parameters[8]));

            var phone = new Smartphone(decimal.Parse(parameters[0]), parameters[1],
                parameters[2], (Colour)Enum.Parse(typeof(Colour), parameters[3]), (BatteryType)Enum.Parse(typeof(BatteryType), parameters[4]),
                int.Parse(parameters[5]), phoneSize, parameters[9], int.Parse(parameters[10]));

            count++;
            return phone;
        }

        public PC CreateLaptop(IList<string> parameters)
        {
            var laptop = new Laptop(parameters[0], parameters[1], int.Parse(parameters[2]), int.Parse(parameters[3]),
                parameters[4], int.Parse(parameters[5]), int.Parse(parameters[6]), int.Parse(parameters[7]), int.Parse(parameters[8]));

            count++;
            return laptop;
        }

        public PC CreateDesktopComputer(IList<string> parameters)
        {          
            var desktopPC = new DesktopPC(parameters[0], parameters[1],
                parameters[2], int.Parse(parameters[3]), int.Parse(parameters[4]),
                int.Parse(parameters[5]), decimal.Parse(parameters[6]));

            count++;
            return desktopPC;
        }
    }

}
