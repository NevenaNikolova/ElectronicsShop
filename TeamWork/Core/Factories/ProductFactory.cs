﻿using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Electronics.Phones;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products.Common;
using ElectronicsShop.Models.Products.Electronics.Common;
using ElectronicsShop.Models.Products.Electronics.Phones;

namespace ElectronicsShop.Core.Factories
{
    public class ProductFactory : IProductFactory
    {
        private static IProductFactory instanceHolder = new ProductFactory();

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

        public ILandlinePhone CreateLandlinePhone(IList<string> parameters
            /*string name, decimal price, string brand, string model, Colour colour, BatteryType battery,
             * int displaySize, double height, double width, double thickness, int analogueLines, bool wallMounting*/)
        {
            var landlinePhone = new LandlinePhone(parameters[0], decimal.Parse(parameters[1]), parameters[2],
                parameters[3], (Colour)Enum.Parse(typeof(Colour), parameters[4]), (BatteryType)Enum.Parse(typeof(BatteryType), parameters[5]),
                int.Parse(parameters[6]), double.Parse(parameters[7]), double.Parse(parameters[8]), double.Parse(parameters[9]),
                int.Parse(parameters[10]), bool.Parse(parameters[11]));

            // this could not be here !
            Console.WriteLine(Printer.LandlinephoneInfoToLongString(landlinePhone));

            return landlinePhone;
        }

        public ISmartphone CreateSmartphone(IList<string> parameters/*string name, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, double height, double width, double thickness, string processor, int ram*/)
        {
            //0.name
            //1.price
            //2.brand
            //3.model
            //4.color
            //5.battery
            //6.displaySize
            //7.height
            //8.width
            //9.tickness
            //10.processor
            //11.ram

            var phone = new Smartphone(parameters[0], decimal.Parse(parameters[1]), parameters[2],
                parameters[3], (Colour)Enum.Parse(typeof(Colour), parameters[4]), (BatteryType)Enum.Parse(typeof(BatteryType), parameters[5]),
                int.Parse(parameters[6]), double.Parse(parameters[7]), double.Parse(parameters[8]), double.Parse(parameters[9]),
                parameters[10], int.Parse(parameters[11]));

            //this could not be here!
            Console.WriteLine(Printer.SmartphoneInfoToLongString(phone));

            return phone;
        }

        //0.name
        //1.price
        //2.brand
        //3.model
        //4.color
        //5.battery
        //6.displaySize
        //7.height
        //8.width
        //9.tickness
        //10.processor
        //11.ram
        public PC CreateLaptop(IList<string> parameters)
        {
            var laptop = new Laptop(parameters[0],parameters[1],parameters[2],int.Parse(parameters[3]),int.Parse(parameters[4]),
                parameters[5],int.Parse(parameters[6]), int.Parse(parameters[7]),int.Parse(parameters[8]),int.Parse(parameters[9]));

            Console.WriteLine(Printer.LaptopInfoLongString(laptop));

            return laptop;
        }
    }
}
