using System;
using System.Windows.Forms;

namespace Sandruve
{
    static class Program
    {
        public static string version = "0.5";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sandruve());
        }
    }
}
