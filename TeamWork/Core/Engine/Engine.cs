using System;
using System.Linq;
using System.Collections.Generic;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Commands.Contracts;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Models.ComputerContracts;
using ElectronicsShop.Models.Contracts;
using ElectronicsShop.Models.Contracts.ComputerContracts;
using ElectronicsShop.Models.Contracts.PhoneContracts;

namespace ElectronicsShop.Core
{
    internal class Engine : IEngine
    {
        private static IEngine instanceHolder;
        private ILogger logger;
        private string exitCommand = "exit";

        private IList<ILaptop> Laptops { get; }

        private IList<IProduct> Products { get; }

        private IList<ISmartphone> Smartphones { get; }

        private IList<ILandlinePhone> Landlinephones { get; }

        private ICommandFactory commandFactory;

        private IProductFactory factory;

        private IDatabase database;

        private Engine(IProductFactory factory, ICommandFactory commandFactory, ILogger logger, IDatabase database)
        {
            this.factory = factory;
            this.logger = logger;
            this.commandFactory = commandFactory;
            this.database = database;
            this.Laptops = this.database.Products().Where(x=>x.GetType().Name.ToLower() == "laptop").Select(x=> x as ILaptop).ToList();
            this.Smartphones = this.database.Products().Where(x => x.GetType().Name.ToLower() == "smartphone").Select(x => x as ISmartphone).ToList();
            this.Landlinephones = this.database.Products().Where(x => x.GetType().Name.ToLower() == "landlinephone").Select(x => x as ILandlinePhone).ToList();
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

                    this.commandFactory.Process(commands);
                }
                catch (Exception ex)
                {
                    this.logger.Log(ex.Message);
                }
            }
        }
    }
}
