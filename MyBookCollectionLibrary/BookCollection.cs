using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookCollectionLibrary
{
	public class BookCollection
	{
		public List<Book> MyBooks { get; set; }

		public BookCollection()
		{
			MyBooks = new List<Book>();
		}
	}
}
