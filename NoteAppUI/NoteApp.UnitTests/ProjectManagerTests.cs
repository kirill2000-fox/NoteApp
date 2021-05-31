using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NoteApp;
using NUnit.Framework;


namespace NoteApp.UnitTests
{
};
[TestFixture]
public class ProjectManagerTest
{
    private string _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes";

    /// <summary>
    /// Пример проекта
    /// </summary>
    /// <returns></returns>
    private Project GetExampleProject()
    {
        var project = new Project();
        project.Notes = new List<Note>()
            {
                new Note("Заметка 1", NoteCategory.Job, "Текст 1", new DateTime(), new DateTime()),
                new Note("Заметка 2", NoteCategory.Job, "Текст 2", new DateTime(), new DateTime()),
                new Note("Заметка 3", NoteCategory.Job, "Текст 3", new DateTime(), new DateTime()),
                new Note("Заметка 4", NoteCategory.Job, "Текст 4", new DateTime(), new DateTime()),
            };

        project.SelectedNote = project.Notes[0];
        return project;
    }

    [Test(Description = "Позитивный тест геттера DefaultPath")]
    public void TestDefaultPathGet_CorrectValue()
    {
        // Setup
        var expected
            = _defaultPath;
        ProjectManager.DefaultPath = expected;

        // Act
        var actual = ProjectManager.DefaultPath;

        // Assert
        Assert.AreEqual(expected, actual, "Геттер DefaultPath возвращает неправильный путь");
    }

    [Test(Description = "Позитивный тест сеттера DefaultPath")]
    public void TestDefaultPathSet_CorrectValue()
    {
        // Setup
        var expected = _defaultPath;
        ProjectManager.DefaultPath = expected;

        // Act
        var actual = ProjectManager.DefaultPath;

        // Assert
        Assert.AreEqual(expected, actual, "Сеттер DefaultPath присваивает неправильный путь");
    }

    [Test(Description = "Позитивный тест метода сохранения данных в файл")]

    public void TestSaveToFile_CorrectValue()
    {
        // Setup
        var project = GetExampleProject();
        var location = Assembly.GetExecutingAssembly().Location;
        var testDataLocation = Path.GetFullPath(location + "\\..\\TestData\\Test.txt");
        var referenceDataLocation =
            Path.GetFullPath(location + "\\..\\TestData\\Reference.txt");

        if (File.Exists(testDataLocation))
        {
            File.Delete(testDataLocation);
        }

        ProjectManager.SaveToFile(project, testDataLocation);
        Assert.IsTrue(File.Exists(testDataLocation),
            "Файл для сохранения данных не был создан");

        var expectedFileAsText = File.ReadAllText(testDataLocation);

        // Act
        var actualFileAsText = File.ReadAllText(referenceDataLocation);

        // Assert
        Assert.AreEqual(expectedFileAsText, actualFileAsText,
            "Метод SaveToFile сохраняет данные неверно");
    }

    // TODO: Исправить тест
    [Test(Description = "Позитивный тест метода загрузки данных из файла")]
    public void TestLoadFromFile_CorrectValue()
    {
        // Setup
        var expectedProject = GetExampleProject();
        var location = Assembly.GetExecutingAssembly().Location;
        var referenceDataLocation =
            Path.GetFullPath(location + "\\..\\TestData\\Reference.txt");

        // Act
        var actualProject = ProjectManager.LoadFromFile(referenceDataLocation);

        // Assert
        CollectionAssert.AreEqual(expectedProject.Notes, actualProject.Notes,
            "Метод LoadFromFile загружает данные неверно");
    }

    [Test(Description = "Тест метода загрузки данных из файла при отсутствии файла")]
    public void TestLoadFromFile_NoFile()
    {
        // Setup
        var expectedProject = new Project();
        var location = Assembly.GetExecutingAssembly().Location;
        var testDataLocation = Path.GetFullPath(location + "\\..\\TestData\\Test.txt");

        if (File.Exists(testDataLocation))
        {
            File.Delete(testDataLocation);
        }


        // Act
        var actualProject = ProjectManager.LoadFromFile(testDataLocation);

        // Assert
        CollectionAssert.AreEqual(expectedProject.Notes, actualProject.Notes,
            "Метод LoadFromFile не создает новый объект Project при отсутствии файла");
    }

    [Test(Description = "Тест метода загрузки данных из поврежденного файла")]
    public void TestLoadFromFile_CorruptedFile()
    {
        // Setup
        var expectedProject = new Project();
        var location = Assembly.GetExecutingAssembly().Location;
        var corruptedDataLocation =
            Path.GetFullPath(location + "\\..\\TestData\\Corrupted.txt");

        // Act
        var actualProject = ProjectManager.LoadFromFile(corruptedDataLocation);

        // Assert
        CollectionAssert.AreEqual(expectedProject.Notes, actualProject.Notes,
            "Метод LoadFromFile не создает новый объект Project " +
            "при поврежденном файле");
    }
}
