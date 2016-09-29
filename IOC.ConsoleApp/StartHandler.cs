using IOC.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp
{
    public interface IStartHandler
    {
        void Start();
    }

    public class StartHandler : IStartHandler
    {
         private readonly ILibraryDemo _libraryDemo;

         public StartHandler(ILibraryDemo libraryDemo)
        {
            _libraryDemo = libraryDemo;
        }

        public void Start()
        {
            var result = _libraryDemo.DemoFunc();
            Console.WriteLine(result);
        }
    }
}
