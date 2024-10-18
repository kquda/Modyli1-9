using System.Data.Common;
using System.Data.SqlClient;

public class EmployeeService
{
    public List<Employee> GetAllEmployees()
    {
        List<Employee> employees = new List<Employee>();
        string query = "SELECT EmployeeID, FirstName, LastName, Position, Department, HireDate, Salary FROM Employees";

        using (SqlConnection conn = bdConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employee employee = new Employee
                {
                    EmployeeID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Position = reader.GetString(3),
                    Department = reader.GetString(4),
                    HireDate = reader.GetDateTime(5),
                    Salary = reader.GetDecimal(6)
                };
                employees.Add(employee);
            }
        }

        return employees;
    }
    private DatabaseConnection bdConnection = new DatabaseConnection();

    public void AddEmployee(Employee employee)
    {
        using (SqlConnection conn = bdConnection.GetConnection())
        {
            string query = "INSERT INTO Employees (FirstName, LastName, Position, Department, HireDate, Salary) " +
                           "VALUES (@FirstName, @LastName, @Position, @Department, @HireDate, @Salary)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Position", employee.Position);
            cmd.Parameters.AddWithValue("@Department", employee.Department);
            cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Метод для удаления сотрудника
    public void DeleteEmployee(int employeeId)
    {
        using (SqlConnection conn = bdConnection.GetConnection())
        {
            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Метод для редактирования сотрудника
    public void EditEmployee(Employee employee)
    {
        using (SqlConnection conn = bdConnection.GetConnection())
        {
            string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, " +
                           "Position = @Position, Department = @Department, HireDate = @HireDate, Salary = @Salary " +
                           "WHERE EmployeeID = @EmployeeID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Position", employee.Position);
            cmd.Parameters.AddWithValue("@Department", employee.Department);
            cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);
            cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}

