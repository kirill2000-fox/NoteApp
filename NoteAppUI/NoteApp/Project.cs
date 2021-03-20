
using System.Collections.Generic;


namespace NoteApp
{
    /// <summary>
    /// Список записей.
    /// </summary>
    public class Project
    {
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
