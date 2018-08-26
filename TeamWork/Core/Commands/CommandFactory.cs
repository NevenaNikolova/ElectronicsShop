
using ElectronicsShop.Core.Commands.Contracts;
using Autofac;

namespace ElectronicsShop.Core.Commands
{
    internal class CommandFactory : ICommandFactory
    {
        private IComponentContext autofacContext;

        public CommandFactory(IComponentContext autofacContext)
        {
            this.autofacContext = autofacContext;
        }

        public ICommand GetCommand(string commandName)
        {
            return this.autofacContext.ResolveNamed<ICommand>(commandName);
        } 
    }
}
