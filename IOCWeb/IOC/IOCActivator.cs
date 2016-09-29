using Castle.MicroKernel.Releasers;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using IOC.ClassLibrary;
using IOC.ClassLibrary.IOC;
using IOCWeb.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


[assembly: PreApplicationStartMethod(type: typeof(IOCActivator), methodName: "Start")]

namespace IOCWeb.IOC
{
    public class IOCActivator
    {
        public static void Start()
        {
            var container = new WindsorContainer()
                .Install(FromAssembly.This())
                .Install(FromAssembly.Containing<LibraryInstaller>());

            container.Kernel.ReleasePolicy = new NoTrackingReleasePolicy();

            var mvcControllerFactory = new ControllerFactory(container.Kernel);

            ControllerBuilder.Current.SetControllerFactory(mvcControllerFactory);
            container.Kernel.Resolver.AddSubResolver(new ArrayResolver(container.Kernel, true));

            var dependencyResolver = new WindsorDependencyResolver(container.Kernel);

            GlobalConfiguration.Configuration.DependencyResolver = dependencyResolver;

            DependencyResolver.SetResolver(dependencyResolver);
        }
    }
}