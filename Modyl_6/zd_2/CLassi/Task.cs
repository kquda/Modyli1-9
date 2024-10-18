public class Task
{
    public int TaskID { get; set; }  // Идентификатор задачи
    public string TaskName { get; set; }  // Название задачи
    public string TaskDescription { get; set; }  // Описание задачи
    public DateTime DueDate { get; set; }  // Срок выполнения
    public bool IsCompleted { get; set; }  // Статус завершенности задачи
}
