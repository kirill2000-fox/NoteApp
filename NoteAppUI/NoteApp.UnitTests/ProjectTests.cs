using System.Collections.Generic;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        private Project _project;

        [Test(Description = "Позитивный тест геттера Notes")]
        public void Notes_CorrectValue_ReturnsSameValue()
        {
            // Setup
            _project = new Project();

            var expected = new List<Note>
            {
                new Note(NoteCategory.Documents),
                new Note(NoteCategory.Home),
                new Note(NoteCategory.HealthAndSport)
            };

            _project.Notes = expected;

            // Act
            var actual = _project.Notes;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Notes возвращает неправильный список заметок");
        }

        [Test(Description = "Позитивный тест сеттера Notes")]
        public void Notes_CorrectValue_SetsSameValue()
        {
            // Setup
            _project = new Project();

            var expected = new List<Note>
            {
                new Note(NoteCategory.Documents),
                new Note(NoteCategory.Home),
                new Note(NoteCategory.HealthAndSport)
            };

            // Act
            _project.Notes = expected;
            var actual = _project.Notes;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Notes присваивает неправильный список заметок");
        }
    }
}
