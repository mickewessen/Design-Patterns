using StateCommandMemento.Command;
using StateCommandMemento.Memento;
using System;

namespace StateCommandMemento
{
    class SCMMain
    {
        static void Main(string[] args)
        {
            var machine = new Machine();
            var commandManager = new CommandManager(machine);
            MachineMemento machineMemento = machine.CreateMemento();

            Console.WriteLine("State Command Memento");
            Console.WriteLine("----------------------");
            Console.WriteLine("T: Turning Machine On/Off");
            Console.WriteLine("I: Input command strings");
            Console.WriteLine("R: Reset and turn off");
            Console.WriteLine("X: Quit Program");

            while (true)
            {
                var userInput = Console.ReadKey().KeyChar;
                switch (userInput)
                {
                    case 't' or 'T':
                        machine.PowerSwith();
                        foreach (var command in machine.CommandList)
                        {
                            commandManager.Action(command.InputCommand);
                        }
                        machine.CommandList.Clear();
                        break;

                    case 'i' or 'I':
                        Console.WriteLine("Enter a command");
                        var inputCommand = Console.ReadLine();
                        commandManager.Action(inputCommand);
                        break;

                    case 'r' or 'R':
                        Console.WriteLine("Reseting commands and turning off");
                        machineMemento.ResetMachine();
                        break;

                    case 'x' or 'X':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Not a valid choice");
                        break;
                }
            }
        }
    }
}
