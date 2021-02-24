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
        /// Имя заметки.
        /// </summary>
        private string _name;
        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;
        /// <summary>
        /// Категории заметки.
        /// </summary>
        private string _categoryNotes;

        /// <summary>
        /// Возвращает и задает имя заметки.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Название должно содержать не больше 50 символов ");
                }
                else _name = value;

            }
        }
        /// <summary>
        /// Возвращает и задает текст пользователя.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                if (value.Length > 1500)
                {
                    throw new ArgumentException("Текст ,временно, не может содержать более 1500 символов");
                }
                else _name = value;

            }
        }
        /// <summary>
        /// Возвращает и задает категории пользователя.
        /// </summary>
        public string CategoryNotes
        {
            get { return _categoryNotes; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Категория не должна содержать больше 50 символов ");
                }
                else _name = value;

            }
        }
        

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
