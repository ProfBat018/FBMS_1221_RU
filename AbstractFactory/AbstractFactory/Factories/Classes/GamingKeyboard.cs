using AbstractFactory.Entities;
using AbstractFactory.Entities.Classes;

namespace AbstractFactory.Factories.Classes;

public class GamingKeyboard : IEntityCreator
{
    public IEntity CreateProduct()
    {
        return new Keyboard() {Make = "Gaming Keyboard"};
    }
}