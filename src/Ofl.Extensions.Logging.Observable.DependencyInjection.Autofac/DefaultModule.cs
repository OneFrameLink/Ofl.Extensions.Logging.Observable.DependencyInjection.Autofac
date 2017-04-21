using System;
using Autofac;

namespace Ofl.Extensions.Logging.Observable.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Register.
            builder.RegisterType<LogObservableFactory>().As<ILogObservableFactory>();
        }
    }
}
