using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models.Electronics.AbstractClasses
{

    public class Laptop : PC, IComputer
    {
        //private string _brand;
        //private string _model;
        private int displaySize;
        private int batteryCapacity;


        public Laptop(string name,string brand, string model, int displaySize, int batteryCapacity,
            string procesor, int ram, int hdd, int videoCard, int price)
            : base(procesor, ram, hdd, videoCard, name, price, brand, model)
        {
           
            //Brand = brand;
            //Model = model;
            DisplaySize = displaySize;
            BatteryCapacity = batteryCapacity;
        }

        public override string Name
        {
            get
            {
                return base.Name;
            }
        }

        //public string Brand
        //{
        //    get => _brand;
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException("Invalid brand value!");
        //        }
        //        this._brand = value;
        //    }
        //}

        //public string Model
        //{
        //    get => _model;
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException("Invalid model value!");
        //        }
        //        this._model = value;
        //    }
        //}

        public int DisplaySize
        {
            get => displaySize;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Display size cannot be negative!");
                }
                this.displaySize = value;
            }
        }

        public int BatteryCapacity
        {
            get => batteryCapacity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery capacity cannot be negative!");
                }
                this.batteryCapacity = value;
            }
        }


    }
}

