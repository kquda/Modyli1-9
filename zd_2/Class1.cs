using System;

// Класс для отправки уведомлений
public class Notification
{
    // События для разных типов уведомлений
    public event Action<string> OnMessageSent;
    public event Action<string> OnCallMade;
    public event Action<string> OnEmailSent;

    // Метод для отправки сообщения
    public void SendMessage(string message)
    {
        Console.WriteLine($"Отправка сообщения: {message}");
        OnMessageSent?.Invoke(message);  // Генерация события
    }

    // Метод для совершения звонка
    public void MakeCall(string phoneNumber)
    {
        Console.WriteLine($"Звонок на номер: {phoneNumber}");
        OnCallMade?.Invoke(phoneNumber);  // Генерация события
    }

    // Метод для отправки электронного письма
    public void SendEmail(string email)
    {
        Console.WriteLine($"Отправка email на: {email}");
        OnEmailSent?.Invoke(email);  // Генерация события
    }
}
