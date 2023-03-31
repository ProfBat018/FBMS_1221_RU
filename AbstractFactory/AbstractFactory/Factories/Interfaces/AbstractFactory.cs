using AbstractFactory.Entities;
using AbstractFactory.Entities.Classes;

namespace AbstractFactory.Factories.Classes;

public interface AbstractFactory
{
    public IEntityCreator CreateMouse();
    public IEntityCreator CreateKeyboard();
}