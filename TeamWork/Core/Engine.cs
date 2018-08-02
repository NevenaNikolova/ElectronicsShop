using System;
using System.Collections.Generic;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Tools;
using ElectronicsShop.Models.Interfaces;

namespace ElectronicsShop.Core
{
    public class Engine : IEngine
    {
        private static IEngine instanceHolder;
        private string exitCommand = "exit";

        IList<IComputer> computers { get; }

        IList<IProduct> products { get; }

        IList<IPhone> phones { get; }

        CommandHandler commandHandler;
        private IProductFactory factory;

        public static IEngine Instance
        {
            get
            {
                if (instanceHolder == null)
                {
                    instanceHolder = new Engine();
                }

                return instanceHolder;
            }
        }

        private Engine()
        {
            this.computers = new List<IComputer>();
            this.phones = new List<IPhone>();
            this.products = new List<IProduct>();
            this.factory = new ProductFactory();
            this.commandHandler = new CommandHandler();
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
                    //this.ProcessCommand(commandAsString);
                    //ProductFactory factory = new ProductFactory();
                   
                    string firstCommand = commands[0];
                    commands.RemoveAt(0);

                    switch (firstCommand)
                    {
                        case "create":
                            commandHandler.CreateCommand(commands);
                            break;
                        case "add":
                            
                            break;
                        case "remove":
                            break;
                        case "logout":
                            break;

                        default:
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
