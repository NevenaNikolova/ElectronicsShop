using System.Collections.Generic;

namespace ElectronicsShop.Core.Commands
{
    interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
