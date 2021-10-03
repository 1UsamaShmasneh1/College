using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hackerme.DB;

namespace MainPro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StudentsTable.Log = new FileLogger().Log;
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
