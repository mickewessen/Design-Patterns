using Autofac;
using Observer.ObserverFiles;
using Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<EmailWatcher>().As<IEmailWatcher>();
            builder.RegisterType<Email>().As<IEmail>();


            return builder.Build();
        }
    }
}
