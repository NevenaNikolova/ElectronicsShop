using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Products;

namespace ElectronicsShop.Models.Electronics.AbstractClasses
{
    public abstract class PC : Product
    {
        private string processor;
        private int ram;
        private int hdd;
        private int videoCard;
        private string brand;
        private string model;
        protected PC(string processor, int ram, int hdd, int videoCard, string productName, decimal price, string brand, string model)
            : base(productName, price)
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
                    throw new ArgumentOutOfRangeException();
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
                    throw new ArgumentOutOfRangeException("Ram memory value cannot be negative!");
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
                    throw new ArgumentOutOfRangeException("Hdd memory value cannot be negative!");
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
                    throw new ArgumentException("Videocard capacity cannot be negative!");
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
