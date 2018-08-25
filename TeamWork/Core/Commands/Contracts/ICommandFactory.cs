using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands.Contracts
{
    interface ICommandFactory
    {
        void CreateCommand(IList<string> commandParameters);

        void Process(IList<string> commands);
    }
}
