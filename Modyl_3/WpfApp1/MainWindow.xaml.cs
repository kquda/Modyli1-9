using System.Windows;

namespace NotificationApp
{
    public partial class MainWindow : Window
    {
        private Notification _notification;

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
            NotificationResult.Text = $"Gmail отправлен на: {email}";
        }

        // Кнопка для отправки сообщения
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            _notification.SendMessage("Сообщение вывелось с помощью делегата!");
        }

        // Кнопка для совершения звонка
        private void MakeCall_Click(object sender, RoutedEventArgs e)
        {
            _notification.MakeCall("+375297012021");
        }

        // Кнопка для отправки email
        private void SendEmail_Click(object sender, RoutedEventArgs e)
        {
            _notification.SendEmail("kquda@gmail.com");
        }
    }
}
