using AbstractFactory.Entities;
using AbstractFactory.Entities.Classes;

namespace AbstractFactory.Factories.Classes;

public class GamingMouse : IEntityCreator
{
    public IEntity CreateProduct()
    {
        return new Mouse() {Make = "Gaming Mouse"};
    }
}