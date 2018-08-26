using System.Collections.Generic;

namespace ElectronicsShop.Core.Commands
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
