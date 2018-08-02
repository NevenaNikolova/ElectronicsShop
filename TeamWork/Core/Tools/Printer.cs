using ElectronicsShop.Models.AbstractClasses;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products.Electronics.Phones;

namespace ElectronicsShop.Core.Tools
{
    public static class Printer
    {
       
               public static string DesktopComputerInfoToLongSting(PC pc)
        {
            return "-----------------------" + $"\nID: {pc.RealID}" + $"{pc.Name}" + $"\nBrand: {pc.Brand}" + $"\nModel: {pc.Model}" + $"Processor: {pc.Processor}"
                + $"\nRAM capacity: {pc.Ram}" + $"\nHDD capacity: {pc.Hdd}" + $"\nVideo card: {pc.VideoCard}" + $"\nPrice: " +
                $"{pc.Price}" + "\n-----------------------";
        }

        
        public static string LaptopInfoLongString(Laptop laptop)
        {
            return "-----------------------" + $"\nID: {laptop.RealID}" + $"Brand: {laptop.Brand}" + $"\nModel: {laptop.Model}" + $"\nProcessor: {laptop.Processor}" + $"\nRAM: {laptop.Ram}GB" +
                $"\nHDD: {laptop.Hdd}GB" + $"\nVideo card: {laptop.VideoCard}GB" + $"\nDisplay size: {laptop.DisplaySize}'" +
                $"\nBattery capacity: {laptop.BatteryCapacity}mAh" + $"\nPrice: {laptop.Price}$" + "\n-----------------------";
        }

        
        public static string SmartphoneInfoToLongString(ISmartphone phone)
        {
            return "-----------------------" + $"\nID: {phone.RealID}" + $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}"
                + $"\nDisplay size: {phone.DisplaySize}'" + $"\nProcessor: {phone.Processor}" + $"\nRam: {phone.Ram}GB" +
                $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}'" + $"\nTickness: {phone.Size.Thickness}'"
                + $"\nBattery: {phone.Battery}" + $"\nPrice: {phone.Price}" + "\n-----------------------";
        }

       
        public static string LandlinephoneInfoToLongString(ILandlinePhone phone)
        {
            return "-----------------------" + $"\nID: {phone.RealID}" + $"\nBrand: {phone.Brand}" + $"\nModel: {phone.Model}" + $"\nColor: {phone.Colour}" +
                $"\nDisplay size: {phone.DisplaySize}'" + $"\nHeight: {phone.Size.Height}'" + $"\nWidth: {phone.Size.Width}" +
                $"\nTickness: {phone.Size.Thickness}'" + $"\nBattery: {phone.Battery}" + $"\nWallmounting: {phone.WallMounting}" +
                $"\nAnalogueLines: {phone.AnalogueLines}" + "\n-----------------------";
        }
    }
}
