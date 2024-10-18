namespace zd_3
{
    public partial class Form1 : Form
    {
        private BookService bookService;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-JPH55P0\\SQLEXPRESS;Database=LibraryDB;Integrated Security=true;";
            bookService = new BookService(connectionString);
            LoadBooks();
        }

        private void LoadBooks()
        {
            listBoxBooks.Items.Clear();
            List<string> books = bookService.GetAllBooks();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book);
            }
        }

        private void UpdateBookList()
        {
            listBoxBooks.Items.Clear(); // Очищаем список
            List<string> books = bookService.GetAllBooks();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Введите название книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string bookTitle = textBox1.Text;
                bookService.AddBook(bookTitle);
                textBox1.Clear();
                UpdateBookList();
                MessageBox.Show("Книга добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            if (!string.IsNullOrEmpty(title))
            {
                List<string> books = bookService.SearchBooks(title);
                listBoxBooks.Items.Clear();
                foreach (var book in books)
                {
                    listBoxBooks.Items.Add(book);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                string title = listBoxBooks.SelectedItem.ToString();
                bookService.DeleteBook(title);
                LoadBooks();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                string oldTitle = listBoxBooks.SelectedItem.ToString();
                string newTitle = textBox1.Text;

                if (!string.IsNullOrEmpty(newTitle))
                {
                    bookService.EditBook(oldTitle, newTitle);
                    LoadBooks();
                }
            }
        }
    }
}
