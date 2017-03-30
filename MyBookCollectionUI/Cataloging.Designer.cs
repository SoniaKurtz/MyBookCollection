namespace MyBookCollectionUI
{
	partial class Cataloging
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
			this.labelID = new System.Windows.Forms.Label();
			this.labelAuthorFirstName = new System.Windows.Forms.Label();
			this.labelAuthorLastName = new System.Windows.Forms.Label();
			this.labelBookTitle = new System.Windows.Forms.Label();
			this.labelPublicationDate = new System.Windows.Forms.Label();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
			this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
			this.textBoxBookTitle = new System.Windows.Forms.TextBox();
			this.textBoxDate = new System.Windows.Forms.TextBox();
			this.textBoxPublisher = new System.Windows.Forms.TextBox();
			this.addNewBookButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(177, 57);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(28, 21);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID:";
			// 
			// labelAuthorFirstName
			// 
			this.labelAuthorFirstName.AutoSize = true;
			this.labelAuthorFirstName.Location = new System.Drawing.Point(53, 105);
			this.labelAuthorFirstName.Name = "labelAuthorFirstName";
			this.labelAuthorFirstName.Size = new System.Drawing.Size(152, 21);
			this.labelAuthorFirstName.TabIndex = 1;
			this.labelAuthorFirstName.Text = "Author\'s First Name:";
			// 
			// labelAuthorLastName
			// 
			this.labelAuthorLastName.AutoSize = true;
			this.labelAuthorLastName.Location = new System.Drawing.Point(55, 154);
			this.labelAuthorLastName.Name = "labelAuthorLastName";
			this.labelAuthorLastName.Size = new System.Drawing.Size(150, 21);
			this.labelAuthorLastName.TabIndex = 2;
			this.labelAuthorLastName.Text = "Author\'s Last Name:";
			// 
			// labelBookTitle
			// 
			this.labelBookTitle.AutoSize = true;
			this.labelBookTitle.Location = new System.Drawing.Point(126, 207);
			this.labelBookTitle.Name = "labelBookTitle";
			this.labelBookTitle.Size = new System.Drawing.Size(81, 21);
			this.labelBookTitle.TabIndex = 3;
			this.labelBookTitle.Text = "Book Title:";
			// 
			// labelPublicationDate
			// 
			this.labelPublicationDate.AutoSize = true;
			this.labelPublicationDate.Location = new System.Drawing.Point(61, 255);
			this.labelPublicationDate.Name = "labelPublicationDate";
			this.labelPublicationDate.Size = new System.Drawing.Size(144, 21);
			this.labelPublicationDate.TabIndex = 4;
			this.labelPublicationDate.Text = "Date of Publication:";
			// 
			// labelPublisher
			// 
			this.labelPublisher.AutoSize = true;
			this.labelPublisher.Location = new System.Drawing.Point(129, 305);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(78, 21);
			this.labelPublisher.TabIndex = 5;
			this.labelPublisher.Text = "Publisher:";
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(224, 54);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(100, 29);
			this.textBoxID.TabIndex = 6;
			// 
			// textBoxAuthorFirstName
			// 
			this.textBoxAuthorFirstName.Location = new System.Drawing.Point(224, 97);
			this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
			this.textBoxAuthorFirstName.Size = new System.Drawing.Size(328, 29);
			this.textBoxAuthorFirstName.TabIndex = 7;
			// 
			// textBoxAuthorLastName
			// 
			this.textBoxAuthorLastName.Location = new System.Drawing.Point(224, 146);
			this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
			this.textBoxAuthorLastName.Size = new System.Drawing.Size(328, 29);
			this.textBoxAuthorLastName.TabIndex = 8;
			// 
			// textBoxBookTitle
			// 
			this.textBoxBookTitle.Location = new System.Drawing.Point(224, 199);
			this.textBoxBookTitle.Name = "textBoxBookTitle";
			this.textBoxBookTitle.Size = new System.Drawing.Size(328, 29);
			this.textBoxBookTitle.TabIndex = 9;
			// 
			// textBoxDate
			// 
			this.textBoxDate.Location = new System.Drawing.Point(224, 247);
			this.textBoxDate.Name = "textBoxDate";
			this.textBoxDate.Size = new System.Drawing.Size(100, 29);
			this.textBoxDate.TabIndex = 10;
			// 
			// textBoxPublisher
			// 
			this.textBoxPublisher.Location = new System.Drawing.Point(224, 297);
			this.textBoxPublisher.Name = "textBoxPublisher";
			this.textBoxPublisher.Size = new System.Drawing.Size(328, 29);
			this.textBoxPublisher.TabIndex = 11;
			// 
			// addNewBookButton
			// 
			this.addNewBookButton.Location = new System.Drawing.Point(316, 368);
			this.addNewBookButton.Name = "addNewBookButton";
			this.addNewBookButton.Size = new System.Drawing.Size(128, 47);
			this.addNewBookButton.TabIndex = 12;
			this.addNewBookButton.Text = "Save";
			this.addNewBookButton.UseVisualStyleBackColor = true;
			// 
			// Cataloging
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 488);
			this.Controls.Add(this.addNewBookButton);
			this.Controls.Add(this.textBoxPublisher);
			this.Controls.Add(this.textBoxDate);
			this.Controls.Add(this.textBoxBookTitle);
			this.Controls.Add(this.textBoxAuthorLastName);
			this.Controls.Add(this.textBoxAuthorFirstName);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.labelPublisher);
			this.Controls.Add(this.labelPublicationDate);
			this.Controls.Add(this.labelBookTitle);
			this.Controls.Add(this.labelAuthorLastName);
			this.Controls.Add(this.labelAuthorFirstName);
			this.Controls.Add(this.labelID);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Cataloging";
			this.Text = "Cataloging";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelAuthorFirstName;
		private System.Windows.Forms.Label labelAuthorLastName;
		private System.Windows.Forms.Label labelBookTitle;
		private System.Windows.Forms.Label labelPublicationDate;
		private System.Windows.Forms.Label labelPublisher;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.TextBox textBoxAuthorFirstName;
		private System.Windows.Forms.TextBox textBoxAuthorLastName;
		private System.Windows.Forms.TextBox textBoxBookTitle;
		private System.Windows.Forms.TextBox textBoxDate;
		private System.Windows.Forms.TextBox textBoxPublisher;
		private System.Windows.Forms.Button addNewBookButton;
	}
}