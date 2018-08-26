using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Models.Contracts;
using System;
using System.Collections.Generic;

namespace ElectronicsShop.Core.Commands
{
    public class AddToShoppingCartCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly IShoppingCart shoppingCart;

        public AddToShoppingCartCommand(IDatabase database, IShoppingCart shoppingCart)
        {
            this.database = database;
            this.shoppingCart = shoppingCart;
        }
        public string Execute(IList<string> parameters)
        {

            if (parameters.Count < 1)
            {
                throw new Exception("Must enter ID of the product you want to add into your shopping cart !");
            }
            var product = database.GetProduct(int.Parse(parameters[0]));
            this.shoppingCart.AddProduct(product);
            return $"{product.GetType().Name} with ID: {product.ID} was added to shopping cart!";
        }
    }
}
