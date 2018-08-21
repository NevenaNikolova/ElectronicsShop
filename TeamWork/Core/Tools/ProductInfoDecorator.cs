//using ElectronicsShop.Models;
//using ElectronicsShop.Models.Products;
//using ElectronicsShop.Models.Products.Phones;
//using ElectronicsShop.Models.Interfaces;
//using System;
//using System.Text;
//using ElectronicsShop.Core.Contracts;
//using ElectronicsShop.Models.Contracts.Phone_Contracts;
//using System.Collections.Generic;

//namespace ElectronicsShop.Core.Tools
//{
//    internal static class ProductInfoDecorator
//    {
//        public static string DecorateProduct(IProduct product)
//        {
//            StringBuilder sb = new StringBuilder();

//            switch (product.GetType().Name)
//            {
//                case "Laptop":
//                    sb.Append(LaptopInfoLongString((Laptop)product));
//                    break;
//                case "DesktopPC":
//                    sb.Append(DesktopComputerInfoToLongString((DesktopPC)product));
//                    break;
//                case "Smartphone":
//                    sb.Append(SmartphoneInfoToLongString((ISmartphone)product));
//                    break;
//                case "LandlinePhone":
//                    sb.Append(LandlinephoneInfoToLongString((ILandlinePhone)product));
//                    break;
//                default:
//                    throw new Exception("There is no such type!");

//            }
//            return sb.ToString();
//        }

//        private static string DesktopComputerInfoToLongString(PC pc)
//        {
//            return "\n-----------------------" + $"\nProduct: {pc.GetType().Name}" + $"\nID: {pc.ID}" + $"\nBrand: {pc.Brand}" + $"\nModel: {pc.Model}" +
//                $"\nProcessor: {pc.Processor}" + $"\nRAM capacity: {pc.Ram}GB" + $"\nHDD capacity: {pc.Hdd}GB" + $"\nVideo card: {pc.VideoCard}GB" +
//                $"\nPrice: {pc.Price}$" + "\n-----------------------";
//        }

//        private static string LaptopInfoLongString(Laptop laptop)
//        {
//            return "\n-----------------------" + $"\nProduct: {laptop.GetType().Name}" + $"\nID: {laptop.ID}" + $"\nBrand: {laptop.Brand}" + $"\nModel: {laptop.Model}" + $"\nProcessor: {laptop.Processor}" + $"\nRAM: {laptop.Ram}GB" +
//                $"\nHDD: {laptop.Hdd}GB" + $"\nVideo card: {laptop.VideoCard}GB" + $"\nDisplay size: {laptop.DisplaySize}'" +
//                $"\nBattery capacity: {laptop.BatteryCapacity}mAh" + $"\nPrice: {laptop.Price}$" + "\n-----------------------";
//        }

//        private static string SmartphoneInfoToLongString(ISmartphone phone)
//        {
//            return "\n-----------------------" + $"\nProduct: {phone.GetType().Name}" + $"\nID: {phone.productID}" + $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}"
//                + $"\nDisplay size: {phone.DisplaySize}'" + $"\nProcessor: {phone.Processor}" + $"\nRam: {phone.Ram}GB" +
//                $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}'" + $"\nTickness: {phone.Size.Thickness}'"
//                + $"\nBattery: {phone.Battery}" + $"\nPrice: {phone.Price}$" + "\n-----------------------";
//        }

//        private static string LandlinephoneInfoToLongString(ILandlinePhone phone)
//        {
//            return "\n-----------------------" + $"\nProduct: {phone.GetType().Name}" + $"\nID: {phone.productID}" + $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}" +
//                $"\nDisplay size: {phone.DisplaySize}'" + $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}" +
//                $"\nTickness: {phone.Size.Thickness}'" + $"\nBattery: {phone.Battery}" + $"\nAnalogueLines: {phone.AnalogueLines}" + $"\nPrice: {phone.Price}"
//                + "\n-----------------------";
//        }

//        public static string DecorateShoppingCartProducts(ICollection<IProduct> collection)
//        {
//            StringBuilder sb = new StringBuilder();

//            foreach (var prod in collection)
//            {
//                sb.Append(DecorateProduct(prod));
//            }
//            // calculate total price TODO
//            sb.Append("\nTotal price:     " + "{TOTAL PRICE}" + "$");

//            return sb.ToString();

//        }
//    }
//}
