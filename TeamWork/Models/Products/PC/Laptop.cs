using System;

namespace ElectronicsShop.Models.Products
{

    public class Laptop : PC
    {
        private const string ProductName = "Laptop";
        private int displaySize;
        private int batteryCapacity;


        public Laptop(string brand, string model, int displaySize, int batteryCapacity,
            string procesor, int ram, int hdd, int videoCard, int price)
            : base(procesor, ram, hdd, videoCard, ProductName, price, brand, model)
        {          
            this.DisplaySize = displaySize;
            this.BatteryCapacity = batteryCapacity;
        }
   
        public override string Name
        {
            get
            {
                return base.Name;
            }
        }
       
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

