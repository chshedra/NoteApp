﻿using System;
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
		private Project _project;

		private void Project_Init()
		{
			_project = new Project();
			_project.Notes.Add(new Note());
		}


		[Test(Description ="Позитивный тест сеттера свойства Notes")]
		public void TestNoteList_CorrectValue()
		{
			Project_Init();
			var expected = new List<Note>();
			expected.Add(_project.Notes[0]);
			var actual = _project;

			Assert.AreEqual(expected, actual.Notes, 
				"Свойство Notes устанавливает или возвращает неправильное название");
		}

		[Test(Description = "Позитивный тест сеттера CurrentNote")]
		public void TestCurrentNoteSet_CorrectValue()
		{
			Project_Init();
			var expected = new Note();
			_project.CurrentNote = expected;
			var actual = _project.CurrentNote;

			Assert.AreEqual(expected, _project.CurrentNote, "Свойство Notes устанавливает " +
				"или возвращает неправильное название");
		}

		[Test(Description = "Позитивный тест метода SortNoteList без параметров")]
		public void TestSortNote_WithoutParam()
		{
			_project = new Project();
			var expected = _project;
			for(int i = 0; i < 5; i++)
			{
				expected.Notes.Add(new Note());
			}

			var actual = _project;
			actual.Notes[1].Title = "ChangedTitle";
			actual.Notes[3].Title = "ChangedTitle";

			actual.Notes = actual.SortNoteList();

			for (int i = 0; i < 5; i++)
			{
				Assert.AreEqual(expected.Notes[i].Created, actual.Notes[i].Created,
					"Функция SortNoteList неправильно сортирует список");
			}
		}

	

		[Test(Description = "Позитивный тест метода SortNoteList с параметрами")]
		public void TestSortNote_WithParam()
		{
			_project = new Project();
			var expected = _project;
			for (int i = 0; i < 5; i++)
			{
				expected.Notes.Add(new Note());
			}

			var actual = _project;
			actual.Notes[1].Title = "ChangedTitle";
			actual.Notes[3].Title = "ChangedTitle";
			var anotherCategory = new Note();
			anotherCategory.Category = NoteCategory.Documents;


			actual.Notes = actual.SortNoteList(NoteCategory.Other);

			for (int i = 0; i < 5; i++)
			{
				Assert.AreEqual(expected.Notes[i].Created, actual.Notes[i].Created,
					"Функция SortNoteList неправильно сортирует список");
			}
		}
	}
}
