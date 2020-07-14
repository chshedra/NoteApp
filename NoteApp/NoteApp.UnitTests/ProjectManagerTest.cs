using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;
using System.IO;
using NoteApp;

namespace NoteApp.UnitTests
{
	//TODO: +неправильная работа с эталонными файлами - файлы не копируются в выходную папку, а сами файлы пустые
	[TestFixture]
	class ProjectManagerTest
	{
		private string _location = Path.GetDirectoryName
			(Assembly.GetExecutingAssembly().Location) + "//TestData//TestData.txt";
		private string _savePath = Path.GetDirectoryName
			(Assembly.GetExecutingAssembly().Location) + "//TestData//SaveTestData.txt";
		

		//TODO: +именование метода
		private Project InitProject()
		{
			var project = new Project();
			var note = new Note("Name",null, NoteCategory.Other, 
				new DateTime(), new DateTime());
			project.NoteList.Add(note);
			return project;
		}


		[Test(Description = "Позитивный тест метод LoadFromFile с существующим путем." +
			"Должен вернуть проект со значениями")]
		public void TestLoadFromFile_ExistentPath()
		{
			var expected = InitProject();
			//TODO: +не должно в тестировании загрузки файла использоваться сохранение файла
			var actual = ProjectManager.LoadFromFile(_location);

			Assert.AreEqual(expected.CurrentNote, actual.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(expected.NoteList[0].Title, actual.NoteList[0].Title,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.NoteList[0].Text, actual.NoteList[0].Text,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.NoteList[0].Category, actual.NoteList[0].Category,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.NoteList[0].Created, actual.NoteList[0].Created,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.NoteList[0].Modified, actual.NoteList[0].Modified,
				"Метод LoadFromFile загружает неправильные данныe");

		}

		[Test(Description = "Позитивный тест метод LoadFromFile с несуществующим путем. " +
			"Должен вернуть пустой проект")]
		public void TestLoadFromFile_NonExistentPath()
		{
			var path = "ProjectManager.DefaultPath";

			var expected = new Project();
			//TODO: +опять тестирование загрузки файла через сохранение файла - неправильно
			var actual = ProjectManager.LoadFromFile(path);

			Assert.AreEqual(expected.CurrentNote, actual.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(expected.NoteList, actual.NoteList, "Метод LoadFromFile " +
				"загружает неправильные данный");
		}

		[Test(Description = "Позитивный тест метод LoadFromFile с поврежденным файлом. " +
			"Должен вернуть пустой проект")]
		public void TestLoadFromFile_DamageFile()
		{
			var expected = new Project();

			if(!File.Exists(_savePath))
			{
				File.Create(_savePath);
			}

			using (FileStream fstream = new FileStream(_savePath, FileMode.OpenOrCreate))
			{
				byte[] array = System.Text.Encoding.Default.GetBytes("SomeData");
				fstream.Write(array, 0, array.Length);
			}

			var actual = ProjectManager.LoadFromFile(_savePath);

			Assert.AreEqual(actual.CurrentNote, expected.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(actual.NoteList, expected.NoteList, "Метод LoadFromFile " +
				"загружает неправильные данный");
		}

		[Test(Description = "Позитивный тест метод SaveToFile")]
		public void TestSaveToFile_ExistentPath()
		{
			if(File.Exists(_savePath))
			{
				File.Delete(_savePath);
			}

			var project = InitProject();

			ProjectManager.SaveToFile(project, _savePath);

			var expected = File.ReadAllText(_location);
			var actual = File.ReadAllText(_savePath);

			Assert.AreEqual(expected, actual, "Метод SaveToFile сохраняет неверные данные");
		}
	}
}
