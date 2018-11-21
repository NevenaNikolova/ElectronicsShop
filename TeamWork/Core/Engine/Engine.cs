using System;
using System.Linq;
using System.Collections.Generic;
using ElectronicsShop.Core.Commands.Contracts;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.ComputerContracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;

namespace ElectronicsShop.Core
{
    public class Engine : IEngine
    {
        private ILogger logger;
        private string exitCommand = "exit";

        private ICommandFactory commandFactory;

        private IProductFactory factory;

        private IDatabase database;

        public Engine(IProductFactory factory, ICommandFactory commandFactory, ILogger logger, IDatabase database)
        {
            this.factory = factory;
            this.logger = logger;
            this.commandFactory = commandFactory;
            this.database = database;            
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    List<string> commands = new List<string>(Console.ReadLine().Split(" "));

                    if (commands[0] == exitCommand)
                    {
                        break;
                    }

                    this.ProcessCommand(commands);
                    
                }
                catch (Exception ex)
                {
                    this.logger.Log(ex.Message);
                }
            }
        }
        public void ProcessCommand(IList<string> commands)
        {
            var commandName = commands[0];
            commands.RemoveAt(0);
            var commandParams = commands;
            var command = this.commandFactory.GetCommand(commandName);

            var commandResult = command.Execute(commandParams);
            this.logger.Log(commandResult);
        }
    }
}
