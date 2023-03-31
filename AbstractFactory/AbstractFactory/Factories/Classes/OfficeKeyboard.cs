using AbstractFactory.Entities;
using AbstractFactory.Entities.Classes;

namespace AbstractFactory.Factories.Classes;

public class OfficeKeyboard : IEntityCreator
{
    public IEntity CreateProduct()
    {
        return new Keyboard() {Make = "Office Keyboard"};
    }
}