using MyBookCollectionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookCollectionUI
{
	public partial class Cataloging : Form
	{
		public Cataloging()
		{
			InitializeComponent();
		}

		private void addNewBookButton_Click(object sender, EventArgs e)
		{
			DataAccess db = new DataAccess();
			db.AddBook(textBoxAuthorFirstName.Text,
						textBoxAuthorLastName.Text,
						textBoxBookTitle.Text,
						int.Parse(textBoxDate.Text), 
						textBoxPublisher.Text);
			textBoxAuthorFirstName.Text = "";
			textBoxAuthorLastName.Text = "";
			textBoxBookTitle.Text = "";
			textBoxDate.Text = "";
			textBoxPublisher.Text = "";

		}
	}
}
