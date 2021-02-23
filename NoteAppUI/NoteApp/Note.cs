using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, хранящий название, текст, категории заметок, а также время создания и время изменений
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Возвращает и задает имя заметки.
        /// </summary>
        public string[] Name { get; set; }
        /// <summary>
        /// Возвращает и задает текст пользователя.
        /// </summary>
        public string[] Text { get; set; }
        /// <summary>
        /// Возвращает и задает категории пользователя.
        /// </summary>
        public string[] CategoryNotes { get; set; }
        /// <summary>
        /// Задает время создания заметки
        /// </summary>
        public double TimeCreation { get; set; }
        /// <summary>
        /// Возвращает и задает время изменения
        /// </summary>
        public double TimeChange { get; set; }

    }
}
