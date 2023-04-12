namespace Decorator.Classes;


public class LetterMessage : MessageDecorator
{
    public LetterMessage(Message message) : base(message)
    {
        
    }

    public override void Send()
    {
        Console.WriteLine("Letter message sending...");
    }
}