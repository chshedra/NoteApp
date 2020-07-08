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
		/// <summary>
		/// Хранит путь к файлу для записи
		/// </summary>
		 private static readonly string _defaultPath =
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp.note";


		/// <summary>
		/// Метод, сохраняющий объекты класса Note
		/// </summary>
		public static void SaveToFile(Note note, string filename)
		{
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
