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
        //TODO:+ только надо еще создавать подпапку для своей программы, а не просто в AppData
        //TODO: +переделать в открытое свойство
        /// <summary>
        /// Хранит путь к файлу для записи
        /// </summary>
		public static string DefaultPath { get; private set; } =
			Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
				"\\NoteApp\\NoteApp.txt");

		/// <summary>
		/// Метод, сохраняющий объекты класса Note
		/// </summary>
		public static void SaveToFile(Project project, string filename)
        { //TODO: +сохранять нужно в любом случае по тому пути, который передали в метод. А вот клиентский код может либо передать свой путь, либо передать дефолтный
            //TODO: +класс должен сохранять/загружать весь проект, а не по одной заметке.
           
			if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp"))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
					"\\NoteApp");
				
			}

			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(filename))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{ 
				serializer.Serialize(writer, project);
			}
		}

		/// <summary>
		/// Метод, загружающий объекты класса Note
		/// </summary>
		public static Project LoadFromFile(string filename)
		{
			//TODO: +работа только с переданным путем, а не фефолтным
			//TODO: +метод должен загружать объект проекта, а не одной заметки
			//TODO: +нужно сделать возврат пустого проекта, если файл не существует или не может быть прочтен
			Project project = null;

			if (File.Exists(filename))
			{
				JsonSerializer serializer = new JsonSerializer();

				using (StreamReader sr = new StreamReader(filename))
				using (JsonReader reader = new JsonTextReader(sr))
				{

					project = (Project)serializer.Deserialize<Project>(reader);
				}
			}
			return project;
		}

	
	}
}
