namespace AbstractFactory.Entities.Classes;

public class Keyboard : IKeyboard
{
    public string Make { get; set; }
    public string Model { get; set; }
    public DateTime Year { get; set; }
    public SwitchType SwitchType { get; set; }
    public KeyboardSize KeyboardSize { get; set; }
}