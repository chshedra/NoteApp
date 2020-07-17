using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
		/// Объект класса Project для хранения заметок
		/// </summary>
        private Project _project;

		/// <summary>
		/// Коллекция объектов Note для хранения заметок по выбранной категории
		/// </summary>
		private List<Note> _categoryNotes;

		/// <summary>
		/// Конструктор формы MainForm
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			_project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);

			CategoryComboBox.Items.Add("All");
			foreach (NoteCategory category in Enum.GetValues(typeof (NoteCategory)))
			{
				CategoryComboBox.Items.Add(category);
			}

			CategoryComboBox.SelectedItem = "All";
		}

		/// <summary>
		/// Метод, реализующий вставку в NoteListBox, в зависимости от категории
		/// </summary>
		private void InsertNoteListBox(Note note)
		{
			if (CategoryComboBox.SelectedItem.ToString() == note.Category.ToString())
			{
				_categoryNotes = _project.SortNoteList(note.Category);
				NoteListBox.Items.Insert(0, note.Title);
				NoteListBox.SelectedIndex = 0;
			}
			else
			{
				if (CategoryComboBox.SelectedItem.ToString() == "All")
				{
					NoteListBox.Items.Insert(0, note.Title);
					NoteListBox.SelectedIndex = 0;
				}
			}
		}

		/// <summary>
		/// Метод, используемый обработчиками события удаления
		/// </summary>
		private void DeleteNote()
		{
			var selectedIndex = NoteListBox.SelectedIndex;

			if (!IsNoteExists(selectedIndex))
			{
				return;
			}

			DialogResult result = MessageBox.Show("Do you really want delete this note: " +
				_project.Notes[selectedIndex].Title, "Deletion",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (result == DialogResult.OK)
			{
				foreach (Note note in _project.Notes)
				{
					if (note.Created == _project.Notes[selectedIndex].Created)
					{
						var removeIndex = _project.Notes.IndexOf(note);
						_project.Notes.RemoveAt(removeIndex);
						NoteListBox.Items.RemoveAt(selectedIndex);
						break;
					}
				}
				if (NoteListBox.Items.Count > 0)
				{
					NoteListBox.SelectedIndex = 0;
				}
				else
				{
					TitleLabel.Text = "Title";
					NoteTextBox.Text = null;
					CategoryLabel.Text = "Category: ";
					CreatedDateTimePicker.Value = DateTime.Now;
					ModifiedDateTimePicker.Value = DateTime.Now;
				}
				if (CategoryComboBox.SelectedItem.ToString() != "All")
				{
					_categoryNotes = _project.SortNoteList((NoteCategory)CategoryComboBox.SelectedItem);
				}
				NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);
			}
		}

		/// <summary>
		/// Метод, отображающий информацию выбранной заметки в соответствующих полях формы
		/// </summary>
		/// <param name="noteList"></param>
		/// <param name="selectedIndex"></param>
		private void ShowNoteInfo(List<Note> noteList, int selectedIndex)
		{
			TitleLabel.Text = noteList[selectedIndex].Title;
			NoteTextBox.Text = noteList[selectedIndex].Text;
			CategoryLabel.Text = "Category: " +
				noteList[selectedIndex].Category.ToString();
			CreatedDateTimePicker.Value = noteList[selectedIndex].Created;
			ModifiedDateTimePicker.Value = noteList[selectedIndex].Modified;
		}

		/// <summary>
		/// Метод, проверяющий существование выбранной заметки
		/// </summary>
		/// <param name="selectedIndex"></param>
		private bool IsNoteExists(int selectedIndex)
		{
			if (selectedIndex < 0)
			{
				MessageBox.Show("Select the note", "Deletion error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}
			else
			{
				return true;
			}
		}

		private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndex = NoteListBox.SelectedIndex;

            if (selectedIndex > -1)
			{
				if(CategoryComboBox.SelectedItem.ToString() == "All")
				{
					ShowNoteInfo(_project.Notes, selectedIndex);
				}
				else
				{
					ShowNoteInfo(_categoryNotes, selectedIndex);
				}
			}
		}

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.Show();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			NoteForm noteForm = new NoteForm();
			noteForm.ShowDialog();

			if (noteForm.DialogResult == DialogResult.OK)
			{
				var created = noteForm.Note;
				_project.Notes.Insert(0, created);
				_project.CurrentNote = created;
				ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
				InsertNoteListBox(created);
			}
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = NoteListBox.SelectedIndex;

			if(IsNoteExists(selectedIndex) == false)
			{
				return;
			}

			var selectedNote = _project.Notes[selectedIndex];
			var noteForm = new NoteForm();

			noteForm.Note = selectedNote;
			noteForm.ShowDialog();

			if (noteForm.DialogResult == DialogResult.OK)
			{
				var updateNote = noteForm.Note;
				NoteListBox.Items.RemoveAt(selectedIndex);

				int removeIndex = _project.Notes.IndexOf(updateNote);
				
				_project.Notes.RemoveAt(removeIndex);
				_project.Notes.Insert(removeIndex, updateNote);
				_project.Notes = _project.SortNoteList();
				_project.CurrentNote = updateNote;
				ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);

				InsertNoteListBox(updateNote);
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
        {
            DeleteNote();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (NoteListBox.SelectedIndex > -1)
			{
				_project.CurrentNote = _project.Notes[NoteListBox.SelectedIndex];
			}
			NoteApp.ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
		}

		private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			NoteListBox.Items.Clear();

			if (CategoryComboBox.SelectedItem.ToString() != "All")
			{
				_categoryNotes = 
					_project.SortNoteList((NoteCategory)CategoryComboBox.SelectedItem);
				foreach (Note note in _categoryNotes)
				{
					if (note.Category.ToString() == CategoryComboBox.SelectedItem.ToString())
					{
						NoteListBox.Items.Add(note.Title);
					}
				}
			}
			else
			{
				if (_project.Notes.Count > 0)
				{
					_categoryNotes = _project.SortNoteList();

					foreach (Note note in _categoryNotes)
					{
						NoteListBox.Items.Add(note.Title);
					}
					NoteListBox.SelectedIndex = 0;
				}
			}
			if(NoteListBox.Items.Count > 0)
			{
				NoteListBox.SelectedIndex = 0;
			}
		}
       
		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Delete")
			{
				DeleteNote();
			}
			
		}	
	}
}
