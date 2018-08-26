using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    class CreateLaptopCommand : ICommand
    {
        private IDatabase data;
        private IProductFactory factory;

        public CreateLaptopCommand(IDatabase data, IProductFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            var brand = parameters[0];
            var model = parameters[1];
            var displaySize = parameters[2];
            var batteryCapacity = parameters[3];
            var processor = parameters[4];
            var ram = parameters[5];
            var hdd = parameters[6];
            var videoCard = parameters[7];
            var price = parameters[8];

            return this.CreateLaptop(brand, model, int.Parse(displaySize), int.Parse(batteryCapacity), processor, int.Parse(ram), int.Parse(hdd), int.Parse(videoCard), int.Parse(price));
        }

        private string CreateLaptop(string brand, string model, int displaySize, int batteryCapacity, string processor, int ram, int hdd, int videoCard, int price)
        {
            var laptop = this.factory.CreateLaptop(brand, model,displaySize, batteryCapacity, processor, ram, hdd, videoCard, price);
            this.data.Products().Add(laptop);
            return string.Format("Laptop " + brand + " " + model + "was created.");
        }
    }
}
