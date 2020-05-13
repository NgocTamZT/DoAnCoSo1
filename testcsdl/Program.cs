using System;
using System.Windows.Forms;

namespace testcsdl
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
            Application.Run(new Admin());
            //try
            //{
            //    Application.Run(new Welcome());
            //    Application.Run(new Login());
            //}
            //catch
            //{
            //    Application.Exit();
            //}
        }
    }
}
