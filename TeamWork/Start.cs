using ElectronicsShop.Core;
using ElectronicsShop.Core.Commands;
using ElectronicsShop.Core.Contracts;
using ElectronicsShop.Core.Factories;
using ElectronicsShop.Core.Loggers;
using ElectronicsShop.Models;
using ElectronicsShop.Models.Contracts;
<<<<<<< HEAD
using ElectronicsShop.Models.ComputerContracts;
=======
using Autofac;
using System.Reflection;
using System.Linq;
>>>>>>> 1a82d2e5934828427ceaac31a709ade90f5e5363

namespace ElectronicsShop
{
    class Start
    {
        public static void Main()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            containerBuilder.RegisterType<Database>().As<IDatabase>().SingleInstance();
            RegisterDynamicCommands(containerBuilder);

            var dependencyContainer = containerBuilder.Build();

            var engine = dependencyContainer.Resolve<IEngine>();
            engine.Start();
        }

        private static void RegisterDynamicCommands(ContainerBuilder builder)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            var commandTypes = currentAssembly.DefinedTypes
                .Where(typeInfo =>
                    typeInfo.ImplementedInterfaces.Contains(typeof(ICommand)))
                .ToList();

            // register in autofac
            foreach (var commandType in commandTypes)
            {

                builder.RegisterType(commandType.AsType())
                  .Named<ICommand>(
                    commandType.Name.ToLower().Replace("command", ""));
            }
        }
    }
}
