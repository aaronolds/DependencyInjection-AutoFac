using System;
using Autofac;

namespace DependencyInjection_AutoFac
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().Keyed<IDateWriter>("Today");
            builder.RegisterType<TomorrowWriter>().Keyed<IDateWriter>("Tomorrow");;
            Container = builder.Build();

            // The WriteDate method is where we'll make use
            // of our dependency injection. We'll define that
            // in a bit.
            WriteDate();
        }

        private static void WriteDate()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                // var writer = scope.Resolve<IDateWriter>();
                var writer = scope.ResolveKeyed<IDateWriter>("Today");
                writer.WriteDate();

                var writer2 = scope.ResolveKeyed<IDateWriter>("Tomorrow");
                writer2.WriteDate();
            }
        }
    }
}
