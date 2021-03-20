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

            Note note2 = new Note("BIG", "My son is sleeping", "Sport", time,time1 );
            
            note2.GetInfo();

            /// <summary>
            /// Проверка имени на вывод более 50 символов.
            /// </summary>
            note2.Name = "tghadsgfddffdgsdgfd";
            Console.WriteLine(note2.Name);

            /// <summary>
            /// Проверка текста на вывод более 1500 символов.
            /// </summary>
            note2.Text = "Здесь должен быть большой текст, больше 50 символов, поэтому я пишу это для проверки";
            Console.WriteLine(note2.Text);

            note2.CategoryNotes = "Здесь должен быть большой текст, больше 50 символов, поэтому я пишу это для проверки";
            Console.WriteLine(note2.CategoryNotes);

            //Project project = new Project();
            //project.notes = new Note[2]
            //project.notes[0] = note2


            //project.notes[1] = note2


            //Serialisation(project)

        }
    }
}
