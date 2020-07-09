namespace NoteAppUI
{
	partial class AddAndEditForm
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
			this.EditCategoryLabel = new System.Windows.Forms.Label();
			this.EditTitleTextBox = new System.Windows.Forms.TextBox();
			this.EditCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.TitleCategoryTimeEditPanel = new System.Windows.Forms.Panel();
			this.EditTitleLabel = new System.Windows.Forms.Label();
			this.EditModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.EditModifiedLabel = new System.Windows.Forms.Label();
			this.EditCreatedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.EditCreatedLabel = new System.Windows.Forms.Label();
			this.EditButtonsPanel = new System.Windows.Forms.Panel();
			this.EditCancelButton = new System.Windows.Forms.Button();
			this.EditOKButton = new System.Windows.Forms.Button();
			this.AddAndEditFormSplitContainer = new System.Windows.Forms.SplitContainer();
			this.EditTextBox = new System.Windows.Forms.TextBox();
			this.EditTextBoxPanel = new System.Windows.Forms.Panel();
			this.TitleCategoryTimeEditPanel.SuspendLayout();
			this.EditButtonsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddAndEditFormSplitContainer)).BeginInit();
			this.AddAndEditFormSplitContainer.Panel1.SuspendLayout();
			this.AddAndEditFormSplitContainer.Panel2.SuspendLayout();
			this.AddAndEditFormSplitContainer.SuspendLayout();
			this.EditTextBoxPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// EditCategoryLabel
			// 
			this.EditCategoryLabel.AutoSize = true;
			this.EditCategoryLabel.Location = new System.Drawing.Point(5, 44);
			this.EditCategoryLabel.Name = "EditCategoryLabel";
			this.EditCategoryLabel.Size = new System.Drawing.Size(52, 13);
			this.EditCategoryLabel.TabIndex = 1;
			this.EditCategoryLabel.Text = "Category:";
			// 
			// EditTitleTextBox
			// 
			this.EditTitleTextBox.Location = new System.Drawing.Point(63, 17);
			this.EditTitleTextBox.Name = "EditTitleTextBox";
			this.EditTitleTextBox.Size = new System.Drawing.Size(592, 20);
			this.EditTitleTextBox.TabIndex = 2;
			this.EditTitleTextBox.TextChanged += new System.EventHandler(this.EditTitleTextBox_TextChanged);
			// 
			// EditCategoryComboBox
			// 
			this.EditCategoryComboBox.FormattingEnabled = true;
			this.EditCategoryComboBox.Location = new System.Drawing.Point(63, 41);
			this.EditCategoryComboBox.Name = "EditCategoryComboBox";
			this.EditCategoryComboBox.Size = new System.Drawing.Size(119, 21);
			this.EditCategoryComboBox.TabIndex = 3;
			this.EditCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.EditCategoryComboBox_SelectedIndexChanged);
			// 
			// TitleCategoryTimeEditPanel
			// 
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditTitleLabel);
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditModifiedDateTimePicker);
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditModifiedLabel);
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditCreatedTimeDateTimePicker);
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditCreatedLabel);
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditCategoryLabel);
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditCategoryComboBox);
			this.TitleCategoryTimeEditPanel.Controls.Add(this.EditTitleTextBox);
			this.TitleCategoryTimeEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TitleCategoryTimeEditPanel.Location = new System.Drawing.Point(0, 0);
			this.TitleCategoryTimeEditPanel.Name = "TitleCategoryTimeEditPanel";
			this.TitleCategoryTimeEditPanel.Size = new System.Drawing.Size(660, 108);
			this.TitleCategoryTimeEditPanel.TabIndex = 4;
			// 
			// EditTitleLabel
			// 
			this.EditTitleLabel.AutoSize = true;
			this.EditTitleLabel.Location = new System.Drawing.Point(5, 20);
			this.EditTitleLabel.Name = "EditTitleLabel";
			this.EditTitleLabel.Size = new System.Drawing.Size(30, 13);
			this.EditTitleLabel.TabIndex = 8;
			this.EditTitleLabel.Text = "Title:";
			// 
			// EditModifiedDateTimePicker
			// 
			this.EditModifiedDateTimePicker.Enabled = false;
			this.EditModifiedDateTimePicker.Location = new System.Drawing.Point(259, 68);
			this.EditModifiedDateTimePicker.Name = "EditModifiedDateTimePicker";
			this.EditModifiedDateTimePicker.Size = new System.Drawing.Size(123, 20);
			this.EditModifiedDateTimePicker.TabIndex = 7;
			// 
			// EditModifiedLabel
			// 
			this.EditModifiedLabel.AutoSize = true;
			this.EditModifiedLabel.Location = new System.Drawing.Point(203, 68);
			this.EditModifiedLabel.Name = "EditModifiedLabel";
			this.EditModifiedLabel.Size = new System.Drawing.Size(50, 13);
			this.EditModifiedLabel.TabIndex = 6;
			this.EditModifiedLabel.Text = "Modified:";
			// 
			// EditCreatedTimeDateTimePicker
			// 
			this.EditCreatedTimeDateTimePicker.Enabled = false;
			this.EditCreatedTimeDateTimePicker.Location = new System.Drawing.Point(63, 68);
			this.EditCreatedTimeDateTimePicker.Name = "EditCreatedTimeDateTimePicker";
			this.EditCreatedTimeDateTimePicker.Size = new System.Drawing.Size(119, 20);
			this.EditCreatedTimeDateTimePicker.TabIndex = 5;
			// 
			// EditCreatedLabel
			// 
			this.EditCreatedLabel.AutoSize = true;
			this.EditCreatedLabel.Location = new System.Drawing.Point(5, 68);
			this.EditCreatedLabel.Name = "EditCreatedLabel";
			this.EditCreatedLabel.Size = new System.Drawing.Size(47, 13);
			this.EditCreatedLabel.TabIndex = 4;
			this.EditCreatedLabel.Text = "Created:";
			// 
			// EditButtonsPanel
			// 
			this.EditButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.EditButtonsPanel.Controls.Add(this.EditCancelButton);
			this.EditButtonsPanel.Controls.Add(this.EditOKButton);
			this.EditButtonsPanel.Location = new System.Drawing.Point(526, 410);
			this.EditButtonsPanel.Name = "EditButtonsPanel";
			this.EditButtonsPanel.Size = new System.Drawing.Size(146, 39);
			this.EditButtonsPanel.TabIndex = 6;
			// 
			// EditCancelButton
			// 
			this.EditCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.EditCancelButton.Location = new System.Drawing.Point(77, 14);
			this.EditCancelButton.Name = "EditCancelButton";
			this.EditCancelButton.Size = new System.Drawing.Size(64, 22);
			this.EditCancelButton.TabIndex = 1;
			this.EditCancelButton.Text = "Cancel";
			this.EditCancelButton.UseVisualStyleBackColor = true;
			this.EditCancelButton.Click += new System.EventHandler(this.EditCancelButton_Click);
			// 
			// EditOKButton
			// 
			this.EditOKButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.EditOKButton.Location = new System.Drawing.Point(7, 14);
			this.EditOKButton.Name = "EditOKButton";
			this.EditOKButton.Size = new System.Drawing.Size(64, 22);
			this.EditOKButton.TabIndex = 0;
			this.EditOKButton.Text = "OK";
			this.EditOKButton.UseVisualStyleBackColor = true;
			this.EditOKButton.Click += new System.EventHandler(this.EditOKButton_Click);
			// 
			// AddAndEditFormSplitContainer
			// 
			this.AddAndEditFormSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddAndEditFormSplitContainer.Location = new System.Drawing.Point(12, 1);
			this.AddAndEditFormSplitContainer.Name = "AddAndEditFormSplitContainer";
			this.AddAndEditFormSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// AddAndEditFormSplitContainer.Panel1
			// 
			this.AddAndEditFormSplitContainer.Panel1.Controls.Add(this.TitleCategoryTimeEditPanel);
			// 
			// AddAndEditFormSplitContainer.Panel2
			// 
			this.AddAndEditFormSplitContainer.Panel2.Controls.Add(this.EditTextBoxPanel);
			this.AddAndEditFormSplitContainer.Size = new System.Drawing.Size(660, 402);
			this.AddAndEditFormSplitContainer.SplitterDistance = 108;
			this.AddAndEditFormSplitContainer.TabIndex = 7;
			// 
			// EditTextBox
			// 
			this.EditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EditTextBox.Location = new System.Drawing.Point(1, 0);
			this.EditTextBox.MaximumSize = new System.Drawing.Size(1000, 600);
			this.EditTextBox.MinimumSize = new System.Drawing.Size(649, 13);
			this.EditTextBox.Multiline = true;
			this.EditTextBox.Name = "EditTextBox";
			this.EditTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.EditTextBox.Size = new System.Drawing.Size(654, 288);
			this.EditTextBox.TabIndex = 0;
			this.EditTextBox.TextChanged += new System.EventHandler(this.EditTextBox_TextChanged);
			// 
			// EditTextBoxPanel
			// 
			this.EditTextBoxPanel.AutoSize = true;
			this.EditTextBoxPanel.BackColor = System.Drawing.SystemColors.Window;
			this.EditTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.EditTextBoxPanel.Controls.Add(this.EditTextBox);
			this.EditTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EditTextBoxPanel.Location = new System.Drawing.Point(0, 0);
			this.EditTextBoxPanel.MaximumSize = new System.Drawing.Size(1000, 700);
			this.EditTextBoxPanel.MinimumSize = new System.Drawing.Size(6, 50);
			this.EditTextBoxPanel.Name = "EditTextBoxPanel";
			this.EditTextBoxPanel.Size = new System.Drawing.Size(660, 290);
			this.EditTextBoxPanel.TabIndex = 5;
			this.EditTextBoxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EditTextBoxPanel_Paint);
			// 
			// AddAndEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.EditButtonsPanel);
			this.Controls.Add(this.AddAndEditFormSplitContainer);
			this.MaximumSize = new System.Drawing.Size(1000, 700);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "AddAndEditForm";
			this.Text = "Add/Edit Note";
			this.TitleCategoryTimeEditPanel.ResumeLayout(false);
			this.TitleCategoryTimeEditPanel.PerformLayout();
			this.EditButtonsPanel.ResumeLayout(false);
			this.AddAndEditFormSplitContainer.Panel1.ResumeLayout(false);
			this.AddAndEditFormSplitContainer.Panel2.ResumeLayout(false);
			this.AddAndEditFormSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddAndEditFormSplitContainer)).EndInit();
			this.AddAndEditFormSplitContainer.ResumeLayout(false);
			this.EditTextBoxPanel.ResumeLayout(false);
			this.EditTextBoxPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label EditCategoryLabel;
		private System.Windows.Forms.TextBox EditTitleTextBox;
		private System.Windows.Forms.ComboBox EditCategoryComboBox;
		private System.Windows.Forms.Panel TitleCategoryTimeEditPanel;
		private System.Windows.Forms.DateTimePicker EditModifiedDateTimePicker;
		private System.Windows.Forms.Label EditModifiedLabel;
		private System.Windows.Forms.DateTimePicker EditCreatedTimeDateTimePicker;
		private System.Windows.Forms.Label EditCreatedLabel;
		private System.Windows.Forms.Panel EditButtonsPanel;
		private System.Windows.Forms.Button EditCancelButton;
		private System.Windows.Forms.Button EditOKButton;
		private System.Windows.Forms.SplitContainer AddAndEditFormSplitContainer;
		private System.Windows.Forms.Label EditTitleLabel;
		private System.Windows.Forms.Panel EditTextBoxPanel;
		private System.Windows.Forms.TextBox EditTextBox;
	}
}