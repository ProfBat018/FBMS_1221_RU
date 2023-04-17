namespace Memento;

// Класс Опекун не зависит от класса Конкретного Снимка. Таким образом, он не имеет
// доступа к состоянию создателя, хранящемуся внутри снимка. Он работает со
// всеми снимками через базовый интерфейс Снимка.

class Caretaker
{
    private Dictionary<string, IMemento> _snapshots = new();

    public void GetSnapshots()
    {
        var i = 0;
        foreach (var item in _snapshots)
        {
            Console.WriteLine($"{i}. key:{item.Key}\t value:{item.Value.State}");
            i++;
        }
    }

    public IMemento GetConcreteSnapshot(int i)
    {
        return _snapshots.ElementAt(i).Value;
    }
    
    public void AddSnapshot(IMemento? memento)
    {
        if (memento != null)
        {
            _snapshots.Add(Guid.NewGuid().ToString(), memento);
            return;
        }

        throw new ArgumentNullException(nameof(memento));
    }
}