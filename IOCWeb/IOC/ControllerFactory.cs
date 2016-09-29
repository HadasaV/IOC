using Castle.MicroKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IOCWeb.IOC
{
    public class ControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public ControllerFactory(IKernel kernel)
        {
            _kernel = kernel;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(404, string.Format("The controller for path '{0}' could not be found.", requestContext.HttpContext.Request.Path));
            }

            return (IController)_kernel.Resolve(controllerType);
        }

        public override void ReleaseController(IController controller)
        {
            var disposableController = controller as IDisposable;
            if (disposableController != null)
            {
                disposableController.Dispose();
            }

            _kernel.ReleaseComponent(controller);

        }
    }
}