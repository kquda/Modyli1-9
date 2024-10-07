using System;
using System.IO;
using System.Windows;

namespace DelegateApp
{
    public class TaskManager
    {
        private const string logFilePath = "D:\\C# Project\\Praktia_PP\\Modyl_3\\WpfApp1\\task_log.txt"; // Путь к файлу лога

        // Метод для отправки уведомления по задаче
        public void SendNotification(string task)
        {
            MessageBox.Show($"Уведомление отправлено по задаче: {task}");
        }

        // Метод для записи задачи в лог
        public void LogTask(string task)
        {
            try
            {
                // Записываем задачу в файл
                using (StreamWriter writer = new StreamWriter(logFilePath, true)) // true для добавления
                {
                    writer.WriteLine($"{DateTime.Now}: {task}");
                }
                MessageBox.Show($"Задача записана в лог: {task}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи в лог: {ex.Message}");
            }
        }
    }
}
