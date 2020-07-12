using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;
//TODO: +NoteApp или NotesApp?
namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;
        //TODO: +setup лучше не использовать, разве в методичке этого не сказано?
        //не сказано((

        public void Note_Init()
        {
            _note = new Note();
        }

        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            Note_Init();

            var expected = "NoteTitle";
            _note.Title = expected;
            var actual = _note.Title;
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильное название");
        }

        [Test(Description = "Позитивный тест сеттера Title")]
        public void TestTitleSet_CorrectValue()
        {
            Note_Init();

            var expected = "NoteTitle";
            _note.Title = expected;
            Assert.AreEqual(expected, _note.Title, "Сеттер Title устанавливает " +
                "неправильное значение");
        }

        [Test(Description = "Присвоение неправильной фамилии более 50 символов")]
        public void TestTitleSet_Longer50Symbols()
        {
            Note_Init();

            var wrongTitle = "TitleTitleTitleTitleTitleTitleTitleTitleTitleTitleTitleTitle";
            Assert.Throws<ArgumentException>(
                () => { _note.Title = wrongTitle; },
                    "Должно возникать исключение, если фамилия длиннее 40 символов");
        }

        [Test(Description = "Позитивный тест геттра Text")]
        public void TestTextGet_Positive()
        {
            Note_Init();

            var expected = "NoteCategory";
            _note.Text = expected;
            var actual = _note.Text;
            Assert.AreEqual(expected, actual, "Геттер Text возвращает неправильный текст");
        }

        [Test(Description = "Позитивный тест сеттера Text")]
        public void TestTextSet_CorrectValue()
        {
            Note_Init();

            var expected = "NoteText";
            _note.Text = expected;
            Assert.AreEqual(expected, _note.Text, "Сеттер Text устанавливает неправильное значение");
        }

        [Test(Description = "Позитивный тест геттра Category")]
        public void TestCategoryGet_Positive()
        {
            Note_Init();

            var expected = NoteCategory.Other;
            _note.Category = expected;
            var actual = _note.Category;
            Assert.AreEqual(expected, actual, "Геттер Text возвращает неправильный текст");
        }

        [Test(Description = "Позитивный тест сеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            Note_Init();

            var expected = NoteCategory.Other;
            _note.Category = expected;
            Assert.AreEqual(expected, _note.Category, "Сеттер Text устанавливает " +
                "неправильное значение Category");
        }

        [Test(Description = "Позитивный тест сеттера Created")]
        public void TestCreatedSet_CorrectValue()
        {
            Note_Init();

            var expected = DateTime.Now;
            var actual= _note.Created;
            Assert.AreEqual(expected, actual, "Сеттер Created устанавливает " +
             "неправильное значение");
        }


        [Test(Description = "Позитивный тест геттера Created")]
        public void TestCreatedGet_CorrectValue()
        {
            Note_Init();

            var expected = DateTime.Now;
            var actual = _note.Created;
            Assert.AreEqual(expected, actual, "Геттер Created устанавливает " +
             "неправильное значение");
        }

        [Test(Description = "Позитивный тест сеттера Created")]
        public void TestModifiedSet_CorrectValue()
        {
            Note_Init();

            var expected = DateTime.Now;
            _note.Title = "SetTime";
            var actual = _note.Modified;
            Assert.AreEqual(expected, actual, "Сеттер Modified устанавливает " +
             "неправильное значение");
        }

        [Test(Description = "Позитивный тест геттера Created")]
        public void TestModifiedGet_CorrectValue()
        {
            Note_Init();

            var expected = DateTime.Now;
            _note.Title = "SetTime";
            var actual = _note.Modified;
            Assert.AreEqual(expected, actual, "Геттер Modified устанавливает " +
             "неправильное значение");
        }

        [Test(Description = "Позитивный тест метода Clone")]
        public void TestClone_CorrectValue()
        {
            Note_Init();

            Note expected = _note;
            var actual = (Note)_note.Clone();

            Assert.AreEqual(expected.Title, actual.Title, "Метод Clone устанавливает " +
            "неправильное значение Title");
            Assert.AreEqual(expected.Text, actual.Text, "Метод Clone устанавливает " +
           "неправильное значение Text");
            Assert.AreEqual(expected.Category, actual.Category, "Метод Clone устанавливает " +
           "неправильное значение Category");
            Assert.AreEqual(expected.Created, actual.Created, "Метод Clone устанавливает " +
           "неправильное значение Created");
            Assert.AreEqual(expected.Modified, actual.Modified, "Метод Clone устанавливает " +
           "неправильное значение Modified");

        }

        [Test(Description ="Позитивный тест конструктора Note без параметров")]
        public void TestNoteDefaultConstructor_CorrectValue()
        {
            var expected = new Note("Без названия", null, NoteCategory.Other, 
                DateTime.Now, DateTime.Now);
            var actual = new Note();

            Assert.AreEqual(expected.Title, actual.Title, "Конструктор без параметров " +
                "устанавливает неправильное значение Title");
            Assert.AreEqual(expected.Text, actual.Text, "Конструктор без параметров " +
                "устанавливает неправильное значение Text");
            Assert.AreEqual(expected.Category, actual.Category, "Конструктор без параметров " +
                "устанавливает неправильное значение Category");
            Assert.AreEqual(expected.Created, actual.Created, "Конструктор без параметров " +
                "устанавливает неправильное значение Created");
            Assert.AreEqual(expected.Modified, actual.Modified, "Конструктор без параметров " +
                "устанавливает неправильное значение Modified");
        }

        [Test(Description = "Позитивный тест конструктора Note с параметрами")]
        public void TestNoteConstructor_CorrectValue()
        {
            var expectedTitle = "Title";
            var expectedText = "Text";
            var expectedCategory = NoteCategory.Other;
            var expectedCreated = DateTime.Now;
            var expectedModified = DateTime.Now;

            var actual = new Note(expectedTitle, expectedText, expectedCategory, 
                expectedCreated, expectedModified);

            Assert.AreEqual(expectedTitle, actual.Title, "Конструктор без параметров " +
                "устанавливает неправильное значение Title");
            Assert.AreEqual(expectedText, actual.Text, "Конструктор без параметров " +
                "устанавливает неправильное значение Text");
            Assert.AreEqual(expectedCategory, actual.Category, "Конструктор без параметров " +
                "устанавливает неправильное значение Category");
            Assert.AreEqual(expectedCreated, actual.Created, "Конструктор без параметров " +
                "устанавливает неправильное значение Created");
            Assert.AreEqual(expectedModified, actual.Modified, "Конструктор без параметров " +
                "устанавливает неправильное значение Modified");
        }

        [Test(Description = "Позитивный тест конструктора Note с параметрами")]
        public void TestNoteConstructor_Longer50SymbolsTitle()
        {
            var wrongTitle = "TitleTitleTitleTitleTitleTitleTitleTitleTitleTitleTitle";
            Assert.Throws<ArgumentException>(
               () => {
                   var actual = new Note(wrongTitle, null, NoteCategory.Other,
               DateTime.Now, DateTime.Now);
               },
                   "Должно возникать исключение, если фамилия длиннее 40 символов");
        }
    }
}
