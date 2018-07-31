using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Electronics;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Electronics.AbstractClasses
{
    public class DesktopPC : IPC
    {
        private const string name = "Destop computer";
        private string brand;
        private string model;
        private decimal price;
        private string processor;
        private int ram;
        private int hdd;
        private int videoCard;

        public string Name => name;
        public string Processor
        {
            get => processor;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid processor value!");
                }
                this.Processor = value;
            }
        }
        public string Brand
        {
            get => brand;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid brand!");
                }
                this.Brand = value;
            }
        }
        public string Model
        {
            get => model;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model!");
                }
                this.Model = value;
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }
                this.Price = value;
            }
        }
        public int Ram
        {
            get => ram;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ram memory value cannot be negative!");
                }
            }
        }
        public int Hdd { get => hdd; set => hdd = value; }
        public int VideoCard { get => videoCard; set => videoCard = value; }
        public string Print
        {
            get
            {
                return string.Format("{0} {1} {2}", this.Brand, this.Model, this.Price);
            }
        }

        public DesktopPC()
        {
        }
    }
}
