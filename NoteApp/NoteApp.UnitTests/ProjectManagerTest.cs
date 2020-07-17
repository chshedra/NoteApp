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
    [TestFixture]
	class ProjectManagerTest
	{
        /// <summary>
		/// Путь до  эталонного файла
		/// </summary>
        private string _etalonFileLocation = Path.GetDirectoryName
			(Assembly.GetExecutingAssembly().Location) + "//TestData//TestData.txt";

		/// <summary>
		/// Путь до создаваемого файла для сохранения данных
		/// </summary>
		private string _savePath = Path.GetDirectoryName
			(Assembly.GetExecutingAssembly().Location) + "//TestData//SaveTestData.txt";

		/// <summary>
		/// Путь до эталонного поврежденного файла
		/// </summary>
		private string _etalonDamageFile = Path.GetDirectoryName
			(Assembly.GetExecutingAssembly().Location) + "//TestData//DamageFile.txt";

		private Project InitProject()
		{
			var project = new Project();
			var note = new Note("Name",null, NoteCategory.Other, 
				new DateTime(), new DateTime());
			project.Notes.Add(note);
			return project;
		}

		[Test(Description = "Позитивный тест метод LoadFromFile с существующим путем." +
			"Должен вернуть проект со значениями")]
		public void TestLoadFromFile_ExistentPath()
		{
			var expected = InitProject();
            var actual = ProjectManager.LoadFromFile(_etalonFileLocation);

			Assert.AreEqual(expected.CurrentNote, actual.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(expected.Notes[0].Title, actual.Notes[0].Title,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.Notes[0].Text, actual.Notes[0].Text,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.Notes[0].Category, actual.Notes[0].Category,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.Notes[0].Created, actual.Notes[0].Created,
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(expected.Notes[0].Modified, actual.Notes[0].Modified,
				"Метод LoadFromFile загружает неправильные данныe");

		}

		[Test(Description = "Позитивный тест метод LoadFromFile с несуществующим путем. " +
			"Должен вернуть пустой проект")]
		public void TestLoadFromFile_NonExistentPath()
		{
			var path = "ProjectManager.DefaultPath";

			var expected = new Project();
            var actual = ProjectManager.LoadFromFile(path);

			Assert.AreEqual(expected.CurrentNote, actual.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(expected.Notes, actual.Notes, "Метод LoadFromFile " +
				"загружает неправильные данный");
		}

		[Test(Description = "Позитивный тест метод LoadFromFile с поврежденным файлом. " +
			"Должен вернуть пустой проект")]
		public void TestLoadFromFile_DamageFile()
		{
			var expected = new Project();
            
			var actual = ProjectManager.LoadFromFile(_etalonDamageFile);

			Assert.AreEqual(actual.CurrentNote, expected.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(actual.Notes, expected.Notes, "Метод LoadFromFile " +
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

			var expected = File.ReadAllText(_etalonFileLocation);
			var actual = File.ReadAllText(_savePath);

			Assert.AreEqual(expected, actual, "Метод SaveToFile сохраняет неверные данные");
		}
	}
}
