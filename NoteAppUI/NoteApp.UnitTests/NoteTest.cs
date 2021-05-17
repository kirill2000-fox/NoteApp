using System;
using NUnit.Framework;
using NoteApp;
namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;
       
        /// <summary>
        /// Проверка ввода правильного названия заметки
        /// </summary>
        [Test(Description = "Позитивный тест Геттера Name")]
        public void Name_GoodName_ReturnsSameName()
        {
            // Исходные Данные для теста
            _note = new Note(NoteCategory.Job, "Имя заметки проверка", "Текст заметки проверка");

            // Setup
            var expected = _note.Name;
            
            // Act
            _note.Name = expected;

            // Assert
            var actual = _note.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное название заметки");
        }

        /// <summary>
        /// Проверка на ввод пустой строки в название заметки
        /// </summary>
        [Test(Description = "Тест Геттера Name с пустым значением")]
        public void TestNameGet_EmptyValue()
        {
            // Исходные Данные для теста
            _note = new Note(NoteCategory.Job, "Имя заметки проверка", "Текст заметки проверка");

            // Setup
            var expected = "";

            // Act
            _note.Name = expected;

            // Assert
            var actual = _note.Name;

            Assert.AreEqual(expected, actual, "Геттер Name возвращает неверное название заметки при пустом значении");
        }

        /// <summary>
        /// Проверка ввода названия более 50 символов
        /// </summary>
        [Test(Description = "Тест геттера Name с длиной значения" +
                            "поля, превышающего 50 символов")]
        public void TestNameGet_TooLongValue()
        {
            // Исходные Данные для теста
            _note = new Note(NoteCategory.Job, "Имя заметки проверка", "Текст заметки проверка");

            // Setup
            var source = "Слишком длинное название поля," +
                         "превышающее 50 символов и выбрасывающее" +
                         "исключение";
            // Act
            Assert.Throws<ArgumentException>(
                
                code: () =>
                {
                    _note.Name = source;
                }, "Должно возникать исключение, если длина названия" +
                   "более 50 символов");
        }

        /// <summary>
        /// Проверка ввода любого текста
        /// </summary>
        [Test(Description = "Тест Геттера Text")]
        public void TestTextGet_Value()
        {
            // Исходные Данные для теста
            _note = new Note(NoteCategory.Job, "Имя заметки проверка", "Текст заметки проверка");

            // Setup
            var expected = _note.Text;

            // Act
            _note.Text = expected;

            // Assert
            var actual = _note.Text;

            Assert.AreEqual(expected, actual, 
                "Геттер Text возвращает неправильное значение");
        }


        /// <summary>
        /// Проврека на то, что не изменяется дата изменения заметки
        /// </summary>
        [Test(Description = "Тест Геттера TimeCreated")]
        public void TestIsCreated_ChangeValue()
        {
            // Setup
            var expected = DateTime.Now;

            // Act
            var note = new Note(NoteCategory.Home, "Новая заметка", "Текст заметки");

            // Assert
            var actual = note.TimeCreated;

            Assert.AreEqual(expected, actual,
                "Геттер TimeCreated возвращает неправильное время создания");
        }

        /// <summary>
        /// Проверка изменения даты изменения заметки
        /// </summary>
        [Test(Description = "Тест геттера TimeModified")]
        public void TestIsChanged_ChangeValue()
        {
            // Setup
            var expected =  DateTime.Now;

            // Act
            var note = new Note(NoteCategory.Home, "Новая заметка", "Текст заметки");

            // Assert
            var actual = note.TimeModified;

            Assert.AreEqual(expected, actual,
                "Геттер TimeModified возвращает неправильное время последнего изменения");
        }

    }
}
