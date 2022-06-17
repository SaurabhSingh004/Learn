using VisitorPattern.Demo;

IVisitor emailVisitor = new EmailVisitor();
IVisitor textVisitor = new TextVisitor();
IVisitor websocketVisitor = new WebsocketVisitor();

INotificationSender notificationSender1 = new InvoiceNotificationSender();
notificationSender1.Accept(emailVisitor);
notificationSender1.Send("Invoice");

INotificationSender notificationSender2 = new MarketingNotificationSender();
notificationSender2.Accept(emailVisitor);
notificationSender2.Accept(textVisitor);
notificationSender2.Accept(websocketVisitor);
notificationSender2.Send("Marketing");