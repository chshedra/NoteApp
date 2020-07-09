using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
	/// <summary>
	/// Класс <see cref="ProjectManager"/>, реализующий метод для сохранения объекта класса Project в файл
	/// </summary>
	public static class ProjectManager
	{
        //TODO: только надо еще создавать подпапку для своей программы, а не просто в AppData
        //TODO: переделать в открытое свойство
        /// <summary>
        /// Хранит путь к файлу для записи
        /// </summary>
        private static readonly string _defaultPath =
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp.note";


		/// <summary>
		/// Метод, сохраняющий объекты класса Note
		/// </summary>
		public static void SaveToFile(Note note, string filename)
        { //TODO: сохранять нужно в любом случае по тому пути, который передали в метод. А вот клиентский код может либо передать свой путь, либо передать дефолтный
            //TODO: класс должен сохранять/загружать весь проект, а не по одной заметке.
            filename = File.Exists(filename) ? filename : _defaultPath;

			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(filename))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{ 
				serializer.Serialize(writer, note);
			}
		}

		/// <summary>
		/// Метод, загружающий объекты класса Note
		/// </summary>
		public static Note LoadFromFile(string filename)
		{
            //TODO: работа только с переданным путем, а не фефолтным
            //TODO: метод должен загружать объект проекта, а не одной заметки
            //TODO: нужно сделать возврат пустого проекта, если файл не существует или не может быть прочтен
            filename = File.Exists(filename) ? filename : _defaultPath;
		
			JsonSerializer serializer = new JsonSerializer();
			Note note = null;

			using (StreamReader sr = new StreamReader(filename))
			using (JsonReader reader = new JsonTextReader(sr))
			{ 

				note = (Note)serializer.Deserialize<Note>(reader);
			}
			return note;
		}

	
	}
}
