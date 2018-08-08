using ElectronicsShop.Models.Interfaces;
using System;



namespace ElectronicsShop.Models.Products
{
    public abstract class PC : Product, IComputer
    {
        private string processor;
        private int ram;
        private int hdd;
        private int videoCard;
        private string brand;
        private string model;
        protected PC(string processor, int ram, int hdd, int videoCard, string name, decimal price, string brand, string model)
            : base(name, price)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.VideoCard = videoCard;
            this.Brand = brand;
            this.Model = model;
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
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
    }
}
