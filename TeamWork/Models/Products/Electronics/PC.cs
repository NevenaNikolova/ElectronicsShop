using System;
using System.Collections.Generic;
using System.Text;
using TeamWork.Models;
using TeamWork.Models.Products;

namespace TeamWork.Models.Electronics.AbstractClasses
{
        public abstract class PC : Product
        {
            private string processor;
            private int ram;
            private int hdd;
            private int videoCard;
            private object procesor;

            protected PC(string procesor, int ram, int hdd, int videoCard, string productName, int price) : base(productName, price)
            {
                this.Procesor = procesor;
                this.Ram = ram;
                this.Hdd = hdd;
                this.VideoCard = videoCard;
            }

            public string Procesor { get; set; }
            public int Ram { get; set; }
            public int Hdd { get; set; }
            public int VideoCard { get; set; }

        }
}
