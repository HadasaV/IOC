using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ClassLibrary
{
    public interface ILibraryDemo
    {
        string DemoFunc();
    }

    public class LibraryDemo : ILibraryDemo
    {
        public string DemoFunc()
        {
            return "Hi From Library Class";
        }
    }
}
