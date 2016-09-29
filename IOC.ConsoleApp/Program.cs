using Castle.MicroKernel.Registration;
using Castle.Windsor;
using IOC.ConsoleApp.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindsorContainer container = ConsoleWindsorContainer.Instance;

            var startComponent = container.Resolve<IStartHandler>();

            startComponent.Start();

            Console.ReadLine();
        }
    }
}
