using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    class CreateDesktopPcCommand : ICommand
    {
        private IDatabase data;
        private IProductFactory factory;

        public CreateDesktopPcCommand(IDatabase data, IProductFactory factory)
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

            return this.CreateDesktopPC(brand, model, processor, int.Parse(ram), int.Parse(hdd), int.Parse(videoCard), decimal.Parse(price));
        }

        private string CreateDesktopPC(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price)
        {
            var laptop = this.factory.CreateDesktopComputer(brand, model, processor, ram, hdd, videoCard, price);
            this.data.Products().Add(laptop);
            return string.Format("Computer " + brand + " " + model + "was created.");
        }
    }
}
