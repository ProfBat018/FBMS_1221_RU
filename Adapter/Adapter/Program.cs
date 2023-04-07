XmlAdaptee xmlAdaptee = new XmlAdaptee();
JsonAdapter jsonAdapter = new JsonAdapter(xmlAdaptee);

xmlAdaptee.XmlMethod();
jsonAdapter.GetAdapteeMethod();


class XmlAdaptee : IAdaptee
{
    public void XmlMethod()
    {
        Console.WriteLine("XmlMethod");
    }
}

class BinaryAdaptee : IAdaptee
{
    public void BinaryMethod()
    {
        Console.WriteLine("BinaryMethod");
    }
}


class JsonAdapter : ITarget
{
    private readonly IAdaptee _adaptee;

    public JsonAdapter(IAdaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public void GetAdapteeMethod()
    {
        Console.WriteLine($"{_adaptee.GetType().Name} is adapted to Json");
    }
}

internal interface IAdaptee
{
    
}

internal interface ITarget
{
}



