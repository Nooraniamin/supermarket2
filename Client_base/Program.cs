using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_base
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
            bool createdNew;
            using (var mutex = new System.Threading.Mutex(true, "YourUniqueMutexName", out createdNew))
            {
                if (createdNew)
                {
                    Application.Run(new MDI());
                }
                else
                {
                    MessageBox.Show("Another instance is already running.");
                }

            }
        }
    }
}