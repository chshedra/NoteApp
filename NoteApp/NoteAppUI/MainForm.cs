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
        public MainForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        { 
            var note = new NoteApp.Note();
            var list = new NoteApp.Project();
            list.NoteList.Add(note);
            label1.Text = String.Format($"{list.NoteList[0].Title},{list.NoteList[0].NoteText},{list.NoteList[0].CreationTime}, " +
                $"{list.NoteList[0].LastChangeTime}, {list.NoteList[0].Category}");
        }
    }
}
