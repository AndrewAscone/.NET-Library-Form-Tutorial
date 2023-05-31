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
    }
}