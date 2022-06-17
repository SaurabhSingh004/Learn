namespace VisitorPattern.Demo;

internal class MarketingNotificationSender : INotificationSender
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void Send(string message)
    {
        Console.WriteLine($"Notification sent: {message}");
    }
}