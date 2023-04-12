using Observer.Interfaces;

namespace Observer.Classes;

public class LaptopObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject.State == ObjectState.Laptop)
        {
            Console.WriteLine("LaptopObserver: My subject has updated and told me about it.");
        }
    }
}