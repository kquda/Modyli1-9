using System.Data.SqlClient;

public class BookService
{
    private string connectionString; // Строка подключения к базе данных

    public BookService(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Метод для получения всех книг
    public List<string> GetAllBooks()
    {
        List<string> books = new List<string>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT Title FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add((string)reader["Title"]);
            }
        }

        return books;
    }

    // Метод для добавления новой книги
    public void AddBook(string title)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Books (Title) VALUES (@Title)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", title);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Метод для удаления книги
    public void DeleteBook(string title)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Books WHERE Title = @Title";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", title);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Метод для поиска книги по названию
    public List<string> SearchBooks(string title)
    {
        List<string> books = new List<string>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT Title FROM Books WHERE Title LIKE @Title";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", "%" + title + "%");

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                books.Add((string)reader["Title"]);
            }
        }

        return books;
    }

    // Метод для редактирования названия книги
    public void EditBook(string oldTitle, string newTitle)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "UPDATE Books SET Title = @NewTitle WHERE Title = @OldTitle";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NewTitle", newTitle);
            cmd.Parameters.AddWithValue("@OldTitle", oldTitle);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
