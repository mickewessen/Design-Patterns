using StateCommandMemento.Command;
using StateCommandMemento.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCommandMemento
{
    class Machine : IMachineState, IMachine
    {
        public IMachineState MachineState { get; set; }
        public List<MachineCommand> CommandList { get; set; }
        public Machine()
        {
            MachineState = new MachineOffState();
            CommandList = new List<MachineCommand>();
        }
        public void PowerSwith()
        {
            MachineState.PowerSwith();
            if (MachineState is MachineOffState)
            {
                MachineState = new MachineOnState();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }

        public void Print(string commands)
        {
            Console.WriteLine("Displaying commands...");
            Console.WriteLine($"{commands}");
        }
        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, CommandList);
        }
    }
}
