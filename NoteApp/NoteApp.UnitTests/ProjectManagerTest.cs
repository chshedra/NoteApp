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
		private string _location;
		private Project _project;
		
		private Project Init_Project()
		{
			var project = new Project();
			Note note = new Note();
			List<Note> noteList = new List<Note>();
			noteList.Add(note);
			project.NoteList = noteList;

			return project;
		}

		private void Create_Etalon_File()
		{
			_location = Assembly.GetExecutingAssembly().Location;
			var lastFolder = Path.GetDirectoryName(_location);
			_location = Path.GetDirectoryName(lastFolder) + 
				"//Debug//TestData//TestData.txt";

			ProjectManager.SaveToFile(_project, _location);
		}

		[Test(Description = "Позитивный тест метод LoadFromFile с существующим путем." +
			"Должен вернуть проект со значениями")]
		public void TestLoadFromFile_ExistentPath()
		{
			_project = Init_Project();
			Create_Etalon_File();

			var lastFolder = Path.GetDirectoryName(_location);
			var path = Path.GetDirectoryName(lastFolder) +
				"//TestData//SaveTestData.txt";

			if (File.Exists(path))
			{
				File.Delete(path);
			}

			var project = _project;

			ProjectManager.SaveToFile(project, path);

			var loadProject = ProjectManager.LoadFromFile(path);

			Assert.AreEqual(_project.CurrentNote, project.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(_project.NoteList[0].Title, project.NoteList[0].Title, 
				"Метод LoadFromFile загружает неправильные данныe");
			Assert.AreEqual(_project.NoteList[0].Text, project.NoteList[0].Text, 
				"Метод LoadFromFile загружает неправильные данный");
			Assert.AreEqual(_project.NoteList[0].Category, project.NoteList[0].Category, 
				"Метод LoadFromFile загружает неправильные данный");
			Assert.AreEqual(_project.NoteList[0].Created, project.NoteList[0].Created, 
				"Метод LoadFromFile загружает неправильные данный");
			Assert.AreEqual(_project.NoteList[0].Modified, project.NoteList[0].Modified, 
				"Метод LoadFromFile загружает неправильные данный");
		}

		[Test(Description = "Позитивный тест метод LoadFromFile с несуществующим путем. " +
			"Должен вернуть пустой проект")]
		public void TestLoadFromFile_NonExistentPath()
		{
			_project = new Project();
			Create_Etalon_File();

			var path = "Path";

			if (File.Exists(path))
			{
				File.Delete(path);
			}

			var project = new Project();

			ProjectManager.SaveToFile(project, path);

			var loadProject = ProjectManager.LoadFromFile(path);

			Assert.AreEqual(_project.CurrentNote, project.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(_project.NoteList, project.NoteList, "Метод LoadFromFile " +
				"загружает неправильные данный");
		}

		[Test(Description = "Позитивный тест метод LoadFromFile с поврежденным файлом. " +
			"Должен вернуть пустой проект")]
		public void TestLoadFromFile_DamageFile()
		{
			_project = new Project();
			Create_Etalon_File();

			var lastFolder = Path.GetDirectoryName(_location);
			var path = Path.GetDirectoryName(lastFolder) +
				"//TestData//SaveTestData.txt";

			if (File.Exists(path))
			{
				File.Delete(path);
			}

			var project = new Project();
			var note = new Note();


			using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
			{
				byte[] array = System.Text.Encoding.Default.GetBytes("SomeData");
				fstream.Write(array, 0, array.Length);
				Console.WriteLine("Текст записан в файл");
			}


			var loadProject = ProjectManager.LoadFromFile(path);

			Assert.AreEqual(_project.CurrentNote, project.CurrentNote, "Метод LoadFromFile " +
				"загружает неправильные данный");
			Assert.AreEqual(_project.NoteList, project.NoteList, "Метод LoadFromFile " +
				"загружает неправильные данный");
		}

		[Test(Description = "Позитивный тест метод SaveToFile с существующим путем")]
		public void TestSaveToFile_ExistentPath()
		{
			_project = Init_Project();
			Create_Etalon_File();

			var path = "Path";

			if (File.Exists(path))
			{
				File.Delete(path);
			}

			var project = _project;
			ProjectManager.SaveToFile(project, path);

			var expected = File.ReadAllText(_location);
			var actual = File.ReadAllText(path);

			Assert.AreEqual(expected, actual, "Метод SaveToFile сохраняет неверные данные");
		}

		[Test(Description = "Позитивный тест метод SaveToFile с несуществующим путем")]
		public void TestSaveToFile_NonExistentPath()
		{
			var project = Init_Project();
			_project = Init_Project();
			Create_Etalon_File();

			var lastFolder = Path.GetDirectoryName(_location);
			var path = Path.GetDirectoryName(lastFolder) +
				"//TestData//SaveTestData.txt";

			if (File.Exists(path))
			{
				File.Delete(path);
			}

			ProjectManager.SaveToFile(project, path);

			var expected = File.ReadAllText(_location);
			var actual = File.ReadAllText(path);

			Assert.AreEqual(expected, actual, "Метод SaveToFile сохраняет неверные данные");
		}
	}
}
