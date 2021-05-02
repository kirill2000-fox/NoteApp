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
            

        }

        /// <summary>
        /// Проверка на ввод правильного названия заметки
        /// </summary>
        [Test(Description = "Позитивный тест геттера Name")]
        public void Name_GoodName_ReturnsSameName()
        {
            //Ожидаемое название заметки
            var expected = _note.Name;

            //Присваиваем полю "Название заметки" текст
            _note.Name = expected;

            //Присваиваем полю, хранящему название
            //заметки в реальном времени новое значение
            var actual = _note.Name;

            //Сравниваем ожидаемое значение с тем, что получили
            Assert.AreEqual(expected, actual,
                "Геттер Title возвращает неправильное название заметки");
        }

        /// <summary>
        /// Проверка на ввод пустой строки в название заметки
        /// </summary>
        [Test(Description = "Тест геттера Name с пустым значением")]
        public void TestNameGet_EmptyValue()
        {
            //Ожидаемое название заметки
            var expected = "Без названия";

            //Присваиваем пустое значение name
            _note.Name = "";

            //Присваиваем значение из поля "Название заметки"
            var actual = _note.Name;

            //Сравниваем ожидаемое значение с полученным
            Assert.AreEqual(expected, actual,
                "Геттер Name возвращает неверное название заметки при пустом значении");
        }

        /// <summary>
        /// Проверка на ввод названия заметки более 50 символов
        /// </summary>
        [Test(Description = "Тест геттера Name с длиной значения" +
                            "поля, превышающего 50 символов")]
        public void TestNameGet_TooLongValue()
        {
            var source = "Слишком длинное название поля," +
                         "превышающее 50 символов и выбрасывающее" +
                         "исключение";

            Assert.Throws<ArgumentException>(
                //Анонимный метод
                () =>
                {
                    //Тестируемый код
                    _note.Name = source;
                }, "Должно возникать исключение, если длина названия" +
                   "более 50 символов");
        }
    }
}
