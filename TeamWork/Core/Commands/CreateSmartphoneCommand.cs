using ElectronicsShop.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    public class CreateSmartphoneCommand : ICommand
    {
        private IDatabase data;
        
        public string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
