using ElectronicsShop.Models.AbstractClasses;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Interfaces;
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
                $"{pc.Price}" + $"\nID: {pc.RealID}";
        }

        public static string LaptopInfoToShortString(Laptop laptop)
        {
            return ProductInfoShortString(laptop);
        }
        public static string LaptopInfoLongString(Laptop laptop)
        {
            return $"Brand: {laptop.Brand}" + $"\nModel: {laptop.Model}" + $"\nProcessor: {laptop.Processor}" + $"\nRAM: {laptop.Ram}GB" +
                $"\nHDD: {laptop.Hdd}GB" + $"\nVideo card: {laptop.VideoCard}GB" + $"\nDisplay size: {laptop.DisplaySize}'" +
                $"\nBattery capacity: {laptop.BatteryCapacity}mAh" + $"\nPrice: {laptop.Price}$" + $"\nID: {laptop.RealID}";
        }

        public static string SmartphoneInfoToShortString(ISmartphone phone)
        {
            return ProductInfoShortString(phone);
        }
        public static string SmartphoneInfoToLongString(ISmartphone phone)
        {
            return $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}"
                + $"\nDisplay size: {phone.DisplaySize}'" + $"\nProcessor: {phone.Processor}" + $"\nRam: {phone.Ram}GB" + 
                $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}'" + $"\nTickness: {phone.Size.Thickness}'"
                + $"\nBattery: {phone.Battery}" + $"\nPrice: {phone.Price}$" + $"\nID: {phone.RealID}";
        }

        public static string LandlinephoneInfoToShortString(ILandlinePhone phone)
        {
            return ProductInfoShortString(phone);
        }
        public static string LandlinephoneInfoToLongString(ILandlinePhone phone)
        {
            return $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}" +
                $"\nDisplay size: {phone.DisplaySize}'" + $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}" +
                $"\nTickness: {phone.Size.Thickness}'" + $"\nBattery: {phone.Battery}" + $"\nWallmounting: {phone.WallMounting}" +
                $"\nAnalogueLines: {phone.AnalogueLines}" + $"\nID: {phone.RealID}";
        }
    }
}
