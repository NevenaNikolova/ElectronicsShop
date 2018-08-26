
namespace ElectronicsShop.Core.Commands.Contracts
{
    public interface ICommandFactory
    {
        ICommand GetCommand(string commandName);
        
    }
}
