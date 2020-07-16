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
    //TODO: +кнопки на форме не плоские, иконки с белым фоном, а не прозрачным
    //TODO: +не везде между контролами стандартные расстояния
    public partial class MainForm : Form
    { //TODO: +xml

		/// <summary>
		/// Объект класса Project для хранения заметок
		/// </summary>
        private Project _project;

		/// <summary>
		/// Коллекция объектов Note для хранения заметок по выбранной категории
		/// </summary>
		private List<Note> _categoryNoteList;

		/// <summary>
		/// Конструктор формы MainForm
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

            //TODO: +почему подписка здесь, а не в дизайнере? Все подписки надо делать через дизайнер, здесь же только логика работы формы
			CategoryComboBox.Items.Add("All");
			foreach (NoteCategory category in Enum.GetValues(typeof (NoteCategory)))
			{
				CategoryComboBox.Items.Add(category);
			}

			CategoryComboBox.SelectedItem = "All";
		}

		
		private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndex = NoteListBox.SelectedIndex;
			

			if (selectedIndex > -1)
			{
				if(CategoryComboBox.SelectedItem.ToString() == "All")
				{
					ShowNoteInfo(_project.NoteList, selectedIndex);
				}
				else
				{
					ShowNoteInfo(_categoryNoteList, selectedIndex);
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
				_project.NoteList.Insert(0, created);
				_project.CurrentNote = created;
				ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);

				NoteListBox.Items.Insert(0, created.Title);
				
				NoteListBox.SelectedIndex = 0;
			}
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = NoteListBox.SelectedIndex;

			if(IsNoteExists(selectedIndex) == false)
			{
				return;
			}

			var selectedNote = _project.NoteList[selectedIndex];
			var noteForm = new NoteForm();

			noteForm.Note = selectedNote;
			noteForm.ShowDialog();

			if (noteForm.DialogResult == DialogResult.OK)
			{
				var updateNote = noteForm.Note;
				NoteListBox.Items.RemoveAt(selectedIndex);
				_project.NoteList.RemoveAt(selectedIndex);

				_project.NoteList.Insert(selectedIndex, updateNote);
				_project.NoteList = _project.SortNoteList();
				_project.CurrentNote = updateNote;

				NoteListBox.Items.Insert(0, updateNote.Title);

				ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);

				NoteListBox.SelectedIndex = 0;
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
        { //TODO: +код проверки выбранной заметки дублируется с кодом выше. Вынести в метод\
			DeleteOperation();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
			//TODO: +вот и почему пустой проект не создавать в менеджере? Из-за всяких null у тебя часть бизнес-логики вылазит в формы - неправильно
			_project.NoteList = _project.SortNoteList();
			_categoryNoteList = _project.NoteList;
			//TODO: +делай форич везде, где это возможно
			foreach (Note note in _project.NoteList)
			{
				NoteListBox.Items.Add(note.Title);
				if (note.Created == _project.CurrentNote.Created)
				{
					NoteListBox.SelectedIndex = _project.NoteList.IndexOf(note);
				}
			}	
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (NoteListBox.SelectedIndex > -1)
			{
				_project.CurrentNote = _project.NoteList[NoteListBox.SelectedIndex];
			}
			NoteApp.ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
		}

		private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (CategoryComboBox.SelectedItem.ToString() != "All")
			{
				NoteListBox.Items.Clear();

				_categoryNoteList = 
					_project.SortNoteList((NoteCategory)CategoryComboBox.SelectedItem);
				foreach (Note note in _categoryNoteList)
				{
					if (note.Category.ToString() == CategoryComboBox.SelectedItem.ToString())
					{
						NoteListBox.Items.Add(note.Title);
					}
				}
				NoteListBox.SelectedIndex = 0;
			}
			else
			{
				if (_project != null)
				{
					NoteListBox.Items.Clear();
					_categoryNoteList = _project.SortNoteList();

					foreach (Note note in _categoryNoteList)
					{
						NoteListBox.Items.Add(note.Title);
					}
					NoteListBox.SelectedIndex = 0;
				}
			}
		}

		private bool IsNoteExists(int selectedIndex)
		{
			if (selectedIndex < 0)
			{
				//TODO: +часть сообщений на русском, часть на английском. Сделать единообразно.
				MessageBox.Show("Select the note", "Deletion error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}
			else
			{
				return true;
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Delete")
			{
				DeleteOperation();
			}
			
		}

		/// <summary>
		/// Метод, используемый обработчиками события удаления
		/// </summary>
		private void DeleteOperation()
		{
			var selectedIndex = NoteListBox.SelectedIndex;

			if (IsNoteExists(selectedIndex) == false)
			{
				return;
			}

			DialogResult result = MessageBox.Show("Do you really want delete this note: " +
				_project.NoteList[selectedIndex].Title, "Deletion",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (result == DialogResult.OK)
			{
				foreach (Note note in _project.NoteList)
				{
					if (note.Created == _categoryNoteList[selectedIndex].Created)
					{
						var removeIndex = _project.NoteList.IndexOf(note);
						_project.NoteList.RemoveAt(removeIndex);
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
				_categoryNoteList = _project.NoteList;
				NoteListBox.Items.RemoveAt(selectedIndex);
				if (NoteListBox.Items.Count > 0)
				{
					NoteListBox.SelectedIndex = 0;
				}
				NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);
			}
		}

		private void ShowNoteInfo(List<Note> noteList, int selectedIndex)
		{
			TitleLabel.Text = noteList[selectedIndex].Title;
			NoteTextBox.Text = noteList[selectedIndex].Text;
			CategoryLabel.Text = "Category: " +
				noteList[selectedIndex].Category.ToString();
			CreatedDateTimePicker.Value = noteList[selectedIndex].Created;
			ModifiedDateTimePicker.Value = noteList[selectedIndex].Modified;
		}
	}
}
