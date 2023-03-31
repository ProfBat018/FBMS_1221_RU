namespace AbstractFactory.Entities;

public interface IMouse : IEntity
{
    public MouseDPI MouseDpi { get; set; }
}