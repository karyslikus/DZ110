public class EmailNotificationFactory : NotificationServiceFactory
{
    public override IMessageSender CreateSender()
    {
        return new EmailSender();
    }
}