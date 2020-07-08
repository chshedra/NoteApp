using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
	/// <summary>
	/// Класс <see cref="Project"/>, хранящий список объектов класса Note
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Устанавливает и возвращает список объектов класса Note
		/// </summary>
		public List<Note> NoteList { get; set; }

		/// <summary>
		/// Создает новый список, при создании объекта класса Project
		/// </summary>
		public Project()
		{
			NoteList = new List<Note>();
		}

	}
}
