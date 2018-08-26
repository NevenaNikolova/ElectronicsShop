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
            var batteryCapacity = parameters[2];
            var processor = parameters[3];
            int ram = int.Parse(parameters[4]);
            int hdd = int.Parse(parameters[5]);
            int videoCard = int.Parse(parameters[6]);
            decimal price = decimal.Parse(parameters[7]);

            var desktopComputer = this.factory.CreateDesktopComputer(brand, model, processor, ram, hdd, videoCard, price);
            this.data.Products.Add(desktopComputer);
            return $"Desktop computer with ID:{desktopComputer.ID} created!";
        }

    }
}
