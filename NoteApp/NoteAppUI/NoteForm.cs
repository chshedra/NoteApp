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
    //TODO: +зачем на форме сделаны две панели? Из-за них нарушены расстояния между элементами
    //TODO: ок, теперь зачем на форме одна панель?
    public partial class NoteForm : Form
    {
        /// <summary>
		/// Объект класса Note для редактирования заметки
		/// </summary>
        private Note _note = new Note();

		/// <summary>
		/// Возвращает и устанавливает значение _note
		/// </summary>
		public Note Note
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

		/// <summary>
		/// Конструктор формы NoteForm
		/// </summary>
		public NoteForm()
		{
			InitializeComponent();

			foreach (NoteCategory category in Enum.GetValues(typeof(NoteCategory)))
			{
				EditCategoryComboBox.Items.Add(category);
			}
		}

		private void EditOKButton_Click(object sender, EventArgs e)
		{
			try
			{
				_note.Title = (String.IsNullOrWhiteSpace(EditTitleTextBox.Text)) 
				? "Без названия"
				: EditTitleTextBox.Text;

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
