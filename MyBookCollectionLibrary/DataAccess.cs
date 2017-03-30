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

			}
		}
	}
}