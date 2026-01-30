public class EmailSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Отправка по Email: {message}");
    }
}