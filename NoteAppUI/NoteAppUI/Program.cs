using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            Note note2 = new Note("Заметка", " tttttttttt", "Sport", time,time1 );

            note2.GetInfo();

            /// <summary>
            /// Проверка имени на вывод более 50 символов.
            /// </summary>
            note2.Name = "tghadsgfddffdgsdgsfsgfsdggsgsfdgfsdsgfgsfsgfdsgfdsgfdsgfgfsdgsfsgfsgfdsgfdsgfsdfgfdgsfdgsfsgfsgfsgfgsfsggsdggsfd";
            Console.WriteLine(note2.Name);

            /// <summary>
            /// Проверка текста на вывод более 1500 символов.
            /// </summary>
            note2.Text = "tghadsgfddffdgsdgsfsgfsdggsgsfdgfsdsgfфыавфыавфаgsfsgfdsgfdsgfdsgfgfsdgsfsgfsgfdsgfdsgfsdfgfdgsfdgsfsgfsgfsgfgsfsggsdggsfd";
            Console.WriteLine(note2.Text);

            note2.CategoryNotes = "tghadsgfddffdgsdgsfsgfsdggsgsfdgfsdsgfфыавфыавфаgsfsgfdsgfdsgfdsgfgfsdgsfsgfsgfdsgfdsgfsdfgfdgsfdgsfsgfsgfsgfgsfsggsdggsfd";
            Console.WriteLine(note2.CategoryNotes);

        }
    }
}
