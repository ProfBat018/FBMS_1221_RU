
using System.Diagnostics;

var p1 = new Person()
{
    Name = "Elvin",
    Surname = "Azimov",
    Age = 21
};

// Shallow copy

var p2 = p1.Clone() as Person;
Console.WriteLine(p2.Name);
p1.Name = "Samir";
Console.WriteLine(p2.Name);



class Person : ICloneable
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    
    public object Clone() => new Person()
    {
        Name = this.Name,
        Surname = this.Surname,
        Age = this.Age
    };
    
}


