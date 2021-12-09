using StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCommandMemento.Memento
{
    class MachineMemento
    {
        public Machine Machine { get; set; }
        public List<MachineCommand> CommandList { get; set; }

        public MachineMemento(Machine machine, List<MachineCommand> commandList)
        {
            Machine = machine;
            CommandList = commandList;
        }

        public void ResetMachine()
        {
            Console.WriteLine("Reseting the maching and turning it off");
            Machine.CommandList.Clear();
            Machine.MachineState = new MachineOffState();
        }
    }
}
