using Observer.Interfaces;

namespace Observer.Classes;

public class Subject : ISubject
{
    public ObjectState State { get; set; } = 0;
    
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        Console.WriteLine($"{observer.GetType().Name}: Attached an observer.");
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine($"{observer.GetType().Name}: Detached an observer.");
    }

    public void Notify()
    {
        Console.WriteLine("Notifying observers...");

        foreach (var observer in _observers)
        {
            Console.WriteLine($"{observer.GetType().Name}: Notified an observer.");
            observer.Update(this);
        }
    }
}