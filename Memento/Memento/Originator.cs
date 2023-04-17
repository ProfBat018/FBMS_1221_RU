namespace Memento;

// Класс Originator содержит некоторое важное состояние, которое может со временем
// меняться. Он также объявляет метод сохранения состояния внутри снимка и метод
// восстановления состояния из него.
class Originator
{
    // Для удобства состояние создателя хранится внутри одной переменной.
    private string _state;

    public string State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine("State changed: " + _state);
        }
    }

    // Бизнес-логика Создателя может повлиять на его внутреннее состояние.
    // Поэтому клиент должен выполнить резервное копирование состояния с помощью
    // метода save перед запуском методов бизнес-логики.
    public IMemento Save()
    {
        return new ConcreteMemento(_state);
    }

    // Восстановление состояния Создателя из объекта Memento.
    public void Restore(Caretaker caretaker)
    {
        caretaker.GetSnapshots();
        Console.WriteLine($"Select snapshot:");
        int selection;
        var check = Int32.TryParse(Console.ReadLine(), out selection);

        if (check)
        {
            _state = caretaker.GetConcreteSnapshot(selection).State;
            Console.WriteLine("State restored to: " + _state);
            return;
        }
        throw new ArgumentException("Incorrect input");
    }
}
