using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.Electronics;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models.Electronics.AbstractClasses
{
    public class DesktopPC : PC, IComputer
    {
        private readonly string name;
        //private string brand;
        //private string model;


        public DesktopPC(string brand, string model, string procesor, int ram,
            int hdd, int videoCard, string name, int price)
            : base(procesor, ram, hdd, videoCard, name, price,brand,model)
        {

            //this.brand = brand;
            //this.model = model;
        }
        
        //public string Brand
        //{
        //    get => brand;
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException("Invalid brand!");
        //        }
        //        this.Brand = value;
        //    }
        //}
        //public string Model
        //{
        //    get => model;
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException("Invalid model!");
        //        }
        //        this.Model = value;
        //    }
        //}
        
       
    }
}
