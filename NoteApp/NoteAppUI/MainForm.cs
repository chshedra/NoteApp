using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    //TODO: кнопки на форме не плоские, иконки с белым фоном, а не прозрачным
    //TODO: не везде между контролами стандартные расстояния
    public partial class MainForm : Form
    { //TODO: xml
        private NoteApp.Project _project;
		public MainForm()
		{
			InitializeComponent();

            //TODO: почему подписка здесь, а не в дизайнере? Все подписки надо делать через дизайнер, здесь же только логика работы формы
            AddToolStripMenuItem.Click += AddButton_Click;
			EditNoteToolStripMenuItem.Click += EditButton_Click;
			RemoveNoteToolStripMenuItem.Click += RemoveButton_Click;

			foreach(NoteApp.NoteCategory category in Enum.GetValues(typeof (NoteApp.NoteCategory)))
			{
				CategoryComboBox.Items.Add(category);
			}
			CategoryComboBox.Items.Add("All");
		}

		
		private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedIndex = NoteListBox.SelectedIndex;

			if (NoteListBox.SelectedIndex > -1)
			{ 
				TitleLabel.Text = _project.NoteList[selectedIndex].Title;
				NoteTextBox.Text = _project.NoteList[selectedIndex].Text;
				CategoryLabel.Text = "Category: " + 
					_project.NoteList[selectedIndex].Category.ToString();
				CreatedDateTimePicker.Value = _project.NoteList[selectedIndex].Created;
				ModifiedDateTimePicker.Value = _project.NoteList[selectedIndex].Modified;
			}
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
            //TODO: пустые обработчики удалить
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
				_project.NoteList.Add(created);
				NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);

				NoteListBox.Items.Add(created.Title);

				NoteListBox.SelectedIndex = NoteListBox.Items.Count - 1;
			}
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = NoteListBox.SelectedIndex;
			if(selectedIndex < 0)
			{
				MessageBox.Show("Необходимо выбрать заметку", "Ошибка редактирования",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				NoteListBox.Items.Insert(selectedIndex, updateNote.Title);
				NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);

				NoteListBox.SelectedIndex = selectedIndex;
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
        { //TODO: код проверки выбранной заметки дублируется с кодом выше. Вынести в метод
            var selectedIndex = NoteListBox.SelectedIndex;

			if (selectedIndex < 0)
			{
                //TODO: часть сообщений на русском, часть на английском. Сделать единообразно.
                MessageBox.Show("Необходимо выбрать заметку", "Ошибка удаления",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult result = MessageBox.Show("Do you really want delete this note: " + 
				_project.NoteList[selectedIndex].Title, "Message", 
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (result == DialogResult.OK)
			{
				NoteListBox.Items.RemoveAt(selectedIndex);
				_project.NoteList.RemoveAt(selectedIndex);
				NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);

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
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_project = NoteApp.ProjectManager.LoadFromFile(NoteApp.ProjectManager.DefaultPath);
            //TODO: вот и почему пустой проект не создавать в менеджере? Из-за всяких null у тебя часть бизнес-логики вылазит в формы - неправильно
            if (_project == null)
			{
				_project = new NoteApp.Project();
			}
			else
            { //TODO: делай форич везде, где это возможно
                for (int i = 0; i < _project.NoteList.Count; i++)
				{
					NoteListBox.Items.Add(_project.NoteList[i].Title);
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			NoteApp.ProjectManager.SaveToFile(_project, NoteApp.ProjectManager.DefaultPath);
		}
	}
}
