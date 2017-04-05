using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBookCollectionLibrary;

namespace MyBookCollectionUI
{
	public partial class MyBookCollection : MetroFramework.Forms.MetroForm
	{
		List<Book> books = new List<Book>();

		public MyBookCollection()
		{
			InitializeComponent();
			UpdateBinding();
		}

		private void MyBookCollection_Load(object sender, EventArgs e)
		{
			UpdateBinding();
		}

		private void UpdateBinding()
		{
			myBooksListBox.DataSource = books;
			myBooksListBox.DisplayMember = "FullInfoBook";
		}

		private void addNewBookButton_Click(object sender, EventArgs e)
		{
			Cataloging catalog = new Cataloging();
			catalog.Show();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();
			books = db.GetBooks(findBookByTitleTextBox.Text);
			UpdateBinding();
		}
	}
}
