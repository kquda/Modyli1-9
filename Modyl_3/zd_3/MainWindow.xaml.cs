using System.Windows;
using System.Windows.Media;

namespace DelegateApp
{
    public partial class TaskManagementWindow : Window
    {
        private TaskManager taskManager;

        public TaskManagementWindow()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            AddText(null, null);  // Устанавливаем текст-подсказку при запуске
        }

        // Убираем текст-подсказку при получении фокуса
        private void RemoveText(object sender, RoutedEventArgs e)
        {
            if (TaskDescription.Text == "Введите описание задачи")
            {
                TaskDescription.Text = "";
                TaskDescription.Foreground = Brushes.Black;
            }
        }

        // Добавляем текст-подсказку, если поле пустое
        private void AddText(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskDescription.Text))
            {
                TaskDescription.Text = "Введите описание задачи";
                TaskDescription.Foreground = Brushes.Gray;
            }
        }

        // Добавляем задачу и выполняем выбранный делегат
        private void AddTask(object sender, RoutedEventArgs e)
        {
            string taskDescription = TaskDescription.Text;

            if (string.IsNullOrWhiteSpace(taskDescription) || taskDescription == "Введите описание задачи")
            {
                MessageBox.Show("Введите описание задачи.");
                return;
            }

            // Проверяем, выбрал ли пользователь делегат
            if (DelegateSelector.SelectedIndex == 0)  // Отправить уведомление
            {
                TaskDelegate taskDelegate = new TaskDelegate(taskManager.SendNotification);
                taskDelegate(taskDescription);
            }
            else if (DelegateSelector.SelectedIndex == 1)  // Записать в лог
            {
                TaskDelegate taskDelegate = new TaskDelegate(taskManager.LogTask);
                taskDelegate(taskDescription);
            }
            else
            {
                MessageBox.Show("Выберите действие для задачи");
            }
        }
    }

    // Определение делегата для задач
    public delegate void TaskDelegate(string task);
}
