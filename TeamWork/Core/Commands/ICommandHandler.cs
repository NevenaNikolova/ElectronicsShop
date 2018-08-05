using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Commands
{
    interface ICommandHandler
    {
        void CreateCommand(IList<string> commandParameters);

    }
}
