using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
	/// <summary>
	/// Класс <see cref="NoteCompare"/> задающий условия сортировки списка
	/// </summary>
	public class NoteCompare: IComparer<Note>
	{
		/// <summary>
		/// Перегруженный метод, задающий условия сортировки списка
		/// </summary>
		/// <param name="note1"></param>
		/// <param name="note2"></param>
		/// <returns></returns>
		public int Compare(Note note1, Note note2)
		{
			if (note1.Modified < note2.Modified)
			{
				return 1;
			}
			else if (note1.Modified > note2.Modified)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}
	}
}
