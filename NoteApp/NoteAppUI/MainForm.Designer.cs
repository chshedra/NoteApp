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
			this.NoteListBox = new System.Windows.Forms.ListBox();
			this.MainFormStripMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.TextBoxPanel = new System.Windows.Forms.Panel();
			this.SelestedNoteTextBox = new System.Windows.Forms.TextBox();
			this.NoteCreatedLabel = new System.Windows.Forms.Label();
			this.ModifiedNoteLabel = new System.Windows.Forms.Label();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.NoteTitleLabel = new System.Windows.Forms.Label();
			this.ButtonsPanel = new System.Windows.Forms.Panel();
			this.CreatedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ModifiedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.MainFormStripMenu.SuspendLayout();
			this.TextBoxPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.ButtonsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// NoteListBox
			// 
			this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteListBox.FormattingEnabled = true;
			this.NoteListBox.Location = new System.Drawing.Point(9, 38);
			this.NoteListBox.MaximumSize = new System.Drawing.Size(270, 800);
			this.NoteListBox.MinimumSize = new System.Drawing.Size(270, 329);
			this.NoteListBox.Name = "NoteListBox";
			this.NoteListBox.Size = new System.Drawing.Size(270, 368);
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
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.addToolStripMenuItem.Text = "Add note";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// editNoteToolStripMenuItem
			// 
			this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
			this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.editNoteToolStripMenuItem.Text = "Edit note";
			// 
			// removeNoteToolStripMenuItem
			// 
			this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
			this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.removeNoteToolStripMenuItem.Text = "Remove note";
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
			// 
			// TextBoxPanel
			// 
			this.TextBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxPanel.AutoSize = true;
			this.TextBoxPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.TextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxPanel.Controls.Add(this.SelestedNoteTextBox);
			this.TextBoxPanel.Location = new System.Drawing.Point(300, 125);
			this.TextBoxPanel.MaximumSize = new System.Drawing.Size(700, 550);
			this.TextBoxPanel.MinimumSize = new System.Drawing.Size(475, 325);
			this.TextBoxPanel.Name = "TextBoxPanel";
			this.TextBoxPanel.Size = new System.Drawing.Size(475, 325);
			this.TextBoxPanel.TabIndex = 2;
			// 
			// SelestedNoteTextBox
			// 
			this.SelestedNoteTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.SelestedNoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SelestedNoteTextBox.Location = new System.Drawing.Point(1, 2);
			this.SelestedNoteTextBox.Name = "SelestedNoteTextBox";
			this.SelestedNoteTextBox.ReadOnly = true;
			this.SelestedNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.SelestedNoteTextBox.Size = new System.Drawing.Size(465, 13);
			this.SelestedNoteTextBox.TabIndex = 0;
			// 
			// NoteCreatedLabel
			// 
			this.NoteCreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.NoteCreatedLabel.AutoSize = true;
			this.NoteCreatedLabel.Location = new System.Drawing.Point(1, 70);
			this.NoteCreatedLabel.Name = "NoteCreatedLabel";
			this.NoteCreatedLabel.Size = new System.Drawing.Size(50, 13);
			this.NoteCreatedLabel.TabIndex = 3;
			this.NoteCreatedLabel.Text = "Created: ";
			this.NoteCreatedLabel.Click += new System.EventHandler(this.NoteCreatedLabel_Click);
			// 
			// ModifiedNoteLabel
			// 
			this.ModifiedNoteLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ModifiedNoteLabel.AutoSize = true;
			this.ModifiedNoteLabel.Location = new System.Drawing.Point(181, 70);
			this.ModifiedNoteLabel.Name = "ModifiedNoteLabel";
			this.ModifiedNoteLabel.Size = new System.Drawing.Size(50, 13);
			this.ModifiedNoteLabel.TabIndex = 4;
			this.ModifiedNoteLabel.Text = "Modified:";
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(1, 48);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
			this.CategoryLabel.TabIndex = 5;
			this.CategoryLabel.Text = "Category:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ModifiedTimeDateTimePicker);
			this.panel1.Controls.Add(this.CreatedTimeDateTimePicker);
			this.panel1.Controls.Add(this.NoteTitleLabel);
			this.panel1.Controls.Add(this.CategoryLabel);
			this.panel1.Controls.Add(this.ModifiedNoteLabel);
			this.panel1.Controls.Add(this.NoteCreatedLabel);
			this.panel1.Location = new System.Drawing.Point(300, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(477, 92);
			this.panel1.TabIndex = 6;
			// 
			// NoteTitleLabel
			// 
			this.NoteTitleLabel.AutoSize = true;
			this.NoteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NoteTitleLabel.Location = new System.Drawing.Point(-5, 11);
			this.NoteTitleLabel.Name = "NoteTitleLabel";
			this.NoteTitleLabel.Size = new System.Drawing.Size(66, 29);
			this.NoteTitleLabel.TabIndex = 6;
			this.NoteTitleLabel.Text = "Title";
			// 
			// ButtonsPanel
			// 
			this.ButtonsPanel.Controls.Add(this.RemoveButton);
			this.ButtonsPanel.Controls.Add(this.EditButton);
			this.ButtonsPanel.Controls.Add(this.AddButton);
			this.ButtonsPanel.Location = new System.Drawing.Point(9, 412);
			this.ButtonsPanel.Name = "ButtonsPanel";
			this.ButtonsPanel.Size = new System.Drawing.Size(267, 37);
			this.ButtonsPanel.TabIndex = 7;
			// 
			// CreatedTimeDateTimePicker
			// 
			this.CreatedTimeDateTimePicker.Location = new System.Drawing.Point(48, 69);
			this.CreatedTimeDateTimePicker.Name = "CreatedTimeDateTimePicker";
			this.CreatedTimeDateTimePicker.Size = new System.Drawing.Size(109, 20);
			this.CreatedTimeDateTimePicker.TabIndex = 7;
			// 
			// ModifiedTimeDateTimePicker
			// 
			this.ModifiedTimeDateTimePicker.Location = new System.Drawing.Point(228, 70);
			this.ModifiedTimeDateTimePicker.Name = "ModifiedTimeDateTimePicker";
			this.ModifiedTimeDateTimePicker.Size = new System.Drawing.Size(113, 20);
			this.ModifiedTimeDateTimePicker.TabIndex = 8;
			// 
			// RemoveButton
			// 
			this.RemoveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.RemoveButton.BackgroundImage = global::NoteAppUI.Properties.Resources.Files_Delete_File_icon;
			this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RemoveButton.Location = new System.Drawing.Point(85, 1);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(38, 33);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.UseVisualStyleBackColor = false;
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.EditButton.BackgroundImage = global::NoteAppUI.Properties.Resources.загружено__1_;
			this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditButton.Location = new System.Drawing.Point(42, 0);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(37, 34);
			this.EditButton.TabIndex = 1;
			this.EditButton.UseVisualStyleBackColor = false;
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddButton.BackgroundImage = global::NoteAppUI.Properties.Resources._13787;
			this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddButton.Location = new System.Drawing.Point(0, 0);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(36, 34);
			this.AddButton.TabIndex = 0;
			this.AddButton.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.NoteListBox);
			this.Controls.Add(this.ButtonsPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TextBoxPanel);
			this.Controls.Add(this.MainFormStripMenu);
			this.MainMenuStrip = this.MainFormStripMenu;
			this.MaximumSize = new System.Drawing.Size(1000, 700);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.MainFormStripMenu.ResumeLayout(false);
			this.MainFormStripMenu.PerformLayout();
			this.TextBoxPanel.ResumeLayout(false);
			this.TextBoxPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ButtonsPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox NoteListBox;
		private System.Windows.Forms.MenuStrip MainFormStripMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.Panel TextBoxPanel;
		private System.Windows.Forms.TextBox SelestedNoteTextBox;
		private System.Windows.Forms.Label NoteCreatedLabel;
		private System.Windows.Forms.Label ModifiedNoteLabel;
		private System.Windows.Forms.Label CategoryLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label NoteTitleLabel;
		private System.Windows.Forms.Panel ButtonsPanel;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.DateTimePicker ModifiedTimeDateTimePicker;
		private System.Windows.Forms.DateTimePicker CreatedTimeDateTimePicker;
	}
}