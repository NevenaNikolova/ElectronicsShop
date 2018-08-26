using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands.Contracts
{
    public interface ICommandFactory
    {
        //void CreateCommand(IList<string> commandParameters);

        //void Process(IList<string> commands);
        ICommand GetCommand(string commandName);
        
    }
}
