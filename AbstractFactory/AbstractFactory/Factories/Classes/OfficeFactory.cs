namespace AbstractFactory.Factories.Classes;

public class OfficeFactory
{
    public IEntityCreator CreateMouse()
    {
        return new OfficeMouse();
    }

    public IEntityCreator CreateKeyboard()
    {
        return new OfficeKeyboard();
    }
}