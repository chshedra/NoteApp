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
			this.EditTitleLabel = new System.Windows.Forms.Label();
			this.EditCategoryLabel = new System.Windows.Forms.Label();
			this.EditTitleTextBox = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.EditCreatedTimeLabel = new System.Windows.Forms.Label();
			this.EditCreatedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.EditModifiedTimeLabel = new System.Windows.Forms.Label();
			this.EdiModifiedTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.EditTextBoxPanel = new System.Windows.Forms.Panel();
			this.EditTextBox = new System.Windows.Forms.TextBox();
			this.EditButtonsPanel = new System.Windows.Forms.Panel();
			this.EditOKButton = new System.Windows.Forms.Button();
			this.EditCancelButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.EditTextBoxPanel.SuspendLayout();
			this.EditButtonsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// EditTitleLabel
			// 
			this.EditTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.EditTitleLabel.AutoSize = true;
			this.EditTitleLabel.Location = new System.Drawing.Point(-1, 20);
			this.EditTitleLabel.Name = "EditTitleLabel";
			this.EditTitleLabel.Size = new System.Drawing.Size(30, 13);
			this.EditTitleLabel.TabIndex = 0;
			this.EditTitleLabel.Text = "Title:";
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
			this.EditTitleTextBox.Size = new System.Drawing.Size(599, 20);
			this.EditTitleTextBox.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(63, 41);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(119, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.EdiModifiedTimeDateTimePicker);
			this.panel1.Controls.Add(this.EditModifiedTimeLabel);
			this.panel1.Controls.Add(this.EditCreatedTimeDateTimePicker);
			this.panel1.Controls.Add(this.EditCreatedTimeLabel);
			this.panel1.Controls.Add(this.EditCategoryLabel);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.EditTitleTextBox);
			this.panel1.Controls.Add(this.EditTitleLabel);
			this.panel1.Location = new System.Drawing.Point(7, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(662, 122);
			this.panel1.TabIndex = 4;
			// 
			// EditCreatedTimeLabel
			// 
			this.EditCreatedTimeLabel.AutoSize = true;
			this.EditCreatedTimeLabel.Location = new System.Drawing.Point(5, 68);
			this.EditCreatedTimeLabel.Name = "EditCreatedTimeLabel";
			this.EditCreatedTimeLabel.Size = new System.Drawing.Size(47, 13);
			this.EditCreatedTimeLabel.TabIndex = 4;
			this.EditCreatedTimeLabel.Text = "Created:";
			// 
			// EditCreatedTimeDateTimePicker
			// 
			this.EditCreatedTimeDateTimePicker.Location = new System.Drawing.Point(63, 68);
			this.EditCreatedTimeDateTimePicker.Name = "EditCreatedTimeDateTimePicker";
			this.EditCreatedTimeDateTimePicker.Size = new System.Drawing.Size(116, 20);
			this.EditCreatedTimeDateTimePicker.TabIndex = 5;
			// 
			// EditModifiedTimeLabel
			// 
			this.EditModifiedTimeLabel.AutoSize = true;
			this.EditModifiedTimeLabel.Location = new System.Drawing.Point(203, 68);
			this.EditModifiedTimeLabel.Name = "EditModifiedTimeLabel";
			this.EditModifiedTimeLabel.Size = new System.Drawing.Size(50, 13);
			this.EditModifiedTimeLabel.TabIndex = 6;
			this.EditModifiedTimeLabel.Text = "Modified:";
			// 
			// EdiModifiedTimeDateTimePicker
			// 
			this.EdiModifiedTimeDateTimePicker.Location = new System.Drawing.Point(259, 68);
			this.EdiModifiedTimeDateTimePicker.Name = "EdiModifiedTimeDateTimePicker";
			this.EdiModifiedTimeDateTimePicker.Size = new System.Drawing.Size(119, 20);
			this.EdiModifiedTimeDateTimePicker.TabIndex = 7;
			// 
			// EditTextBoxPanel
			// 
			this.EditTextBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditTextBoxPanel.AutoSize = true;
			this.EditTextBoxPanel.BackColor = System.Drawing.SystemColors.Window;
			this.EditTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.EditTextBoxPanel.Controls.Add(this.EditTextBox);
			this.EditTextBoxPanel.Location = new System.Drawing.Point(8, 124);
			this.EditTextBoxPanel.MaximumSize = new System.Drawing.Size(1000, 700);
			this.EditTextBoxPanel.MinimumSize = new System.Drawing.Size(661, 274);
			this.EditTextBoxPanel.Name = "EditTextBoxPanel";
			this.EditTextBoxPanel.Size = new System.Drawing.Size(661, 274);
			this.EditTextBoxPanel.TabIndex = 5;
			// 
			// EditTextBox
			// 
			this.EditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EditTextBox.Location = new System.Drawing.Point(5, 3);
			this.EditTextBox.MaximumSize = new System.Drawing.Size(1000, 600);
			this.EditTextBox.MinimumSize = new System.Drawing.Size(649, 13);
			this.EditTextBox.Name = "EditTextBox";
			this.EditTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.EditTextBox.Size = new System.Drawing.Size(649, 13);
			this.EditTextBox.TabIndex = 0;
			// 
			// EditButtonsPanel
			// 
			this.EditButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.EditButtonsPanel.Controls.Add(this.EditCancelButton);
			this.EditButtonsPanel.Controls.Add(this.EditOKButton);
			this.EditButtonsPanel.Location = new System.Drawing.Point(476, 399);
			this.EditButtonsPanel.Name = "EditButtonsPanel";
			this.EditButtonsPanel.Size = new System.Drawing.Size(193, 59);
			this.EditButtonsPanel.TabIndex = 6;
			// 
			// EditOKButton
			// 
			this.EditOKButton.Location = new System.Drawing.Point(38, 17);
			this.EditOKButton.Name = "EditOKButton";
			this.EditOKButton.Size = new System.Drawing.Size(64, 27);
			this.EditOKButton.TabIndex = 0;
			this.EditOKButton.Text = "OK";
			this.EditOKButton.UseVisualStyleBackColor = true;
			// 
			// EditCancelButton
			// 
			this.EditCancelButton.Location = new System.Drawing.Point(124, 17);
			this.EditCancelButton.Name = "EditCancelButton";
			this.EditCancelButton.Size = new System.Drawing.Size(64, 27);
			this.EditCancelButton.TabIndex = 1;
			this.EditCancelButton.Text = "Cancel";
			this.EditCancelButton.UseVisualStyleBackColor = true;
			// 
			// AddAndEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.EditButtonsPanel);
			this.Controls.Add(this.EditTextBoxPanel);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(1000, 700);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "AddAndEditForm";
			this.Text = "Add/Edit Note";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.EditTextBoxPanel.ResumeLayout(false);
			this.EditTextBoxPanel.PerformLayout();
			this.EditButtonsPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label EditTitleLabel;
		private System.Windows.Forms.Label EditCategoryLabel;
		private System.Windows.Forms.TextBox EditTitleTextBox;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker EdiModifiedTimeDateTimePicker;
		private System.Windows.Forms.Label EditModifiedTimeLabel;
		private System.Windows.Forms.DateTimePicker EditCreatedTimeDateTimePicker;
		private System.Windows.Forms.Label EditCreatedTimeLabel;
		private System.Windows.Forms.Panel EditTextBoxPanel;
		private System.Windows.Forms.TextBox EditTextBox;
		private System.Windows.Forms.Panel EditButtonsPanel;
		private System.Windows.Forms.Button EditCancelButton;
		private System.Windows.Forms.Button EditOKButton;
	}
}