using System;
using System.Collections.Generic;
using ElectronicsShop.Models.Electronics.AbstractClasses;
using ElectronicsShop.Models.Electronics.Phones;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Models
{
    public class Category
    {
        private string name;
        private List<Laptop> laptops;
        private List<DesktopPC> desktopPCs;
        private List<Smartphone> smartphones;
        private List<LandlinePhone> landlinePhones;

        public Category(string name)
        {
            this.Name = name;
            this.laptops = new List<Laptop>();
            this.desktopPCs = new List<DesktopPC>();
            this.smartphones = new List<Smartphone>();
            this.landlinePhones = new List<LandlinePhone>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public List<Laptop> Laptops { get => new List<Laptop>(this.laptops); }
        public List<DesktopPC> DesktopPCs { get => new List<DesktopPC>(this.desktopPCs); }
        public List<Smartphone> Smartphones { get => new List<Smartphone>(this.smartphones); }
        public List<LandlinePhone> LandlinePhones { get => new List<LandlinePhone>(this.landlinePhones); }

        public void addProduct(IProduct product)
        {
            switch (product.GetType().Name)
            {
                case "Laptop":
                    this.Laptops.Add((Laptop)product);
                    break;
                case "DesktopPC":
                    this.DesktopPCs.Add((DesktopPC)product);
                    break;
                case "Smartphone":
                    this.Smartphones.Add((Smartphone)product);
                    break;
                case "LandlinePhone":
                    this.LandlinePhones.Add((LandlinePhone)product);
                    break;
                default:
                    throw new ArgumentException("There is no such type!");

            }
        }
        public void RemoveProduct(IProduct product)
        {
            switch (product.GetType().Name)
            {
                case "Laptop":
                    {
                        if (laptops.Contains((Laptop)product))
                        {
                            this.Laptops.Remove((Laptop)product);
                        }
                    }
                    break;
                case "DesktopPC":
                    {
                        if (desktopPCs.Contains((DesktopPC)product))
                        {
                            this.DesktopPCs.Remove((DesktopPC)product);
                        }
                    }
                    break;
                case "Smartphone":
                    {
                        if (smartphones.Contains((Smartphone)product))
                        {
                            this.Smartphones.Remove((Smartphone)product);
                        }
                    }
                    break;
                case "LandlinePhone":
                    {
                        if (landlinePhones.Contains((LandlinePhone)product))
                        {
                            this.LandlinePhones.Remove((LandlinePhone)product);
                        }
                    }
                    break;
                default:
                    throw new ArgumentException("Product not found!");

            }
        }

    }
}
