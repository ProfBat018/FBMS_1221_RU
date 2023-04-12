namespace Decorator.Classes;

public class EmailMessage : MessageDecorator
{
    public EmailMessage(Message message) : base(message)
    {
        
    }

    public override void Send()
    {
        Console.WriteLine("Email message sending...");
    }
}