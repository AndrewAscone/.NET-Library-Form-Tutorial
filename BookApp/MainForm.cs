using BookApp.Classes;
namespace BookApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGridView();
        }

        void FillGridView()
        {
            List<Book> bookList = new List<Book>();

            Book book = new Book();

            bookList = book.GetBooks();

            dataGridView1.DataSource = bookList;
        }

        private void btnNewForm_Click_1(object sender, EventArgs e)
        {
            NewBookForm formNewBook = new NewBookForm();
            formNewBook.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void btnOpenEditForm_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        void EditBook()
        {
            int bookId;

            bookId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            EditBookForm formEditBook = new EditBookForm(bookId);
            formEditBook.ShowDialog();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        void DeleteBook()
        {
            int bookId;

            bookId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            Book book = new Book();
            book.DeleteBook(bookId);
            FillGridView();
        }
    }
}