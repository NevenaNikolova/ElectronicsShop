using System;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.Products.Phones
{
    public class LandlinePhone : Phone
    {
        private int analogueLines;

        private bool wallMounting;

        public LandlinePhone(string name, decimal price) : base(name, price)
        {
        }

        public LandlinePhone(string name, decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size, int analogueLines, bool wallMounting) 
            : base(name, price, brand, model, colour, battery, displaySize, size)
        {
            this.AnalogueLines = analogueLines;
            this.WallMounting = wallMounting;
        }

        public int AnalogueLines
        {
            get { return this.analogueLines; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of analogue lines should be positive!");
                }
                this.analogueLines = value;
            }
        }
        public bool WallMounting
        {
            get
            {
                return this.wallMounting;
            }
            set
            {           
                this.wallMounting = value;
            }
        }
    }
}
