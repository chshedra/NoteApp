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

        public Note CurrentNote { get; set; }

		/// <summary>
		/// Метод, сортирующий заметки по дате редактирования
		/// </summary>
		/// <returns>List<Note></Note></returns>
		public List<Note> SortNote() //TODO:  именование - сортируется только одна заметка?
        {
			NoteList.Sort(new NoteCompare());
			return NoteList;
		}

		/// <summary>
		/// Метод, сортирующий заметки определенной категории по дате редактирования
		/// </summary>
		/// <param name="category"></param>
		/// <returns>List<Note></returns>
		public List<Note> SortNote(NoteCategory category) //TODO: именование
        {
			List<Note> categoryListNote = new List<Note>();
			foreach (Note note in NoteList)
			{
				if (note.Category == category)
				{
					categoryListNote.Add(note);
				}
			}

			categoryListNote.Sort(new NoteCompare());
			return categoryListNote;
		}
	}
}
