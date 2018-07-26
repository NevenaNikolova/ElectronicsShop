using System;
using System.Collections.Generic;
using System.Text;

namespace TeamWork.Models.Electronics.AbstractClasses
{
    public class Laptop : PC
    {
        private int displaySize;
        private string displayType;
        private string model;
        private string manofacturer;

        public Laptop(int displaySize, string displayType, string model,
            string manofacturer, string pricesor, int ram, int hdd, int videoCard)
            : base(pricesor, ram, hdd, videoCard)
        {

        }

        public int DisplaySize { get => displaySize; set => displaySize = value; }
        public string DisplayType { get => displayType; set => displayType = value; }
        public string Model { get => model; set => model = value; }
        public string Manofacturer { get => manofacturer; set => manofacturer = value; }
    }
}
