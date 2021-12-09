using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCommandMemento
{
    class MachineOffState : IMachineState
    {
        public void PowerSwith()
        {
            Console.WriteLine("Turning Machine On");
        }
    }
}
