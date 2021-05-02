using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;
namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;
        [SetUp]
        public void InitNote()
        {
            // Данные для теста
            _note = new Note(NoteCategory.Job, "Имя заметки один два три", "Текст заметки три два один");
            _note.Name = "Имя заметки один два три";
            _note.Category = NoteCategory.Job;
            _note.Text = "Текст заметки три два один";
            //_note.timeCreated = DateTime.Now;
            //_note._timeModified = DateTime.Now;
        }
        [Test]
        public void Name_GoodName_ReturnsSameName()
        {
            var note = new Note(NoteCategory.Job, "Имя заметки один два три", "Текст заметки три два один");
            note.Name = sourceName;
            _note.Name = sourceName;
        }

        }
}
