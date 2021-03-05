
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
        public static void SaveToFile(Project project, string path)
        {
            Directory.CreateDirectory(path);
            path += FileName;
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(path))
            {
                using (JsonTextWriter textWriter = new JsonTextWriter(sw))
                {
                    //Вызываем сериализацию и передаем объект, который хотим сериализовать
                    serializer.Serialize(textWriter, project);
                }
            }
        }

        public static Project LoadFromFile(string path)
        {
            path += FileName;
            Project project;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader(path))
            {
                using (JsonTextReader textReader = new JsonTextReader(reader))
                {
                    project = (Project) serializer.Deserialize<Project>(textReader);
                    if (project == null)
                    {
                        project = new Project();
                    }

                    return project;
                }
            }
        }
        //public void Serialisation()
        //{
        //    JsonSerializer serializer = new JsonSerializer();
        //    using (StreamWriter sw = new StreamWriter(@"note.json")) ;
        //    using (JsonWriter writer = JsonTextWriter(sw))
        //    {
        //        serializer.Serialize(writer, project);
        //    }
        //}
    }
}
