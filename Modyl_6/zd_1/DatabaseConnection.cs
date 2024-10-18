using System.Data.SqlClient;
public class DatabaseConnection
{
    private string connectionString = "Data Source=DESKTOP-JPH55P0\\SQLEXPRESS;Initial Catalog=EmployeeBD;Integrated Security=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}