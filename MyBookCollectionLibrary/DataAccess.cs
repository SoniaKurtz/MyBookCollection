using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace MyBookCollectionLibrary
{
	public class DataAccess
	{
		public List<Book> GetBooks(string title)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionHelper.CnnVal("MyBooksDB")))
			{
				//var output = connection.Query<Book>
				//	($"SELECT * FROM Books WHERE BookTitle ='{title}'").ToList();
				var output = connection.Query<Book>
					("dbo.spGetBookTitle @BookTitle", new { BookTitle = title}).ToList();
				return output;
			}
		}

		public void AddBook(string authorFirstName, string authorLastName, string bookTitle, int publicationDate, string publisher)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SQLConnectionHelper.CnnVal("MyBooksDB")))
			{
				
				List<Book> books = new List<Book>();

				books.Add(new Book
				{
					AuthorFirstName = authorFirstName,
					AuthorLastName = authorLastName,
					BookTitle = bookTitle,
					PublicationDate = publicationDate,
					Publisher = publisher
				});

				connection.Execute("dbo.spINSERT @AuthorFirstName, @AuthorLastName, @BookTitle, @PublicationDate, @Publisher")
			}
		}
	}
}