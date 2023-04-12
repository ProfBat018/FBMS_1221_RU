namespace Decorator.Classes;


public class Message 
{
    public string Title { get; set; }
    public string Body { get; set; }

    public virtual void Send()
    {
        Console.WriteLine("This is base message realization");
    }
}