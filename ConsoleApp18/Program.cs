class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Гибкая система уведомлений ---");
        
        NotificationServiceFactory factory = null;
        
        Console.Write("Какой тип уведомлений использовать? (email/sms): ");
        string notificationType = Console.ReadLine().ToLower();
        
        if (notificationType == "email")
        {
            factory = new EmailNotificationFactory();
            Console.WriteLine("Создана фабрика для Email.");
        }
        else if (notificationType == "sms")
        {
            factory = new SmsNotificationFactory();
            Console.WriteLine("Создана фабрика для SMS.");
        }
        else
        {
            Console.WriteLine("Неизвестный тип уведомлений.");
            return;
        }
        
        Console.WriteLine("Отправляем уведомление...");
        IMessageSender sender = factory.CreateSender();
        sender.Send("Ваш заказ #123 успешно оформлен.");
        
        Console.WriteLine("------------------------------------");
        
        // Демонстрация для другого типа
        Console.Write("Какой тип уведомлений использовать? (email/sms): ");
        notificationType = Console.ReadLine().ToLower();
        
        if (notificationType == "email")
        {
            factory = new EmailNotificationFactory();
            Console.WriteLine("Создана фабрика для Email.");
        }
        else if (notificationType == "sms")
        {
            factory = new SmsNotificationFactory();
            Console.WriteLine("Создана фабрика для SMS.");
        }
        
        Console.WriteLine("Отправляем уведомление...");
        sender = factory.CreateSender();
        sender.Send("Ваш заказ #123 успешно оформлен.");
    }
}