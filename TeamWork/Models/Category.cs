using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElectronicsShop.Core.Exceptions;
using ElectronicsShop.Core.Tools;
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

        public List<Laptop> Laptops
        {
            get => new List<Laptop>(this.laptops);

        }
        public List<DesktopPC> DesktopPCs
        {
            get => this.desktopPCs;

        }
        public List<Smartphone> Smartphones
        {
            get => new List<Smartphone>(this.smartphones);
        }
        public List<LandlinePhone> LandlinePhones
        {
            get => new List<LandlinePhone>(this.landlinePhones);
        }

        public void addProduct(IProduct product)
        {
            switch (product.GetType().Name)
            {
                case "Laptop":
                    this.laptops.Add((Laptop)product);
                    break;
                case "DesktopPC":
                    this.desktopPCs.Add((DesktopPC)product);
                    break;
                case "Smartphone":
                    this.smartphones.Add((Smartphone)product);
                    break;
                case "LandlinePhone":
                    this.landlinePhones.Add((LandlinePhone)product);
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

        public string GetListOf(string type)
        {
            StringBuilder sb = new StringBuilder();

            switch (type)
            {
                case "laptops":
                    this.Laptops.ForEach(x => sb.Append(Decorator.DecorateProduct(x)));
                    if (sb.Length == 0)
                    {
                        throw new Exception($"{type.ToUpper()} list is empty!");
                    }
                    return sb.ToString();
                case "desktops":
                    this.DesktopPCs.ForEach(x => sb.Append(Decorator.DecorateProduct(x)));
                    if (sb.Length == 0)
                    {
                        throw new Exception($"{type.ToUpper()} list is empty!");
                    }
                    return sb.ToString();
                case "smartphones":
                    this.Smartphones.ForEach(x => sb.Append(Decorator.DecorateProduct(x)));
                    if (sb.Length == 0)
                    {
                        throw new Exception($"{type.ToUpper()} list is empty!");
                    }
                    return sb.ToString();
                case "landlinephones":
                    this.LandlinePhones.ForEach(x => sb.Append(Decorator.DecorateProduct(x)));
                    if (sb.Length == 0)
                    {
                        throw new Exception($"{type.ToUpper()} list is empty!");
                    }
                    return sb.ToString();
                case "cart":


                default:
                    throw new ArgumentException("There is no such type!");
            }
        }

        public IProduct GetProduct(int id)
        {
            if (this.desktopPCs.Any(x => x.ID == id))
            {
                return desktopPCs.First(x => x.ID == id);
            }
            else if (this.LandlinePhones.Any(x => x.ID == id))
            {
                return landlinePhones.First(x => x.ID == id);
            }
            else if (this.laptops.Any(x => x.ID == id))
            {
                return laptops.First(x => x.ID == id);
            }
            else if (this.smartphones.Any(x => x.ID == id))
            {
                return smartphones.First(x => x.ID == id);
            }
            else
            {
                throw new ItemNotFoundException($"Product with ID:{id} does not exist!");
            }
        }

    }
}
