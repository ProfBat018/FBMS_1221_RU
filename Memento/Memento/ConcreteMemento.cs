namespace Memento;

// Конкретный снимок содержит инфраструктуру для хранения состояния Создателя.
class ConcreteMemento : IMemento // Конкретный снимок
{
    public string State { get; }
    public DateTime Date { get; }

    public ConcreteMemento(string state)
    {
        State = state;
        Date = DateTime.Now;
    }
        
    // Создатель использует этот метод, когда восстанавливает своё состояние.
    // Остальные методы используются Опекуном для отображения метаданных.

    public override string ToString()
    {
        return $"Date: {Date.ToShortDateString()}\tState: {State}";
    }
}