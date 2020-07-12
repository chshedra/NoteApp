﻿using Newtonsoft.Json;
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
		public static string DefaultPath { get; private set; } =
			Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
				"\\NoteApp\\NoteApp.txt");

		/// <summary>
		/// Метод, сохраняющий объекты класса Note
		/// </summary>
		public static void SaveToFile(Project project, string filename)
        { //TODO: часто дублируется название папки - если надо будет изменить, то велика вероятность накосячить. Лучше вынести в константу-литерал
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp"))
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
					"\\NoteApp");
			}

			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(filename)) //TODO: при закрытии программы в этой строке вылетает исключение. (файл почему-то ищется на диске С)
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
            //TODO: нужно сделать возврат пустого проекта, если файл не существует или не может быть прочтен (НЕ ИСПРАВЛЕНО)
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
