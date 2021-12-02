using Autofac;
using Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AFConfig
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<TextInput>().As<ITextInput>();

            return builder.Build();
        }

    }
}
