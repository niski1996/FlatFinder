using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlatFinder.Business.Entities;
using FlatFinder.Data;

namespace FlatFinderUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new EntryWindow());
            var tmp = new Flat();
            var tmpRes = new FlatRepository();
            tmpRes.Add(tmp);
            Console.WriteLine("helo");
            Console.Read();



        }
    }
}
