using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ObserverFiles
{
    public class EmailWatcher : IEmailWatcher
    {
        public void Message(string message)
        {
            Console.WriteLine($"message \"{message}\"");
        }
    }
}
