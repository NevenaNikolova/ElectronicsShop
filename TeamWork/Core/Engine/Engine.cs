using System;
using System.Collections.Generic;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Core
{
    internal class Engine : IEngine
    {
        private static IEngine instanceHolder;
        private ILogger logger;
        private string exitCommand = "exit";

        private IList<IDesktopPc> Computers { get; }

        private IList<IProduct> Products { get; }

        private IList<IPhone> Phones { get; }

        private CommandHandler commandHandler;

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
            this.Computers = new List<IDesktopPc>();
            this.Phones = new List<IPhone>();
            this.Products = new List<IProduct>();
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
