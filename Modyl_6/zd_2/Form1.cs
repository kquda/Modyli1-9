namespace zd_2
{
    public partial class Form1 : Form
    {
        private TaskService taskService;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-JPH55P0\\SQLEXPRESS;Database=TasksBD;Integrated Security=true;"; // Укажите строку подключения к базе данных
            taskService = new TaskService(connectionString);
            DisplayTasks(); // Вывод всех задач при загрузке формы
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Task newTask = new Task
            {
                TaskName = TaskNameTxt.Text,
                TaskDescription = TaskDescriptionTxt.Text,
                DueDate = DueDatePicker.Value,
                IsCompleted = IsCompletedCheckBox.Checked
            };

            // Используем уже существующий taskService
            taskService.AddTask(newTask);

            MessageBox.Show("Задача добавлена.");
            ClearFields();
        }

        // Метод для отображения задач на форме
        private void DisplayTasks()
        {
            listBoxTasks.Items.Clear(); // Очистка ListBox перед обновлением
            var tasks = taskService.GetAllTasks(); // Получение всех задач

            foreach (var task in tasks)
            {
                var taskDescription = task.TaskDescription; // Используйте правильное свойство
                var taskStatus = task.IsCompleted ? "Завершено" : "Не завершено"; // Статус задачи

                // Добавление задачи в ListBox
                listBoxTasks.Items.Add($"ID: {task.TaskID}, Название: {task.TaskName}, Описание: {taskDescription}, Срок: {task.DueDate.ToShortDateString()}, Статус: {taskStatus}");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TaskIDTxt.Text, out int taskId))
            {
                taskService.DeleteTask(taskId); // Удаление задачи
                DisplayTasks(); // Обновление списка задач
            }
            else
            {
                MessageBox.Show("Введите корректный ID задачи для удаления.");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TaskIDTxt.Text, out int taskId))
            {
                Task updatedTask = new Task
                {
                    TaskID = taskId,
                    TaskName = TaskNameTxt.Text,
                    TaskDescription = TaskDescriptionTxt.Text,
                    DueDate = DueDatePicker.Value,
                    IsCompleted = IsCompletedCheckBox.Checked
                };

                taskService.UpdateTask(updatedTask); // Обновление задачи
                DisplayTasks(); // Обновление списка задач
            }
            else
            {
                MessageBox.Show("Введите корректный ID задачи для обновления.");
            }
        }
        private void ClearFields()
        {
            TaskIDTxt.Text = "";
            TaskNameTxt.Text = "";
            TaskDescriptionTxt.Text = "";
            IsCompletedCheckBox.Checked = false;
            DueDatePicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTasks(); // Обновление списка задач
        }
    }
}
