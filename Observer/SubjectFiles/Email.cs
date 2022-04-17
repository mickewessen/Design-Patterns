using Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Observer.SubjectFiles
{
    public class Email : IEmail
    {
        public List<IObservers> Observers { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in Observers)
            {
                observer.Message(message);
            }
        }

        public void RegisterOberserver(IObservers observer)
        {
            Observers.Add(observer);
        }

        public void UnregisterObserver(IObservers observer)
        {
            Observers.Remove(observer);
        }

        public void CreateTimer()
        {
            var timer = new System.Timers.Timer(3000);
            timer.Elapsed += HandleTimerElapsed;
            timer.AutoReset = true;
            timer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

        public void HandleTimerElapsed(object sender, ElapsedEventArgs e)
        {
            string message = "You have a new email";
            NotifyObservers(message);
        }


    }
}
