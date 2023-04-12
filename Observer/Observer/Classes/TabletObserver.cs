using Observer.Interfaces;

namespace Observer.Classes;

public class TabletObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject.State == ObjectState.Tablet)
        {
            Console.WriteLine("TabletObserver: My subject has updated and told me about it.");
        }
    }
}