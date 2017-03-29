namespace MyBookCollectionUI
{
	partial class MyBookCollection
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
			this.headerName = new System.Windows.Forms.Label();
			this.addNewBookButton = new System.Windows.Forms.Button();
			this.editBookButton = new System.Windows.Forms.Button();
			this.deleteBookButton = new System.Windows.Forms.Button();
			this.listOfBooks = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// headerName
			// 
			this.headerName.AutoSize = true;
			this.headerName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.headerName.Location = new System.Drawing.Point(161, 26);
			this.headerName.Name = "headerName";
			this.headerName.Size = new System.Drawing.Size(120, 32);
			this.headerName.TabIndex = 0;
			this.headerName.Text = "My Books";
			// 
			// addNewBookButton
			// 
			this.addNewBookButton.Location = new System.Drawing.Point(460, 102);
			this.addNewBookButton.Name = "addNewBookButton";
			this.addNewBookButton.Size = new System.Drawing.Size(141, 45);
			this.addNewBookButton.TabIndex = 2;
			this.addNewBookButton.Text = "Add";
			this.addNewBookButton.UseVisualStyleBackColor = true;
			// 
			// editBookButton
			// 
			this.editBookButton.Location = new System.Drawing.Point(460, 153);
			this.editBookButton.Name = "editBookButton";
			this.editBookButton.Size = new System.Drawing.Size(141, 45);
			this.editBookButton.TabIndex = 3;
			this.editBookButton.Text = "Edit";
			this.editBookButton.UseVisualStyleBackColor = true;
			// 
			// deleteBookButton
			// 
			this.deleteBookButton.Location = new System.Drawing.Point(460, 204);
			this.deleteBookButton.Name = "deleteBookButton";
			this.deleteBookButton.Size = new System.Drawing.Size(141, 45);
			this.deleteBookButton.TabIndex = 4;
			this.deleteBookButton.Text = "Delete";
			this.deleteBookButton.UseVisualStyleBackColor = true;
			// 
			// listOfBooks
			// 
			this.listOfBooks.FormattingEnabled = true;
			this.listOfBooks.ItemHeight = 21;
			this.listOfBooks.Location = new System.Drawing.Point(12, 84);
			this.listOfBooks.Name = "listOfBooks";
			this.listOfBooks.Size = new System.Drawing.Size(442, 403);
			this.listOfBooks.TabIndex = 5;
			// 
			// MyBookCollection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 500);
			this.Controls.Add(this.listOfBooks);
			this.Controls.Add(this.deleteBookButton);
			this.Controls.Add(this.editBookButton);
			this.Controls.Add(this.addNewBookButton);
			this.Controls.Add(this.headerName);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MyBookCollection";
			this.Text = "My Book Collection";
			this.Load += new System.EventHandler(this.MyBookCollection_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerName;
		private System.Windows.Forms.Button addNewBookButton;
		private System.Windows.Forms.Button editBookButton;
		private System.Windows.Forms.Button deleteBookButton;
		private System.Windows.Forms.ListBox listOfBooks;
	}
}