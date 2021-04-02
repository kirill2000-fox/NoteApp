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

            DateTime time = DateTime.Now;
            DateTime time1 = DateTime.Now;

            Note note2 = new Note("BIG", "My son is sleeping", "People", time,time1 );
            
            note2.GetInfo();

            // Проверка имени на вывод более 50 символов.
            note2.Name = "tghadsgfddffdgssgfdsgfadgdgfsfdsfgf";
            Console.WriteLine(note2.Name);

            // Проверка текста на вывод более 1500 символов.
            note2.Text = "Здесь должен быть большой текст, больше 50 символов, поэтому я пишу это для проверки";
            Console.WriteLine(note2.Text);
            note2.Category = 0;
            Console.WriteLine(note2.Category);
        }
    }
}
