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

        protected PC(string procesor, int ram, int hdd, int videoCard, string productName, int price) 
            : base(productName, price)
        {
            this.Procesor = procesor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.VideoCard = videoCard;
        }

        public string Procesor
        {
            get { return this.processor; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else this.processor = value;
            }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 256)
                {
                    throw new ArgumentException("Don't buy this product. \n" +
                        "There is no Computer with lower ram than 256MB!!");
                }
                else this.ram = value;
            }
        }
        public int Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value < 256)
                {
                    throw new ArgumentException("Don't buy this product. \n" +
                        "There is no Computer with lower hdd than 256MB!!");
                }
                else this.hdd = value;
            }
        }
        public int VideoCard
        {
            get { return this.videoCard; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                else this.videoCard = value;
            }
        }
        

    }
}
