using IOC.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOC.WinForm
{

    public partial class MainForm : Form
    {
       private readonly ILibraryDemo _libraryDemo;

         public MainForm(ILibraryDemo libraryDemo)
        {
            InitializeComponent();
            _libraryDemo = libraryDemo;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = _libraryDemo.DemoFunc();
        }
    }
}
