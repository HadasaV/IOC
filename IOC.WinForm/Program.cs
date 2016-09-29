using Castle.MicroKernel.Registration;
using Castle.Windsor;
using IOC.WinForm.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOC.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IWindsorContainer container = WinFormWindsorContainer.Instance;

            var mainForm = container.Resolve<MainForm>();
            Application.Run(mainForm);
        }
    }
}
