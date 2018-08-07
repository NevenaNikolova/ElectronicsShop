using ElectronicsShop.Models;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Electronics.Phones;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products.Electronics.Phones;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Tools
{
    internal static class Decorator
    {
        public static string DecorateProduct(IProduct product)
        {
            StringBuilder sb = new StringBuilder();

            switch (product.GetType().Name)
            {
                case "Laptop":
                    sb.Append(Decorator.LaptopInfoLongString((Laptop)product));
                    break;
                case "DesktopPC":
                    sb.Append(Decorator.DesktopComputerInfoToLongSting((DesktopPC)product));
                    break;
                case "Smartphone":
                    sb.Append(Decorator.SmartphoneInfoToLongString((Smartphone)product));
                    break;
                case "LandlinePhone":
                    sb.Append(Decorator.LandlinephoneInfoToLongString((ILandlinePhone)product));
                    break;
                default:
                    throw new System.Exception("There is no such type!");

            }
            return sb.ToString();
        }

        private static string DesktopComputerInfoToLongSting(PC pc)
        {
            return "\n-----------------------" + $"\nID: {pc.RealID}" + $"\nName: {pc.Name}" + $"\nBrand: {pc.Brand}" + $"\nModel: {pc.Model}" +
                $"\nProcessor: {pc.Processor}" + $"\nRAM capacity: {pc.Ram}" + $"\nHDD capacity: {pc.Hdd}" + $"\nVideo card: {pc.VideoCard}" + $"\nPrice: " +
                $"{pc.Price}$" + "\n-----------------------";
        }

        private static string LaptopInfoLongString(Laptop laptop)
        {
            return "\n-----------------------" + $"\nID: {laptop.RealID}" + $"\nBrand: {laptop.Brand}" + $"\nModel: {laptop.Model}" + $"\nProcessor: {laptop.Processor}" + $"\nRAM: {laptop.Ram}GB" +
                $"\nHDD: {laptop.Hdd}GB" + $"\nVideo card: {laptop.VideoCard}GB" + $"\nDisplay size: {laptop.DisplaySize}'" +
                $"\nBattery capacity: {laptop.BatteryCapacity}mAh" + $"\nPrice: {laptop.Price}$" + "\n-----------------------";
        }

        private static string SmartphoneInfoToLongString(ISmartphone phone)
        {
            return "\n-----------------------" + $"\nID: {phone.RealID}" + $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}"
                + $"\nDisplay size: {phone.DisplaySize}'" + $"\nProcessor: {phone.Processor}" + $"\nRam: {phone.Ram}GB" +
                $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}'" + $"\nTickness: {phone.Size.Thickness}'"
                + $"\nBattery: {phone.Battery}" + $"\nPrice: {phone.Price}$" + "\n-----------------------";
        }

        private static string LandlinephoneInfoToLongString(ILandlinePhone phone)
        {
            return "\n-----------------------" + $"\nID: {phone.RealID}" + $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}" +
                $"\nDisplay size: {phone.DisplaySize}'" + $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}" +
                $"\nTickness: {phone.Size.Thickness}'" + $"\nBattery: {phone.Battery}" + $"\nWallmounting: {phone.WallMounting}" +
                $"\nAnalogueLines: {phone.AnalogueLines}" + $"\nPrice: {phone.Price}" + "\n-----------------------";
        }

        public static string DecorateShoppingCartProducts(ShoppingCart collection)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var prod in collection.ProductList)
            {
                sb.Append(Decorator.DecorateProduct(prod));
            }

            sb.Append(" Total price:     " + collection.TotalPrice() + "$");
            
            return sb.ToString();

        }
    }
}
