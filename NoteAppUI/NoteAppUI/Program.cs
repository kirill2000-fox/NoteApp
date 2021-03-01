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

            Note note2 = new Note("Прогаа", " tttttttttt", "Sport", time,time1 );

            note2.GetInfo();

            note2.Name = "tghadsgfddffdgsdgsfsgfsdggsgsfdgfsdsgfgsfsgfdsgfdsgfdsgfgfsdgsfsgfsgfdsgfdsgfsdfgfdgsfdgsfsgfsgfsgfgsfsggsdggsfd";
            Console.WriteLine(note2.Name);
            note2.Name = "tghadsgfddffdgsdgsfsgfsdggsgsfdgfsdsgfфыавфыавфаgsfsgfdsgfdsgfdsgfgfsdgsfsgfsgfdsgfdsgfsdfgfdgsfdgsfsgfsgfsgfgsfsggsdggsfd";
            Console.WriteLine(note2.Name);
            note2.Name = "tghadsgfddffdgsdgsfsgfsdggsgsfdgfsdsgfфыавфыавфаgsfsgfdsgfdsgfdsgfgfsdgsfsgfsgfdsgfdsgfsdfgfdgsfdgsfsgfsgfsgfgsfsggsdggsfd";
            Console.WriteLine(note2.Name);

        }
    }
}
