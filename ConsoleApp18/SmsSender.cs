public class SmsSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Отправка по SMS: {message}");
    }
}