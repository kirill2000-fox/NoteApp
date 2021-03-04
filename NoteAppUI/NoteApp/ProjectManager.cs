
using System;
using System.IO;

using Newtonsoft.Json;

namespace NoteApp
{
    public class ProjectManager
    {
       
        public void Serialisation(Project project)
        {
            

            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(@"note.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, project);
            }
           
        }
    }
}
