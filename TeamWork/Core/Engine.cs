using System;
using System.Collections.Generic;
using TeamWork.Models.Contracts;
using TeamWork.Models.Interfaces;

namespace TeamWork.Core
{
    class Engine : IEngine
    {
        private static IEngine instanceHolder;
        private string exitCommand = "exit";

        IList<IComputer> computers { get; }

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
                string[] commandAsString = Console.ReadLine().Split(" ");

<<<<<<< HEAD
                if (commandAsString[0] == exitCommand)
=======
                    //this.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
>>>>>>> c3ad384403484f64fe5a36bead71fe329e457cf4
                {
                    break;
                }]

                this.ProcessCommand(commandAsString);
            }
        }

        private void ProcessCommand(string[] commandAsString)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}

