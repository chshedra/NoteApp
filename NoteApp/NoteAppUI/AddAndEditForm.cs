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
	public partial class AddAndEditForm : Form
	{
		private NoteApp.Note _note = new NoteApp.Note();
		public NoteApp.Note Note
		{
			get
		    {
				return _note;
			}
			set
		    {
				_note = value;
				if (_note != null)
				{
					EditTitleTextBox.Text = _note.Title;
					EditTextBox.Text = _note.Text;
					EditCategoryComboBox.SelectedItem = _note.Category;
					EditModifiedDateTimePicker.Value = _note.Modified;
					EditCreatedTimeDateTimePicker.Value = _note.Created;
				}
			}
			}
		public AddAndEditForm()
		{
			InitializeComponent();
			EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Documents);
			EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Finance);
			EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Home);
			EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Other);
			EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.People);
			EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.SportAndHealth);
			EditCategoryComboBox.Items.Add(NoteApp.NoteCategory.Work);
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void EditOKButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void EditCancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void EditTitleLabel_Click(object sender, EventArgs e)
		{

		}

		private void EditTextBoxPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void EditTextBox_TextChanged(object sender, EventArgs e)
		{
			_note.Text = EditTextBox.Text;
		}

		private void EditTitleTextBox_TextChanged(object sender, EventArgs e)
		{
			_note.Title = EditTitleTextBox.Text;
		}

		private void EditCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_note.Category = (NoteApp.NoteCategory)EditCategoryComboBox.SelectedItem;
		}
	}
}
