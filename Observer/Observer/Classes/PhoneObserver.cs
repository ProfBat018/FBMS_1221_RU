
using Observer.Interfaces;

namespace Observer.Classes;

public class PhoneObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject.State == ObjectState.Phone)
        {
            Console.WriteLine("PhoneObserver: My subject has updated and told me about it.");
        }
    }
}