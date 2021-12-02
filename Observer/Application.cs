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
            Console.WriteLine("Observer");
            var email = "";
            while (string.IsNullOrEmpty(email))
            {
                email = Email.Message;
            }
            Console.WriteLine(email);
            Console.WriteLine();
        }
    }
}
