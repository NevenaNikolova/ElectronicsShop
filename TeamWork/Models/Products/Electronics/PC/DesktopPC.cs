using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models.Electronics;
using TeamWork.Models.Interfaces;

namespace TeamWork.Models.Electronics.AbstractClasses
{
    public class DesktopPC : PC, IComputer
    {
        private readonly string name;
        private string brand;
        private string model;


        public DesktopPC(string brand, string model, string procesor, int ram,
            int hdd, int videoCard, string productName, int price)
            : base(procesor, ram, hdd, videoCard, productName, price)
        {
            this.name = "Desktop Computer";
            this.brand = brand;
            this.model = model;
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
        
        public override string Print()
        {
                return string.Format("{0} {1} {2}", this.Brand, this.Model, this.Price);
        }
    }
}
