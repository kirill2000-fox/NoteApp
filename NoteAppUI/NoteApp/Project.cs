
using System.Collections.Generic;


namespace NoteApp
{
    /// <summary>
    /// Список записей.
    /// </summary>
    public class Project
    {
        /// <summary>
        ///Класс Project, хранящий коллекцию заметок Note
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
