using System;
using System.Windows.Forms;

namespace Home_Appliance_Store
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Какую форму запустить?!!
            Application.Run( new F_A_Yprav() );
        }
    }
}
