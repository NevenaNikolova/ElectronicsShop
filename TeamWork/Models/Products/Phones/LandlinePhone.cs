using System;
using ElectronicsShop.Models.Products.Common;

namespace ElectronicsShop.Models.Products.Phones
{
    public class LandlinePhone : Phone
    {
        private int analogueLines;
        private const string ProductName = "LandlinePhone";

        public LandlinePhone(decimal price) : base(ProductName, price)
        {
        }

        public LandlinePhone(decimal price, string brand, string model, Colour colour, BatteryType battery, int displaySize, PhoneSize size, int analogueLines) //bool wallMounting) 
            : base(ProductName, price, brand, model, colour, battery, displaySize, size)
        {
            this.AnalogueLines = analogueLines;
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
    }
}
