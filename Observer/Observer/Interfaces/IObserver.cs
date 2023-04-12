namespace Observer.Interfaces;

public interface IObserver
{
    void Update(ISubject subject);
}