using System;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
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
            Application.Run(new MainForm23());

            //DateTime time = DateTime.Now;
            //DateTime time1 = DateTime.Now;

            //Note note2 = new Note("BIG", "My son is sleeping", "People", time,time1 );
            

            //// Проверка имени на вывод более 50 символов.
            //note2.Name = "tghadsgfddffdgssgfdsgfadgdgfsfdsfgf";
            //Console.WriteLine(note2.Name);
        }
    }
}
