using AbstractFactory.Entities;

namespace AbstractFactory.Factories.Classes;

public interface IEntityCreator
{
    public IEntity CreateProduct();
}