namespace NoteAppUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.NoteListBox = new System.Windows.Forms.ListBox();
			this.MainFormStripMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.CreatedLabel = new System.Windows.Forms.Label();
			this.ModifiedLabel = new System.Windows.Forms.Label();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.ButtonsPanel = new System.Windows.Forms.Panel();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.MainFormSplitCantainer = new System.Windows.Forms.SplitContainer();
			this.ShowCategoryLabel = new System.Windows.Forms.Label();
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NoteTextBox = new System.Windows.Forms.TextBox();
			this.MainFormStripMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			this.ButtonsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainFormSplitCantainer)).BeginInit();
			this.MainFormSplitCantainer.Panel1.SuspendLayout();
			this.MainFormSplitCantainer.Panel2.SuspendLayout();
			this.MainFormSplitCantainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// NoteListBox
			// 
			this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteListBox.FormattingEnabled = true;
			this.NoteListBox.Location = new System.Drawing.Point(6, 53);
			this.NoteListBox.MaximumSize = new System.Drawing.Size(1000, 800);
			this.NoteListBox.MinimumSize = new System.Drawing.Size(270, 329);
			this.NoteListBox.Name = "NoteListBox";
			this.NoteListBox.Size = new System.Drawing.Size(272, 329);
			this.NoteListBox.TabIndex = 0;
			this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
			// 
			// MainFormStripMenu
			// 
			this.MainFormStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.MainFormStripMenu.Location = new System.Drawing.Point(0, 0);
			this.MainFormStripMenu.Name = "MainFormStripMenu";
			this.MainFormStripMenu.Size = new System.Drawing.Size(784, 24);
			this.MainFormStripMenu.TabIndex = 1;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// AddToolStripMenuItem
			// 
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.AddToolStripMenuItem.Text = "Add note";
			this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// EditNoteToolStripMenuItem
			// 
			this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
			this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.EditNoteToolStripMenuItem.Text = "Edit note";
			this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// RemoveNoteToolStripMenuItem
			// 
			this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
			this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.RemoveNoteToolStripMenuItem.Text = "Remove note";
			this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.aboutToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// CreatedLabel
			// 
			this.CreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.CreatedLabel.AutoSize = true;
			this.CreatedLabel.Location = new System.Drawing.Point(-2, 70);
			this.CreatedLabel.Name = "CreatedLabel";
			this.CreatedLabel.Size = new System.Drawing.Size(50, 13);
			this.CreatedLabel.TabIndex = 3;
			this.CreatedLabel.Text = "Created: ";
			// 
			// ModifiedLabel
			// 
			this.ModifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ModifiedLabel.AutoSize = true;
			this.ModifiedLabel.Location = new System.Drawing.Point(178, 70);
			this.ModifiedLabel.Name = "ModifiedLabel";
			this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
			this.ModifiedLabel.TabIndex = 4;
			this.ModifiedLabel.Text = "Modified:";
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(-2, 50);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
			this.CategoryLabel.TabIndex = 5;
			this.CategoryLabel.Text = "Category:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ModifiedDateTimePicker);
			this.panel1.Controls.Add(this.CreatedDateTimePicker);
			this.panel1.Controls.Add(this.TitleLabel);
			this.panel1.Controls.Add(this.CategoryLabel);
			this.panel1.Controls.Add(this.ModifiedLabel);
			this.panel1.Controls.Add(this.CreatedLabel);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(471, 92);
			this.panel1.TabIndex = 6;
			// 
			// ModifiedDateTimePicker
			// 
			this.ModifiedDateTimePicker.Enabled = false;
			this.ModifiedDateTimePicker.Location = new System.Drawing.Point(234, 70);
			this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
			this.ModifiedDateTimePicker.Size = new System.Drawing.Size(123, 20);
			this.ModifiedDateTimePicker.TabIndex = 8;
			// 
			// CreatedDateTimePicker
			// 
			this.CreatedDateTimePicker.Enabled = false;
			this.CreatedDateTimePicker.Location = new System.Drawing.Point(48, 70);
			this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
			this.CreatedDateTimePicker.Size = new System.Drawing.Size(124, 20);
			this.CreatedDateTimePicker.TabIndex = 7;
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(-5, 19);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(66, 29);
			this.TitleLabel.TabIndex = 6;
			this.TitleLabel.Text = "Title";
			// 
			// ButtonsPanel
			// 
			this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ButtonsPanel.BackColor = System.Drawing.Color.Transparent;
			this.ButtonsPanel.Controls.Add(this.RemoveButton);
			this.ButtonsPanel.Controls.Add(this.EditButton);
			this.ButtonsPanel.Controls.Add(this.AddButton);
			this.ButtonsPanel.Location = new System.Drawing.Point(6, 389);
			this.ButtonsPanel.Name = "ButtonsPanel";
			this.ButtonsPanel.Size = new System.Drawing.Size(255, 37);
			this.ButtonsPanel.TabIndex = 7;
			// 
			// RemoveButton
			// 
			this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
			this.RemoveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveButton.BackgroundImage")));
			this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RemoveButton.FlatAppearance.BorderSize = 0;
			this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveButton.ForeColor = System.Drawing.Color.Transparent;
			this.RemoveButton.Location = new System.Drawing.Point(61, 0);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(23, 31);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.RemoveButton.UseVisualStyleBackColor = false;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.Color.Transparent;
			this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
			this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditButton.FlatAppearance.BorderSize = 0;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.ForeColor = System.Drawing.Color.Transparent;
			this.EditButton.Location = new System.Drawing.Point(32, 0);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(23, 31);
			this.EditButton.TabIndex = 1;
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.Transparent;
			this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
			this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddButton.FlatAppearance.BorderSize = 0;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.ForeColor = System.Drawing.Color.Transparent;
			this.AddButton.Location = new System.Drawing.Point(3, 0);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(23, 31);
			this.AddButton.TabIndex = 0;
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// MainFormSplitCantainer
			// 
			this.MainFormSplitCantainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainFormSplitCantainer.Location = new System.Drawing.Point(0, 24);
			this.MainFormSplitCantainer.MaximumSize = new System.Drawing.Size(980, 800);
			this.MainFormSplitCantainer.MinimumSize = new System.Drawing.Size(600, 400);
			this.MainFormSplitCantainer.Name = "MainFormSplitCantainer";
			// 
			// MainFormSplitCantainer.Panel1
			// 
			this.MainFormSplitCantainer.Panel1.AutoScroll = true;
			this.MainFormSplitCantainer.Panel1.AutoScrollMinSize = new System.Drawing.Size(275, 275);
			this.MainFormSplitCantainer.Panel1.Controls.Add(this.ShowCategoryLabel);
			this.MainFormSplitCantainer.Panel1.Controls.Add(this.CategoryComboBox);
			this.MainFormSplitCantainer.Panel1.Controls.Add(this.ButtonsPanel);
			this.MainFormSplitCantainer.Panel1.Controls.Add(this.NoteListBox);
			// 
			// MainFormSplitCantainer.Panel2
			// 
			this.MainFormSplitCantainer.Panel2.Controls.Add(this.NoteTextBox);
			this.MainFormSplitCantainer.Panel2.Controls.Add(this.panel1);
			this.MainFormSplitCantainer.Size = new System.Drawing.Size(784, 437);
			this.MainFormSplitCantainer.SplitterDistance = 287;
			this.MainFormSplitCantainer.TabIndex = 8;
			// 
			// ShowCategoryLabel
			// 
			this.ShowCategoryLabel.AutoSize = true;
			this.ShowCategoryLabel.Location = new System.Drawing.Point(6, 29);
			this.ShowCategoryLabel.Name = "ShowCategoryLabel";
			this.ShowCategoryLabel.Size = new System.Drawing.Size(84, 13);
			this.ShowCategoryLabel.TabIndex = 9;
			this.ShowCategoryLabel.Text = "Show category: ";
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(96, 26);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(180, 21);
			this.CategoryComboBox.TabIndex = 8;
			this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
			// 
			// NoteTextBox
			// 
			this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextBox.BackColor = System.Drawing.SystemColors.Menu;
			this.NoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NoteTextBox.Location = new System.Drawing.Point(4, 101);
			this.NoteTextBox.MaximumSize = new System.Drawing.Size(1000, 700);
			this.NoteTextBox.MinimumSize = new System.Drawing.Size(470, 319);
			this.NoteTextBox.Multiline = true;
			this.NoteTextBox.Name = "NoteTextBox";
			this.NoteTextBox.ReadOnly = true;
			this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.NoteTextBox.Size = new System.Drawing.Size(474, 325);
			this.NoteTextBox.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.MainFormSplitCantainer);
			this.Controls.Add(this.MainFormStripMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.MainMenuStrip = this.MainFormStripMenu;
			this.MaximumSize = new System.Drawing.Size(1000, 700);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.Text = "NoteApp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.MainFormStripMenu.ResumeLayout(false);
			this.MainFormStripMenu.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ButtonsPanel.ResumeLayout(false);
			this.MainFormSplitCantainer.Panel1.ResumeLayout(false);
			this.MainFormSplitCantainer.Panel1.PerformLayout();
			this.MainFormSplitCantainer.Panel2.ResumeLayout(false);
			this.MainFormSplitCantainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainFormSplitCantainer)).EndInit();
			this.MainFormSplitCantainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox NoteListBox;
		private System.Windows.Forms.MenuStrip MainFormStripMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.Label CreatedLabel;
		private System.Windows.Forms.Label ModifiedLabel;
		private System.Windows.Forms.Label CategoryLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel ButtonsPanel;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
		private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
		private System.Windows.Forms.SplitContainer MainFormSplitCantainer;
		private System.Windows.Forms.TextBox NoteTextBox;
		private System.Windows.Forms.Label ShowCategoryLabel;
		private System.Windows.Forms.ComboBox CategoryComboBox;
	}
}