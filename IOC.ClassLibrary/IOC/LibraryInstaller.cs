using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ClassLibrary.IOC
{
   public class LibraryInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                container.Register(
                    Classes.FromThisAssembly().Pick()
                    .WithService.DefaultInterfaces()
                    .Configure(s => s.LifestyleSingleton()));

                container.Kernel.Resolver.AddSubResolver(new ArrayResolver(container.Kernel, true));
            }
        }
}
