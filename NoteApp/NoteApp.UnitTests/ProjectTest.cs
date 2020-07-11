using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
	[TestFixture]
	class ProjectTest
	{
		[Test(Description ="Позитивный тест сеттера свойства NoteList")]
		public void TestNoteList_CorrectValue()
		{
			List<Note> expected = new List<Note>();
			Project actual = new Project();

			Assert.AreEqual(expected, actual.NoteList, 
				"Свойство NoteList устанавливает или возвращает неправильное название");
		}
	}
}
