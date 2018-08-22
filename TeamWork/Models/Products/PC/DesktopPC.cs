using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Interfaces;
using System;

namespace ElectronicsShop.Models.Products
{
    public class DesktopPC : IComputer, IPrintable
    {
        //private const string ProductName = "DesktopPC";

        private string brand;
        private string model;
        private string processor;
        private int ram;
        private int hdd;
        private int videoCard;
        private decimal price;
        private int id;
        private string name;

        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid brand value!");
                }
                this.brand = value;
            }

        }
        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model value!");
                }
                this.model = value;
            }
        }
        public virtual decimal Price
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
        public string Processor
        {
            get { return this.processor; }
            set
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
            set
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
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Hdd memory value cannot be negative!");
                }
                else this.hdd = value;
            }
        }
        public int VideoCard
        {
            get { return this.videoCard; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The videocard capacity cannot be negative!");
                }
                else this.videoCard = value;
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            { this.id = value; }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        
        public DesktopPC(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.VideoCard = videoCard;
            this.Price = price;
        }

        public string Print()
        {
            return "\n-----------------------" + $"\nProduct: {this.GetType().Name}" + $"\nID: {this.ID}"
                + $"\nBrand: {this.Brand}" + $"\nModel: {this.Model}" + $"\nProcessor: {this.Processor}" +
                $"\nRAM capacity: {this.Ram}GB" + $"\nHDD capacity: {this.Hdd}GB" + $"\nVideo card: {this.VideoCard}GB" +
                $"\nPrice: {this.Price}$" + "\n-----------------------";
        }
    }
}
