using labashifr.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labashifr
{
    internal static class Program
    {
        static readonly public string dbPath = @"DataBase.txt";
        static readonly public string dbPathMD4 = @"KeyDB.txt";
        static public ControllerMD4 ControllerMD4 = new ControllerMD4();
        static public Controller Controller;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());  
            
        }
    }
}
