using System;


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

                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает текст пользователя.
        /// </summary>
        public string Text
        {
            get => _text;

            set => _text = value;
        }

        /// <summary>
        /// Возвращает и задает категории пользователя.
        /// </summary>
        public  NoteCategory Category
        {
            get => _noteCategory;

            set =>_noteCategory = value;
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
        /// Конструктор 
        /// </summary>
        public Note(string name, string text, string noteCategory, DateTime timeCreated, DateTime timeModified)
        {
             Name = name;
             Text = text;
             Category = _noteCategory;
             TimeCreated = timeCreated;
             TimeModified = timeModified;
        }

        public Note()
        {
        }

        public void GetInfo()// TODO: НУЖНО ИСПРАВИТЬ
        {
            Console.WriteLine(
                $"Название:{_name} Текст:{_text} Категория заметки:{_noteCategory} Время создания: {_timeCreated}  Время последнего изменения: {_timeModified}");
        }
    }
}
