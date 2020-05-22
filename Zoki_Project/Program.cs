using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoki_Project
{
    static class Program
    {
        //Создание статистического экземплеяра класса модели ADO.EDM
        public static Zoki_ProjectEntities1 zokiDb = new Zoki_ProjectEntities1();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
