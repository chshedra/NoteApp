using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
	/// <summary>
	/// Класс, хранящий список объектов класса Note
	/// </summary>
	class Project
	{
		/// <summary>
		/// Список объекта класса Note
		/// </summary>
		private List<Note> _noteList;

		/// <summary>
		/// Устанавливает и возвращает список объектов класса Note
		/// </summary>
		public List<Note> NoteList { get; set; }

	}
}
