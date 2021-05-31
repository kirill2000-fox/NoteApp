using System;
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
                new Note("Заметка1", NoteCategory.Documents, "Текст1"),
                new Note("Заметка2", NoteCategory.Home, "Текст2"),
                new Note("Заметка3", NoteCategory.HealthAndSport, "Текст3")
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
                new Note("Заметка1", NoteCategory.Documents, "Текст1"),
                new Note("Заметка2", NoteCategory.Home, "Текст2"),
                new Note("Заметка3", NoteCategory.HealthAndSport, "Текст3")
            };

            // Act
            _project.Notes = expected;
            var actual = _project.Notes;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Notes присваивает неправильный список заметок");
        }

        [Test(Description = "Позитивный тест геттера SelectedNote")]
        public void TestSelectedNoteGet_CorrectValue()
        {
            // Setup
            _project = new Project();

            var expected = new Note("Заметка", NoteCategory.Home, "Текст");

            // Act
            _project.SelectedNote = expected;
            var actual = _project.SelectedNote;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер SelectedNote возвращает неправильную выбранную заметку");
        }

        [Test(Description = "Позитивный тест сеттера SelectedNote")]
        public void TestSelectedNoteSet_CorrectValue()
        {
            // Setup
            _project = new Project();

            var expected = new Note("Заметка", NoteCategory.Home, "Текст");

            // Act
            _project.SelectedNote = expected;
            var actual = _project.SelectedNote;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер SelectedNote возвращает неправильную выбранную заметку");
        }

        /// <summary>
        /// Создание списка заметок из 4 элементов
        /// </summary>
        
        private List<Note> GetExampleListWithDate()
        {
            return new List<Note>()
            {
                new Note("Имя заметки проверка 1", NoteCategory.Home, "Текст заметки 1",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("4/4/2020 00:00:00")),
                new Note("Имя заметки проверка 2", NoteCategory.Job, "Текст заметки 2",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("2/2/2020 00:00:00")),
                new Note("Имя заметки проверка 3", NoteCategory.Documents, "Текст заметки 3",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("1/1/2020 00:00:00")),
                new Note("Имя заметки проверка 4", NoteCategory.Job, "Текст заметки 4",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("3/3/2020 00:00:00"))
            };
        }

        [Test(Description = "Позитивный тест сортировки списка по дате изменения")]
        public void TestTimeModifiedSort_CorrectValue()
        {
            // Setup
            var project = new Project();

            var expectedList = new List<Note>()
            {
                new Note("Имя заметки проверка 1", NoteCategory.Home, "Текст заметки 1",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("4/4/2020 00:00:00")),
                new Note("Имя заметки проверка 4", NoteCategory.Job, "Текст заметки 4",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("3/3/2020 00:00:00")),
                new Note("Имя заметки проверка 2", NoteCategory.Job, "Текст заметки 2",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("2/2/2020 00:00:00")),
                new Note("Имя заметки проверка 3", NoteCategory.Documents, "Текст заметки 3",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("1/1/2020 00:00:00"))
            };

            // Act
            var actualList = GetExampleListWithDate();
            project.Notes = actualList;
            actualList = project.TimeModifiedSort();

            // Assert
            Assert.AreEqual(expectedList, actualList, "Список должен сортироваться по дате изменения");
        }

        [Test(Description = "Позитивный тест сортировки списка по дате изменения" +
                            " при определенной категории")]
        public void TestTimeModifiedSortWithCategory_CorrectValue()
        {
            // Setup
            var project = new Project();
            var expectedList = new List<Note>()
            {
                new Note("Имя заметки проверка 4", NoteCategory.Job, "Текст заметки 4",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("3/3/2020 00:00:00")),
                new Note("Имя заметки проверка 2", NoteCategory.Job, "Текст заметки 2",
                    DateTime.Parse("1/1/2020 00:00:00"),
                    DateTime.Parse("2/2/2020 00:00:00"))
            };

            // Act
            var actualList = GetExampleListWithDate();
            project.Notes = actualList;
            actualList = project.TimeModifiedSortWithCategory(NoteCategory.Job);

            // Assert
            Assert.AreEqual(expectedList, actualList,
                "Список должен сортироваться по дате изменения, " +
                "должны учитываться значения, соответствующие указанной категории");
        }

        [Test(Description = "Позитивный тест сортировки списка по дате изменения " +
                            "при определенной категории, при отсутствии элементов " +
                            "нужной категории")]
        public void TestLastChangeTimeSortWithCategory_NoRightCategory()
        {
            // Setup
            var project = new Project();
            var expectedList = new List<Note>();

            // Act
            var actualList = GetExampleListWithDate();
            project.Notes = actualList;
            actualList = project.TimeModifiedSortWithCategory(NoteCategory.HealthAndSport);

            // Assert
            Assert.AreEqual(expectedList, actualList,
                "Метод LastChangeTimeSort должен вернуть пустой список " +
                "при отсутствии элементов нужной категории");
        }
    }
}
