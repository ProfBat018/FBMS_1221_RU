namespace AbstractFactory.Entities;

public interface IEntity
{
    public string Make { get; set; }
    public string Model { get; set; }
    public DateTime Year { get; set; }
}