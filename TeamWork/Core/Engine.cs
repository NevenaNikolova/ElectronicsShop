using System;
using System.Collections.Generic;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Core
{
    internal class Engine : IEngine
    {
        private static IEngine instanceHolder;
        private ILogger logger;
        private string exitCommand = "exit";

        IList<IComputer> computers { get; }

        IList<IProduct> products { get; }

        IList<IPhone> phones { get; }

        CommandHandler commandHandler;

        private IProductFactory factory;

        public static IEngine Instance(IProductFactory factory, CommandHandler commandHandler,ILogger logger)
        {

            if (instanceHolder == null)
            {

                instanceHolder = new Engine(factory, commandHandler,logger);
            }

            return instanceHolder;

        }

        private Engine(IProductFactory factory, CommandHandler commandHandler,ILogger logger)
        {
            this.computers = new List<IComputer>();
            this.phones = new List<IPhone>();
            this.products = new List<IProduct>();
            this.factory = factory;
            this.logger = logger;
            this.commandHandler = commandHandler;
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

                    this.commandHandler.Proccess(commands);
                }
                catch (Exception ex)
                {
                    this.logger.Log(ex.Message);
                }
            }
        }
    }
}
