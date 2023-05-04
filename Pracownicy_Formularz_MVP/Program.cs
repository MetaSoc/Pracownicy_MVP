using System;
using System.Windows.Forms;
using Pracownicy_MVP.Views;

namespace Pracownicy_MVP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WorkerView());
        }
    }
}
