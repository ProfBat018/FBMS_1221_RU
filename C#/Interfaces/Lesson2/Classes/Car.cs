using Lesson2.Interfaces;

class Car : IMoveable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public ushort MaxSpeed { get; set; }

    //public void Move()
    //{
    //    Console.WriteLine("Car moves");
    //}
}