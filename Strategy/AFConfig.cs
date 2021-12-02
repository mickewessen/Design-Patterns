using Autofac;
using Strategy.Message;
using Strategy.Messagehandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Email>().As<IEmail>();
            builder.RegisterType<SMS>().As<ISMS>();
            builder.RegisterType<Facebook>().As<IFacebook>();
            builder.RegisterType<SendMessage>().As<ISendMessage>();


            return builder.Build();
        }
    }
}
