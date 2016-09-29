﻿using Castle.MicroKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace IOCWeb.IOC
{
    public class WindsorDependencyResolver : System.Web.Http.Dependencies.IDependencyResolver, System.Web.Mvc.IDependencyResolver
    {
        private readonly IKernel _kernel;

        public WindsorDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new WindsorDependencyScope(_kernel);
        }

        public object GetService(Type serviceType)
        {
            return _kernel.HasComponent(serviceType) ? _kernel.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.HasComponent(serviceType) ? _kernel.ResolveAll(serviceType) as IEnumerable<object> : Enumerable.Empty<object>();
        }

        public void Dispose()
        {
            // Nothing created so nothing to dispose - kernel will take care of its own
        }
    }
}