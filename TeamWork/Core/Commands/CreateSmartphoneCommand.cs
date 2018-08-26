using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Products;
using System.Collections.Generic;


namespace ElectronicsShop.Core.Commands
{
    public class CreateSmartphoneCommand : ICommand
    {
        private IDatabase data;
        private IProductFactory factory;

        public CreateSmartphoneCommand(IDatabase data, IProductFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }


        public string Execute(IList<string> parameters)
        {
            var brand = parameters[0];
            var model = parameters[1];
            var colour = parameters[2];
            var battery = parameters[3];
            var displaySize = parameters[4];
            PhoneSize sizeOfPhone = new PhoneSize(int.Parse(parameters[5]), int.Parse(parameters[6]), int.Parse(parameters[7]));
            PhoneSize size = sizeOfPhone;
            var processor = parameters[8];
            var ram = parameters[9];
            var price = parameters[10];

            var smartphone = this.factory.CreateSmartphone(brand, model, colour, battery, int.Parse(displaySize),
                 size, processor, int.Parse(ram), decimal.Parse(price));
            this.data.Products.Add(smartphone);
            return $"Smartphone with ID:{smartphone.ID} created!";
        }
    }
}
