using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Electronics.AbstractClasses
{

    public class Laptop : PC, IComputer
    {
        private readonly string _name;
        private string _brand;
        private string _model;
        private int _displaySize;
        private int _batteryCapacity;
        private int _id;

        public Laptop(string brand, string model, int displaySize, int batteryCapacity, int id,
            string procesor, int ram, int hdd, int videoCard, string name, int price) 
            : base(procesor,  ram,  hdd,  videoCard, name, price)
        {
            this._name = "Laptop";
            _id = id;
            Brand = brand;
            Model = model;
            DisplaySize = displaySize;
            BatteryCapacity = batteryCapacity;
        }

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

        public override string Print()
        {
                return string.Format("{0} {1} {2}", this.Brand, this.Model, this.Price);
        }
    }
}

