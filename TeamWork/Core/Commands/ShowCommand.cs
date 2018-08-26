using ElectronicsShop.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    public class ShowCommand : ICommand
    {
        private readonly IDatabase database;

        public ShowCommand(IDatabase database)
        {
            this.database = database;
        }
        public string Execute(IList<string> parameters)
        {           
            var result= database.GetList(parameters[0]);
            return result;
        }
    }
}
