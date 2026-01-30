public class SmsNotificationFactory : NotificationServiceFactory
{
    public override IMessageSender CreateSender()
    {
        return new SmsSender();
    }
}