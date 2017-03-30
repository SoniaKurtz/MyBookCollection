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
			this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
			this.findBookByTitleTextBox = new System.Windows.Forms.TextBox();
			this.findBookByTitleLabel = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.myBooksListBox = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// headerName
			// 
			this.headerName.AutoSize = true;
			this.headerName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.headerName.Location = new System.Drawing.Point(84, 9);
			this.headerName.Name = "headerName";
			this.headerName.Size = new System.Drawing.Size(120, 32);
			this.headerName.TabIndex = 0;
			this.headerName.Text = "My Books";
			// 
			// addNewBookButton
			// 
			this.addNewBookButton.Location = new System.Drawing.Point(748, 102);
			this.addNewBookButton.Name = "addNewBookButton";
			this.addNewBookButton.Size = new System.Drawing.Size(141, 45);
			this.addNewBookButton.TabIndex = 2;
			this.addNewBookButton.Text = "Add";
			this.addNewBookButton.UseVisualStyleBackColor = true;
			this.addNewBookButton.Click += new System.EventHandler(this.addNewBookButton_Click);
			// 
			// editBookButton
			// 
			this.editBookButton.Location = new System.Drawing.Point(748, 153);
			this.editBookButton.Name = "editBookButton";
			this.editBookButton.Size = new System.Drawing.Size(141, 45);
			this.editBookButton.TabIndex = 3;
			this.editBookButton.Text = "Edit";
			this.editBookButton.UseVisualStyleBackColor = true;
			// 
			// deleteBookButton
			// 
			this.deleteBookButton.Location = new System.Drawing.Point(748, 204);
			this.deleteBookButton.Name = "deleteBookButton";
			this.deleteBookButton.Size = new System.Drawing.Size(141, 45);
			this.deleteBookButton.TabIndex = 4;
			this.deleteBookButton.Text = "Delete";
			this.deleteBookButton.UseVisualStyleBackColor = true;
			// 
			// dataGridViewBooks
			// 
			this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBooks.Location = new System.Drawing.Point(12, 102);
			this.dataGridViewBooks.Name = "dataGridViewBooks";
			this.dataGridViewBooks.Size = new System.Drawing.Size(685, 147);
			this.dataGridViewBooks.TabIndex = 6;
			// 
			// findBookByTitleTextBox
			// 
			this.findBookByTitleTextBox.Location = new System.Drawing.Point(215, 56);
			this.findBookByTitleTextBox.Name = "findBookByTitleTextBox";
			this.findBookByTitleTextBox.Size = new System.Drawing.Size(326, 29);
			this.findBookByTitleTextBox.TabIndex = 7;
			// 
			// findBookByTitleLabel
			// 
			this.findBookByTitleLabel.AutoSize = true;
			this.findBookByTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.findBookByTitleLabel.Location = new System.Drawing.Point(132, 56);
			this.findBookByTitleLabel.Name = "findBookByTitleLabel";
			this.findBookByTitleLabel.Size = new System.Drawing.Size(48, 25);
			this.findBookByTitleLabel.TabIndex = 8;
			this.findBookByTitleLabel.Text = "Title";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(556, 47);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(141, 45);
			this.searchButton.TabIndex = 9;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// myBooksListBox
			// 
			this.myBooksListBox.FormattingEnabled = true;
			this.myBooksListBox.ItemHeight = 21;
			this.myBooksListBox.Location = new System.Drawing.Point(12, 255);
			this.myBooksListBox.Name = "myBooksListBox";
			this.myBooksListBox.Size = new System.Drawing.Size(685, 256);
			this.myBooksListBox.TabIndex = 10;
			// 
			// MyBookCollection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 521);
			this.Controls.Add(this.myBooksListBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.findBookByTitleLabel);
			this.Controls.Add(this.findBookByTitleTextBox);
			this.Controls.Add(this.dataGridViewBooks);
			this.Controls.Add(this.deleteBookButton);
			this.Controls.Add(this.editBookButton);
			this.Controls.Add(this.addNewBookButton);
			this.Controls.Add(this.headerName);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MyBookCollection";
			this.Text = "My Book Collection";
			this.Load += new System.EventHandler(this.MyBookCollection_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerName;
		private System.Windows.Forms.Button addNewBookButton;
		private System.Windows.Forms.Button editBookButton;
		private System.Windows.Forms.Button deleteBookButton;
		private System.Windows.Forms.DataGridView dataGridViewBooks;
		private System.Windows.Forms.TextBox findBookByTitleTextBox;
		private System.Windows.Forms.Label findBookByTitleLabel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ListBox myBooksListBox;
	}
}