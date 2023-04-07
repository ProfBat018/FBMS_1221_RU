namespace FactoryMethod.Factories.Classes;

public class GroceryFactory : IGroceryFactory
{
    public IProduct CreateProduct()
    {
        return new Tomato()
        {
            Name = "Zire pomidoru"
        };
    }
}


