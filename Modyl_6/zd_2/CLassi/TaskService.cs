using System.Collections.Generic;
using System.Data.SqlClient;

public class TaskService
{
    private string connectionString; // Строка подключения к базе данных

    public TaskService(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Метод для получения всех задач
    public List<Task> GetAllTasks()
    {
        List<Task> tasks = new List<Task>();
        
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT TaskID, TaskName, TaskDescription, DueDate, IsCompleted FROM Tasks";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Task task = new Task
                {
                    TaskID = (int)reader["TaskID"],
                    TaskName = (string)reader["TaskName"],
                    TaskDescription = (string)reader["TaskDescription"],
                    DueDate = (DateTime)reader["DueDate"],
                    IsCompleted = (bool)reader["IsCompleted"]
                };
                tasks.Add(task);
            }
        }
        return tasks;
    }

    // Метод для добавления новой задачи
    public void AddTask(Task task)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Tasks (TaskName, TaskDescription, DueDate, IsCompleted) VALUES (@TaskName, @TaskDescription, @DueDate, @IsCompleted)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
            cmd.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
            cmd.Parameters.AddWithValue("@DueDate", task.DueDate);
            cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
            
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Метод для обновления задачи
    public void UpdateTask(Task task)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "UPDATE Tasks SET TaskName = @TaskName, TaskDescription = @TaskDescription, DueDate = @DueDate, IsCompleted = @IsCompleted WHERE TaskID = @TaskID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
            cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
            cmd.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
            cmd.Parameters.AddWithValue("@DueDate", task.DueDate);
            cmd.Parameters.AddWithValue("@IsCompleted", task.IsCompleted);
            
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Метод для удаления задачи
    public void DeleteTask(int taskId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TaskID", taskId);
            
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
