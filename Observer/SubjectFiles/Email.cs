using Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.SubjectFiles
{
    public class Email : IEmail
    {
        public List<IObservers> Observers { get; set; }
        public string Message { get; set; }

        public Email()
        {
            Observers = new();
            Message = "This is an email";
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Message(Message);
            }
        }
    }
}
