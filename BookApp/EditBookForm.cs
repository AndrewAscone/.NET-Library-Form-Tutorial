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
    public partial class EditBookForm : Form
    {
        int selectedBookId;

        public EditBookForm(int bookId)
        {
            InitializeComponent();
            selectedBookId = bookId;
            GetBookData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        void GetBookData()
        {
            Book book = new Book();
            book = book.GetBookData(selectedBookId);

            textTitle.Text = book.Title;
            textISBN.Text = book.Isbn;
            textPublisher.Text = book.PublisherName;
            textAuthor.Text = book.AuthorName;
            textCategory.Text = book.CategoryName;

        }
    }
}
