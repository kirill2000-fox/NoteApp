using System;
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
            // Исходные Данные для теста
            _note = new Note(NoteCategory.Job, "Имя заметки проверка", "Текст заметки проверка");
            _note.Name = "Имя заметки проверка";
            _note.Category = NoteCategory.Job;
            _note.Text = "Текст заметки проверка";
            

        }

        /// <summary>
        /// Проверка ввода правильного названия заметки
        /// </summary>
        [Test(Description = "Позитивный тест Геттера Name")]
        public void Name_GoodName_ReturnsSameName()
        {
            var expected = _note.Name;
            
            _note.Name = expected;

            var actual = _note.Name;

            //Сравниваем объекты равенства
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильное название заметки");
        }

        /// <summary>
        /// Проверка на ввод пустой строки в название заметки
        /// </summary>
        [Test(Description = "Тест Геттера Name с пустым значением")]
        public void TestNameGet_EmptyValue()
        {
            var expected = "Без названия";

            _note.Name = "";

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
            var source = "Слишком длинное название поля," +
                         "превышающее 50 символов и выбрасывающее" +
                         "исключение";

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
            var expected = _note.Text;

            _note.Text = expected;

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
            var expected = _note.TimeCreated;

            _note.Text = _note.Text;

            var actual = _note.TimeCreated;

            Assert.AreEqual(expected, actual,
                "Геттер TimeCreated возвращает неправильное значение");
        }

        /// <summary>
        /// Проверка изменения даты изменения заметки
        /// </summary>
        [Test(Description = "Тест геттера TimeModified")]
        public void TestIsChanged_ChangeValue()
        {
            var firstValue = _note.TimeModified;

            _note.Text = _note.Text;

            var secondValue = _note.TimeModified;

            Assert.AreNotEqual(firstValue, secondValue,
                "Геттер TimeModified возвращает неправильное значение");
        }

    }
}
