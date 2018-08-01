using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.AbstractClasses;
using TeamWork.Models.Electronics.AbstractClasses;
using TeamWork.Models.Products.Common;
using TeamWork.Models.Products.Electronics.Common;
using TeamWork.Models.Products.Electronics.Phones;

namespace TeamWork.Models.Electronics.Phones
{
    public class LandlinePhone : Phone, ILandlinePhone
    {
        private int analogueLines;

        private bool wallMounting;

        public LandlinePhone(string name, decimal price) : base(name, price)
        {
        }

        public LandlinePhone(string name, decimal price, string brand, string model, Colour colour, BatteryType battery,
            int displaySize, double height, double width, double thickness, int analogueLines, bool wallMounting)
            : base(name, price, brand, model, colour, battery, displaySize, height, width, thickness)
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
                    throw new ArgumentOutOfRangeException();
                }
                this.analogueLines = value;
            }
        }
        public bool WallMounting
        {
            get { return this.wallMounting; }
            set { this.wallMounting = value; }
        }
       
    }
}
