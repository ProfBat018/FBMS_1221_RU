namespace AbstractFactory.Entities.Classes;

public class Mouse : IMouse
{
    public string Make { get; set; }
    public string Model { get; set; }
    public DateTime Year { get; set; }
    public MouseDPI MouseDpi { get; set; }
}