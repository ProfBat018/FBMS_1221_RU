namespace AbstractFactory.Entities;

public interface IKeyboard : IEntity
{
    public SwitchType SwitchType { get; set; }
    public KeyboardSize KeyboardSize { get; set; }
}