using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zd_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _notification = new Notification();

            // Регистрация обработчиков событий
            _notification.OnMessageSent += HandleMessageNotification;
            _notification.OnCallMade += HandleCallNotification;
            _notification.OnEmailSent += HandleEmailNotification;
        }
        // Обработчик для события отправки сообщения
        private void HandleMessageNotification(string message)
        {
            NotificationResult.Text = $"Сообщение отправлено: {message}";
        }

        // Обработчик для события звонка
        private void HandleCallNotification(string phoneNumber)
        {
            NotificationResult.Text = $"Звонок совершен на номер: {phoneNumber}";
        }

        // Обработчик для события отправки email
        private void HandleEmailNotification(string email)
        {
            NotificationResult.Text = $"Email отправлен на: {email}";
        }

        // Кнопка для отправки сообщения
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            _notification.SendMessage("Привет, это тестовое сообщение!");
        }

        // Кнопка для совершения звонка
        private void MakeCall_Click(object sender, RoutedEventArgs e)
        {
            _notification.MakeCall("+1234567890");
        }

        // Кнопка для отправки email
        private void SendEmail_Click(object sender, RoutedEventArgs e)
        {
            _notification.SendEmail("test@example.com");
        }
    }
}
