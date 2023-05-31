using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookApp.Classes;

namespace BookApp
{
    public partial class NewBookForm : Form
    {
        public NewBookForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveBookData();
            this.Close();
        }

        void SaveBookData()
        {
            Book book = new Book();

            book.Title = textTitle.Text;
            book.Isbn = textISBN.Text;
            book.PublisherName = textPublisher.Text;
            book.AuthorName = textAuthor.Text;
            book.CategoryName = textCategory.Text;

            book.CreateBook(book);
        }
    }
}
