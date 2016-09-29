using IOC.ClassLibrary.IOC;
using Castle.MicroKernel.Releasers;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp.IOC
{
    public class ConsoleWindsorContainer
    {
        private static IWindsorContainer container;

        public static IWindsorContainer Instance
        {
            get
            {
                if (container == null)
                {
                    container = new WindsorContainer();

                    container.Install(FromAssembly.This())
                   .Install(FromAssembly.Containing<LibraryInstaller>());

                    container.Kernel.ReleasePolicy = new NoTrackingReleasePolicy();

                    container.Kernel.Resolver.AddSubResolver(new ArrayResolver(container.Kernel, true));
                }
                return container;
            }
            // exposing a setter alleviates some common component testing problems
            set { container = value; }
        }

        public static T Resolve<T>()
        {
            return Instance.Resolve<T>();
        }

        public static void Dispose()
        {
            if (container != null)
                container.Dispose();
            container = null;
        }
    }
}
