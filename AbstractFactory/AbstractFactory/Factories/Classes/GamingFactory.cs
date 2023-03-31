using AbstractFactory.Entities.Classes;

namespace AbstractFactory.Factories.Classes;

public class GamingFactory : AbstractFactory
{
    public IEntityCreator CreateMouse()
    {
        return new GamingMouse();
    }

    public IEntityCreator CreateKeyboard()
    {
        return new GamingKeyboard();
    }
}