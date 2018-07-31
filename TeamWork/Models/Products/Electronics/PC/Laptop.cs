using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Electronics.AbstractClasses
{

    public class Laptop 
    {
        private const string _name = "Laptop";
        private string _brand;
        private string _model;
        private decimal _price;
        private string _processor;
        private int _ram;
        private int _hdd;
        private int _videoCard;
        private int _displaySize;
        private int _batteryCapacity;
        private int _id;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid brand value!");
                }
                this._brand = value;
            }
        }

        public string Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model value!");
                }
                this._model = value;
            }
        }

        public decimal Price
        {
            get => _price;
            private set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("Price value cannot be negative!");
                }
                this._price = value;
            }
        }

        public string Processor
        {
            get => _processor; set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid processor value!");
                }
                this._processor = value;
            }
        }

        public int Ram
        {
            get => _ram;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RAM memory capacity cannot be negative!");
                }
                this._ram = value;
            }
        }

        public int Hdd
        {
            get => _hdd;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HDD capacity canot be negative!");
                }
                this._hdd = value;
            }
        }

        public int VideoCard
        {
            get => _videoCard;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Video card capacity cannot be negative!");
                }
                this._videoCard = value;
            }
        }

        public int DisplaySize
        {
            get => _displaySize;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Display size cannot be negative!");
                }
                this._displaySize = value;
            }
        }

        public int BatteryCapacity
        {
            get => _batteryCapacity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery capacity cannot be negative!");
                }
                this._batteryCapacity = value;
            }
        }

        public string Print
        {
            get
            {
                return string.Format("{0} {1} {2}", this.Brand, this.Model, this.Price);
            }

        }


        public Laptop(string brand, string model, decimal price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }

    }
}

