using AbstractFactory.Entities;
using AbstractFactory.Entities.Classes;

namespace AbstractFactory.Factories.Classes;

public class OfficeMouse : IEntityCreator
{
    public IEntity CreateProduct()
    {
        return new Mouse() { Make = "Office Mouse" };
    }
}
