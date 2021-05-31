using System.Collections.Generic;
using System.Linq;


namespace NoteApp
{
    /// <summary>
    /// Список записей.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Выбранная заметка
        /// </summary>
        public Note SelectedNote { get; set; }

        /// <summary>
        ///Класс Project, хранящий коллекцию заметок Note
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Сортировка списка заметок по дате изменения (по убыванию)
        /// </summary>
        /// <returns></returns>
        public List<Note> TimeModifiedSort()
        {
            var orderedList =
                Notes.OrderByDescending(note => note.TimeModified);
            return orderedList.ToList();
        }

        /// <summary>
        /// Сортировка списка заметок по дате изменения (по убыванию)
        /// при определенной категории
        /// </summary>
        /// <param name="noteCategory"></param>
        /// <returns></returns>
        public List<Note> TimeModifiedSortWithCategory(NoteCategory noteCategory)
        {
            return Notes.OrderByDescending(note => note.TimeModified).Where(note => note.Category == noteCategory).ToList();
        }
    }
}
