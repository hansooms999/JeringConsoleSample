using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jering.Javascript.NodeJS;

namespace JeringConsoleSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //note that method is async in order to await result
        private async void button1_Click(object sender, EventArgs e)
        { 
            string result = await StaticNodeJSService.InvokeFromFileAsync<String>("example.js", "stall", args: new[] { "sample string" });
            StaticNodeJSService.DisposeServiceProvider();
            Debug.Print(result);
        }
    }
}
