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
        private string _name = "Без Названия";

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Категории заметки.
        /// </summary>
        private string _categoryNotes;

        /// <summary>
        /// Время создания
        /// </summary>
        private DateTime _timeCreation;

        /// <summary>
        /// Время изменения
        /// </summary>
        private DateTime _timeChange;

       
       


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
                else _text = value;

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
                else _categoryNotes = value;

            }
        }
        /// <summary>
        /// Задает время создания заметки
        /// </summary>
        public DateTime TimeCreation 
        {
            get { return _timeCreation; }
            private set
            {
                _timeCreation = value;
            }
        }
        /// <summary>
        /// Возвращает и задает время изменения
        /// </summary>
        public DateTime TimeChange
        {
            get { return _timeChange; }
            private set

            {
                _timeChange = value;
            }
        }

        /// <summary>
        /// Конструктор 
        /// </summary>

        public Note(string name, string text, string categoryNotes, DateTime timeCreation, DateTime timeChange)
        {
             Name = name;
             Text = text;
             CategoryNotes = categoryNotes;
             TimeCreation = timeCreation;
             TimeChange = timeChange;
        }
        public void GetInfo()
        {
            Console.WriteLine(
                $"Название:{_name} Текст:{_text} Категория заметки:{_categoryNotes} Время создания: {_timeCreation}  Время последнего изменения: {_timeChange}");
        }


    }
}
