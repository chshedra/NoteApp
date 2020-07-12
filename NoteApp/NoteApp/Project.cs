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
		public List<Note> NoteList { get; set; } = new List<Note>();
		//TODO: +вместо конструктора можно сделать значения для свойства по умолчанию

		public Note CurrentNote { get; set; }

		
	}
}
