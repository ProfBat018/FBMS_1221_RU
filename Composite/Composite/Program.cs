
enum Order
{
    High = 1,
    Middle = 2,
    Low = 3
}

class Composite
{
    private Dictionary<Order, IPart> Nodes { get; set; } 
    
    public void Add(IPart part)
    {
        Nodes.Add(part);
    }

    public void Remove(IPart part)
    {
        Nodes.Remove(part);
    }
}


interface IPart
{
    public IPart Previous { get; set; }
    public IPart Next { get; set; }
    public string Name { get; set; }
}


class Engine : IPart
{
    public IPart Previous { get; set; }
    public IPart Next { get; set; }
    public string Name { get; set; }
}

class CrankShaft : IPart
{
    public IPart Previous { get; set; }
    public IPart Next { get; set; }
    public string Name { get; set; }
}

class SparkPlug : IPart
{
    public IPart Previous { get; set; }
    public IPart Next { get; set; }
    public string Name { get; set; }
}


