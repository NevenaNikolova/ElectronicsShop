using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.ComputerContracts;
using System;

namespace ElectronicsShop.Models.Products
{

    public class Laptop : ILaptop, IPrintable
    {

        private string processor;
        private int ram;
        private int hdd;
        private int videoCard;
        private string brand;
        private string model;
        private int displaySize;
        private int batteryCapacity;
        private decimal price;
        private int id;


        public int ID
        {
            get
            {
                return this.id;
            }
            set => this.id = IdProvider.Instance().GetID();
        }
        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid brand value!");
                }
                this.brand = value;
            }

        }
        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid model value!");
                }
                this.model = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("The processor should be specified!");
                }
                else this.processor = value;
            }
        }
        public int Ram
        {
            get { return this.ram; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Ram memory value cannot be negative!");
                }
                else this.ram = value;
            }
        }
        public int Hdd
        {
            get { return this.hdd; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Hdd memory value cannot be negative!");
                }
                else this.hdd = value;
            }
        }
        public int DisplaySize
        {
            get => displaySize;
            private set
            {
                if (value < 11 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Display size cannot be less than 11 and bigger than 20!");
                }
                this.displaySize = value;
            }
        }
        public int BatteryCapacity
        {
            get => batteryCapacity;
            private set
            {
                if (value < 1500)
                {
                    throw new ArgumentOutOfRangeException("Battery capacity cannot less than 1500mAh!");
                }
                this.batteryCapacity = value;
            }
        }
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public int VideoCard
        {
            get { return this.videoCard; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The videocard capacity cannot be negative!");
                }
                else this.videoCard = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Too low price!");
                }
                else this.price = value;
            }
        }

        public Laptop(string brand, string model, int displaySize, int batteryCapacity,
    string processor, int ram, int hdd, int videoCard, decimal price)
        {
            this.ID = id;
            this.Brand = brand;
            this.Model = model;
            this.DisplaySize = displaySize;
            this.BatteryCapacity = batteryCapacity;
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.VideoCard = videoCard;
            this.Price = price;
        }

        public Laptop()
        {
        }

        public string Print()
        {
            return "\n-----------------------" +
                $"\nProduct: {this.GetType().Name}" + $"\nID: {this.ID}" + $"\nBrand: {this.Brand}" +
                $"\nModel: {this.Model}" + $"\nProcessor: {this.Processor}" + $"\nRAM: {this.Ram}GB" +
                $"\nHDD: {this.Hdd}GB" + $"\nVideo card: {this.VideoCard}GB" + $"\nDisplay size: {this.DisplaySize}'" +
                $"\nBattery capacity: {this.BatteryCapacity}mAh" + $"\nPrice: {this.Price}$" +
                   "\n-----------------------";
        }
    }
}

