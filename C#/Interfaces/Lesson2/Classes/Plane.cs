class Plane
{
    public string Make { get; set; }
    public string Model { get; set; }
    public ushort MaxSpeed { get; set; }

    public void Move()
    {
        Console.WriteLine("Plane moves");
    }
}