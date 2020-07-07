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
	/// Класс, реализующий метод для сохранения объекта класса Project в файл
	/// </summary>
	public static class ProjectManager
	{
		static private readonly string pathName = "...\\My Documents\\NoteApp.notes";

		/// <summary>
		/// Метод, сохраняющий объекты класса Note
		/// </summary>
		static public void SaveToFile(Note note)
		{
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(pathName))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, note);
			}
		}

		/// <summary>
		/// Метод, загружающий объекты класса Note
		/// </summary>
		static public Note LoadFromFile()
		{
			JsonSerializer serializer = new JsonSerializer();

			using (StreamReader sr = new StreamReader(pathName))
			using (JsonReader reader = new JsonTextReader(sr))
			{ 
				return (Note)serializer.Deserialize<Note>(reader);
			}

		}
	}
}
