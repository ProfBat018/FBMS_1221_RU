using Observer.Classes;

namespace Observer.Interfaces;

public interface ISubject
{
    public ObjectState State { get; set; }
    void Attach(IObserver observer);

    void Detach(IObserver observer);

    void Notify();
}