using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NotesApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "NoteTitle";
            var note = new Note();
            note.Title = expected;
            var actual = note.Title;
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильную фамилию");

        }

    }
}
