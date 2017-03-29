using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookCollectionLibrary
{
	public class Book
	{
		public int ID { get; set; }
		public string AuthorFirstName { get; set; }
		public string AuthorLastName { get; set; }
		public string BookTitle { get; set; }
		public int PublicationDate { get; set; }
		public string Publisher { get; set; }

	}
}
