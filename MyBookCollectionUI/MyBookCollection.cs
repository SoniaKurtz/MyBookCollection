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
	public partial class MyBookCollection : Form
	{
		private BookCollection bookCollection = new BookCollection();
		BindingSource booksBinding = new BindingSource();

		public MyBookCollection()
		{
			InitializeComponent();
			SetUpData();
			booksBinding.DataSource = bookCollection.MyBooks;
			listOfBooks.DataSource = booksBinding;
			listOfBooks.DisplayMember = "DisplayBook";
			listOfBooks.ValueMember = "DisplayBook";
		}

		private void MyBookCollection_Load(object sender, EventArgs e) {}

		private void SetUpData()
		{
			bookCollection.MyBooks.Add(new Book
			{
				ID = 001,
				AuthorFirstName = "George",
				AuthorLastName = "Saunders",
				BookTitle = "10 grudnia: opowiadania",
				PublicationDate = 2016,
				Publisher = "W.A.B"
			});

			bookCollection.MyBooks.Add(new Book
			{
				ID = 002,
				AuthorFirstName = "Andrzej",
				AuthorLastName = "Stasiuk",
				BookTitle = "Wschód",
				PublicationDate = 2014,
				Publisher = "Czarne"
			});

			bookCollection.MyBooks.Add(new Book
			{
				ID = 003,
				AuthorFirstName = "Eleanor",
				AuthorLastName = "Catton",
				BookTitle = "Wszystko, co lśni",
				PublicationDate = 2014,
				Publisher = "Wydawnictwo Literackie"
			});
		}
	}
}
