using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C_Sharp_Practices
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
            Application.Run(new Form1());
            Application.Run(new Calculator());
            Application.Run(new BasicRecord());
        }
    }
}
