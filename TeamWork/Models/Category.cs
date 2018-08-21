using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElectronicsShop.Core.Exceptions;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Contracts.Phone_Contracts;
using ElectronicsShop.Models.Interfaces;
using ElectronicsShop.Models.Products;
using ElectronicsShop.Models.Products.Phones;


namespace ElectronicsShop.Models
{
    public class Category
    {
        private string name;
        private List<Laptop> laptops;
        private List<DesktopPC> desktopPCs;
        private List<ISmartphone> smartphones;
        private List<ILandlinePhone> landlinePhones;

        public Category(string name)
        {
            this.Name = name;
            this.laptops = new List<Laptop>();
            this.desktopPCs = new List<DesktopPC>();
            this.smartphones = new List<ISmartphone>();
            this.landlinePhones = new List<ILandlinePhone>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name cannot be empty!");
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
        public List<ISmartphone> Smartphones
        {
            get => new List<ISmartphone>(this.smartphones);
        }
        public List<ILandlinePhone> LandlinePhones
        {
            get => new List<ILandlinePhone>(this.landlinePhones);
        }

        public void AddProduct(IProduct product)
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
                    this.smartphones.Add((ISmartphone)product);
                    break;
                case "LandlinePhone":
                    this.landlinePhones.Add((ILandlinePhone)product);
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
                            this.Smartphones.Remove(product as Smartphone);
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
                    throw new ArgumentException("This product was not found!");

            }
        }

        public string GetListOf(string type)
        {
            StringBuilder sb = new StringBuilder();

            switch (type)
            {
                case "laptops":
                    this.Laptops.ForEach(x => sb.Append(ProductInfoDecorator.DecorateProduct(x)));
                    break;
                case "desktops":
                    this.DesktopPCs.ForEach(x => sb.Append(ProductInfoDecorator.DecorateProduct(x)));
                    break;
                case "smartphones":
                    this.Smartphones.ForEach(x => sb.Append(ProductInfoDecorator.DecorateProduct(x)));
                    break;
                case "landlinephones":
                    this.LandlinePhones.ForEach(x => sb.Append(ProductInfoDecorator.DecorateProduct(x)));
                    break;
                default:
                    throw new ArgumentException("There is no such type!");
            }

            if (sb.Length == 0)
            {
                throw new Exception($"{type.ToUpper()} list is empty!");
            }
            return sb.ToString();
        }

        public IProduct GetProduct(int id)
        {
            var aggregateList = new List<IProduct>();
            aggregateList.Concat(this.desktopPCs);
            aggregateList.Concat(this.LandlinePhones);
            aggregateList.Concat(this.laptops);
            aggregateList.Concat(this.smartphones);

            var itemFound = aggregateList.FirstOrDefault(p => p.productID == id);

            if (itemFound is null)
            {
                throw new ItemNotFoundException($"Product with ID:{id} does not exist!");
            }

            return itemFound;
        }

    }
}
