namespace NoteAppUI
{
	partial class AboutForm 
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.AppNameLabel = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.TradeMarkLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AppNameLabel
			// 
			this.AppNameLabel.AutoSize = true;
			this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AppNameLabel.Location = new System.Drawing.Point(19, 23);
			this.AppNameLabel.Name = "AppNameLabel";
			this.AppNameLabel.Size = new System.Drawing.Size(115, 29);
			this.AppNameLabel.TabIndex = 0;
			this.AppNameLabel.Text = "NoteApp";
			// 
			// VersionLabel
			// 
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Location = new System.Drawing.Point(26, 65);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(127, 104);
			this.VersionLabel.TabIndex = 1;
			this.VersionLabel.Text = "v. 1.1.0\r\n\r\n\r\nAuthor: Chshedrin Andrey\r\n\r\n\r\ne-mail for feedback: \r\nGitHub:\r\n";
			// 
			// EmailLinkLabel
			// 
			this.EmailLinkLabel.AutoSize = true;
			this.EmailLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.EmailLinkLabel.Location = new System.Drawing.Point(126, 143);
			this.EmailLinkLabel.Name = "EmailLinkLabel";
			this.EmailLinkLabel.Size = new System.Drawing.Size(106, 13);
			this.EmailLinkLabel.TabIndex = 2;
			this.EmailLinkLabel.TabStop = true;
			this.EmailLinkLabel.Text = "shedrin2001@mail.ru";
			this.EmailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailLinkLabel_LinkClicked);
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.GitHubLinkLabel.Location = new System.Drawing.Point(67, 156);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(191, 13);
			this.GitHubLinkLabel.TabIndex = 3;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Text = "https://github.com/chshedra/NoteApp";
			this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
			// 
			// TradeMarkLabel
			// 
			this.TradeMarkLabel.AutoSize = true;
			this.TradeMarkLabel.Location = new System.Drawing.Point(21, 230);
			this.TradeMarkLabel.Name = "TradeMarkLabel";
			this.TradeMarkLabel.Size = new System.Drawing.Size(117, 13);
			this.TradeMarkLabel.TabIndex = 4;
			this.TradeMarkLabel.Text = "Chshedrin Andrey 2020";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 271);
			this.Controls.Add(this.TradeMarkLabel);
			this.Controls.Add(this.GitHubLinkLabel);
			this.Controls.Add(this.EmailLinkLabel);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.AppNameLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AppNameLabel;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.LinkLabel EmailLinkLabel;
		private System.Windows.Forms.LinkLabel GitHubLinkLabel;
		private System.Windows.Forms.Label TradeMarkLabel;
	}
}