﻿using System;
using System.Collections.Generic;
using System.Text;
using ElectronicsShop.Models.Electronics;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models.Electronics.AbstractClasses
{
    public class DesktopPC : PC, IComputer
    {
        //private readonly string name;
        //private string brand;
        //private string model;


        public DesktopPC(string name, string brand, string model, string procesor, int ram,
            int hdd, int videoCard, decimal price)
            : base(procesor, ram, hdd, videoCard, name, price, brand, model)
        {


        }

    }
}
