

using System;
using System.IO;

using Newtonsoft.Json;

namespace NoteApp
{ 
    /// <summary>
    /// Сохранение файла
    /// </summary>
    public class ProjectManager
    {
        private const string FileName = "NoteApp.notes";
        public static string DefaultPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\" + FileName;

        public static void SaveToFile(Project project, string path)
        {
            JsonSerializer serializer = new JsonSerializer();
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path) ?? throw new InvalidOperationException());
            }
            // Открываем поток для записи в файл с указанием пути.
            using (var sw = new StreamWriter(path))
            {
                using (JsonTextWriter textWriter = new JsonTextWriter(sw))
                {
                    // Вызываем сериализацию и передаем объект, который хотим сериализовать.
                    serializer.Serialize(textWriter, project);
                }
            }
        }

        /// <summary>
        /// Загрузка файла
        /// </summary>
        public static Project LoadFromFile(string path)
        {
            Project project ;
            if (File.Exists(path))
            {
                try
                {
                    var serializer = new JsonSerializer();
                    using (var reader = new StreamReader(path))
                    {
                        using (var textReader = new JsonTextReader(reader))
                        {
                            project = serializer.Deserialize<Project>(textReader);

                        }
                    }
                }
                catch (JsonReaderException e)
                {
                    return new Project();
                }
            }
            else
            {
                return new Project();
            }

            return project;
        }

    }
}
