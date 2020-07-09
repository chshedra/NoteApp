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
	public partial class MainForm : Form
	{
		private NoteApp.Project _project;
		public MainForm()
		{
			InitializeComponent();
			_project = new NoteApp.Project();

			AddToolStripMenuItem.Click += AddButton_Click;
			EditNoteToolStripMenuItem.Click += EditButton_Click;
			RemoveNoteToolStripMenuItem.Click += RemoveButton_Click;
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

		}

		private void NoteCreatedLabel_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.Show();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			AddAndEditForm addForm = new AddAndEditForm();
			addForm.ShowDialog();

			if (addForm.DialogResult == DialogResult.OK)
			{
				var created = addForm.Note;
				_project.NoteList.Add(created);
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
			var editForm = new AddAndEditForm();

			editForm.Note = selectedNote;
			editForm.ShowDialog();

			if (editForm.DialogResult == DialogResult.OK)
			{
				var updateNote = editForm.Note;
				NoteListBox.Items.RemoveAt(selectedIndex);
				_project.NoteList.RemoveAt(selectedIndex);

				_project.NoteList.Insert(selectedIndex, updateNote);
				NoteListBox.Items.Insert(selectedIndex, updateNote.Title);
				NoteListBox.SelectedIndex = selectedIndex;
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			var selectedIndex = NoteListBox.SelectedIndex;

			if (selectedIndex < 0)
			{
				MessageBox.Show("Необходимо выбрать заметку", "Ошибка удаления",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			NoteListBox.Items.RemoveAt(selectedIndex);
			_project.NoteList.RemoveAt(selectedIndex);
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

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
