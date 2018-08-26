using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Products;
using System.Collections.Generic;


namespace ElectronicsShop.Core.Commands
{
    class CreateLandlinephoneCommand : ICommand
    {
        private IDatabase data;
        private IProductFactory factory;

        public CreateLandlinephoneCommand(IDatabase data, IProductFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            /*
             decimal price, string brand, string model, string colour, int displaySize, PhoneSize size, int analogueLines)
      
             */
            var brand = parameters[0];
            var model = parameters[1];
            var colour = parameters[2];
            int displaySize = int.Parse(parameters[3]);
            PhoneSize phoneSize = new PhoneSize(double.Parse(parameters[4]), double.Parse(parameters[5]), double.Parse(parameters[6]));
            int analogueLines = int.Parse(parameters[7]);
            decimal price = decimal.Parse(parameters[8]);
            var landlinephone = this.factory.CreateLandlinePhone(brand, model, colour, displaySize, phoneSize, analogueLines,price);
            this.data.Products.Add(landlinephone);
            return $"LandlinePhone with ID:{landlinephone.ID} created!";
        }
    }
}
