using System;
using System.Collections.Generic;
using TeamWork.Models.Interfaces;

namespace TeamWork.Core
{
    class Engine : IEngine
    {
        private static IEngine instanceHolder;
        private string exitCommand = "exit";

        IList<IPC> computers { get; }

        IList<IProduct> products { get; }

        IList<IPhone> phones { get; }

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
            while (true)
            {
                try
                {
                    var commandAsString = Console.ReadLine().Split(" ");

                    if (commandAsString[0] == exitCommand)
                    {
                        break;
                    }

                    this.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                   
                }
            }
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}
