using System.Collections.Generic;

namespace ElectronicsShop.Core.Commands
{
    interface ICommandHandler
    {
        void CreateCommand(IList<string> commandParameters);

        void Proccess(IList<string> commands);
    }
}
