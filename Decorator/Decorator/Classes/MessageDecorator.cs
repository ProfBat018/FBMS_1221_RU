using System.Threading.Channels;

namespace Decorator.Classes;

public abstract class MessageDecorator : Message
{
    protected Message message;
  
    public MessageDecorator(Message message)
    {
        this.message = message;
    }
    public override void Send()
    {
        if (message != null)
        {
            message.Send();
        }
        else
        {
            base.Send();
        }
    }
}

