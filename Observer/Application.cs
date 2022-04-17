using Observer.ObserverFiles;
using Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Application : IApplication
    {

        public IEmail Email { get; set; }
        public IEmailWatcher EmailWatcher { get; set; }

        public Application(IEmail email, IEmailWatcher emailWatcher)
        {
            Email = email;
            EmailWatcher = emailWatcher;
        }

        public void Run()
        {
            Email mail = new();
            EmailWatcher watcher = new();
            mail.RegisterOberserver(watcher);
            mail.CreateTimer();
            Console.WriteLine("Observer");

        }
    }
}
