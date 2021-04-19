using System;
using System.Data;
using Newtonsoft.Json;


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
        private string _text = "Ввод текста";

        /// <summary>
        /// Категории заметки.
        /// </summary>
        private NoteCategory _noteCategory;

        /// <summary>
        /// Время создания
        /// </summary>
        private DateTime _timeCreated;

        /// <summary>
        /// Время изменения
        /// </summary>
        private DateTime _timeModified;

        /// <summary>
        /// Возвращает и задает имя заметки.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Name
        {
            get => _name;

            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Название должно содержать не больше 50 символов ");
                }
                else
                {
                    if (value != String.Empty)
                    {
                        _name = value;
                        _timeModified = DateTime.Now;
                    }
                    
                }
            }
        }

        /// <summary>
        /// Возвращает и задает текст пользователя.
        /// </summary>
        public string Text
        {
            get => _text;

            set { _text = value; _timeModified = DateTime.Now; }

        }

        /// <summary>
        /// Возвращает и задает категории пользователя.
        /// </summary>
        public  NoteCategory Category
        {
            get => _noteCategory;

            set 
            { _noteCategory = value;
                _timeModified = DateTime.Now;
            }
        }

        /// <summary>
        /// Задает время создания заметки
        /// </summary>
        public DateTime TimeCreated 
        {
            get => _timeCreated;
            private set => _timeCreated = value;
        }

        /// <summary>
        /// Возвращает и задает время изменения
        /// </summary>
        public DateTime TimeModified
        {
            get => _timeModified;

            private set => _timeModified = value;
        }

        /// <summary>
        /// Конструктор для создания экземпляра Note
        /// </summary>
        /// <param name="name"></param>
        /// <param name="noteCategory"></param>
        /// <param name="text"></param>
        public Note(NoteCategory noteCategory, string name = "Без Названия", string text = "") :
            this(name, noteCategory, text, DateTime.Now, DateTime.Now)
        {

        }

        /// <summary>
        /// Конструктор, который вызывается при сериализации/десериализации
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        /// <param name="timeCreated"></param>
        /// <param name="timeModified"></param>
        [JsonConstructor]
    private Note(string name , NoteCategory category, string text, DateTime timeCreated, DateTime timeModified)
    {
        Name = name;
        Category = category;
        Text = text;
        TimeCreated = timeCreated;
        TimeModified = timeModified;
    }
    }
}
