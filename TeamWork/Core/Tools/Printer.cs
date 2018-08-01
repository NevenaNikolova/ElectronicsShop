using ElectronicsShop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.AbstractClasses;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Electronics.Phones;

namespace ElectronicsShop.Core.Tools
{
    public static class Printer
    {
        public static string ProductInfoShortString(IProduct product)
        {
            return $"{product.Name}" + $"\n{product.Price}";
        }

        public static string DesktopComputerInfoToShortString(PC pc)
        {
            return ProductInfoShortString(pc);
        }
        public static string DesktopComputerInfoToLongSting(PC pc)
        {
            return $"{pc.Name}" + $"\nBrand: {pc.Brand}" + $"\nModel: {pc.Model}" + $"Processor: {pc.Processor}"
                + $"\nRAM capacity: {pc.Ram}" + $"\nHDD capacity: {pc.Hdd}" + $"\nVideo card: {pc.VideoCard}" + $"\nPrice: " +
                $"{pc.Price}";
        }

        public static string LaptopInfoToShortString(Laptop laptop)
        {
            return ProductInfoShortString(laptop);
        }
        public static string LaptopInfoLongString(Laptop laptop)
        {
            return $"Brand: {laptop.Brand}" + $"\nModel: {laptop.Model}" + $"\nProcessor: {laptop.Processor}" + $"\nRAM: {laptop.Ram}GB" +
                $"\nHDD: {laptop.Hdd}GB" + $"\nVideo card: {laptop.VideoCard}GB" + $"\nDisplay size: {laptop.DisplaySize}'" +
                $"\nBattery capacity: {laptop.BatteryCapacity}mAh" + $"\nPrice: {laptop.Price}$";
        }

        public static string SmartphoneInfoToShortString(Phone phone)
        {
            return ProductInfoShortString(phone);
        }
        public static string SmartphoneInfoToLongString(Phone phone)
        {
            return $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}"
                + $"\nDisplay size: {phone.DisplaySize}" + $"\nHeight{phone.Height}" + $"\nTickness: {phone.Thickness}"
                + $"\n{phone.Battery}";
        }

        public static string LandlinephoneInfoToShortString(ILandlinePhone phone)
        {
            return ProductInfoShortString(phone);
        }
        public static string LandlinephoneInfoToLongString(ILandlinePhone phone)
        {
            return $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}"
                + $"\nDisplay size: {phone.DisplaySize}" + $"\nHeight{phone.Height}" + $"\nTickness: {phone.Thickness}"
                + $"\n{phone.Battery}" + $"\nWallmounting: {phone.WallMounting}" + $"\nAnalogueLines{phone.AnalogueLines}";
        }
    }
}
