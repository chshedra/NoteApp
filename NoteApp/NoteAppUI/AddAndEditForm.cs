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
		public AddAndEditForm()
		{
			InitializeComponent();
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void EditOKButton_Click(object sender, EventArgs e)
		{
			var list = new NoteApp.Project();
			var note = new NoteApp.Note();
			list.NoteList.Add(note);
			NoteApp.ProjectManager.SaveToFile(list, NoteApp.ProjectManager.DefaultPath);
			EditTextBox.Text = note.Modified.ToString();
		}

		private void EditCancelButton_Click(object sender, EventArgs e)
		{
			var note = NoteApp.ProjectManager.LoadFromFile(NoteApp.ProjectManager.DefaultPath);
			EditTextBox.Text = note.NoteList[0].Modified.ToString();
		}

		private void EditTitleLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
