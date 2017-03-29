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
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
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
			// dataGridViewBooks
			// 
			this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBooks.Location = new System.Drawing.Point(12, 102);
			this.dataGridViewBooks.Name = "dataGridViewBooks";
			this.dataGridViewBooks.Size = new System.Drawing.Size(442, 386);
			this.dataGridViewBooks.TabIndex = 6;
			// 
			// MyBookCollection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 500);
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
	}
}