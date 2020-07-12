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
    //TODO: зачем на форме сделаны две панели? Из-за них нарушены расстояния между элементами
    public partial class NoteForm : Form
    { //TODO: xml
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
		public NoteForm()
		{
			InitializeComponent();

			foreach (NoteApp.NoteCategory category in Enum.GetValues(typeof(NoteApp.NoteCategory)))
			{
				EditCategoryComboBox.Items.Add(category);
			}
		}

		private void EditOKButton_Click(object sender, EventArgs e)
		{
			try
			{
				_note.Title = EditTitleTextBox.Text;
				DialogResult = DialogResult.OK;
				this.Close();
			}
			catch(ArgumentException ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, 
					MessageBoxIcon.Warning);
			}
		}

		private void EditCancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void EditTextBox_TextChanged(object sender, EventArgs e)
		{
			_note.Text = EditTextBox.Text;
		}

		private void EditTitleTextBox_TextChanged(object sender, EventArgs e)
		{
			EditTitleTextBox.BackColor = (EditTitleTextBox.Text.Length > 50) 
				? Color.IndianRed
				: Color.White;
		}

		private void EditCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_note.Category = (NoteApp.NoteCategory)EditCategoryComboBox.SelectedItem;
		}
	}
}
