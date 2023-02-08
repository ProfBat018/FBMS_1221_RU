#region Part1 

/*
 
IWritable a = new Person();
IWritable b = new Cat();

using FileStream fs = new("data.txt", FileMode.OpenOrCreate);
using StreamWriter se = new(fs);



interface IWritable
{

}

class Person : IWritable
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }
}

class Cat : IWritable
{
    public string? Name { get; set; }
    public string? Breed { get; set; }
}
*/


#endregion

#region Part2

//IWritable writable = new Person();

//writable.WriteToFile();


//var person = new Person();
//// Interfaces do not contain data... 

//interface IWritable
//{
//    public void WriteToFile();
//}

//class Person : IWritable
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }

//    public void WriteToFile()
//    {
//        using FileStream fs = new("people.txt", FileMode.OpenOrCreate);
//        using StreamWriter sw = new(fs);

//        sw.Write(Name + '\n' + Surname + '\n');
//    }
//}

//class Cat : IWritable
//{
//    public string Name { get; set; }
//    public string Breed { get; set; }
//    public UInt16 Lives { get; set; } = 9;

//    public void WriteToFile()
//    {
//        using FileStream fs = new("cats.txt", FileMode.OpenOrCreate);
//        using StreamWriter sw = new(fs);

//        sw.Write(Name + '\n' + Breed + '\n' + Lives + '\n');
//    }
//}

#endregion

//foo(1, 2, 3, 4, 5, 6, 7, 8);

//void foo(params int[] args)
//{
//    foreach (var item in args)
//    {
//        Console.WriteLine(item);
//    }
//}

#region Part3

//Console.WriteLine("");

//Car car = new();
//IMoveable moveable = car;

//interface IMoveable
//{
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public string Year { get; set; }
//    public void Move();
//}

//class Car : IMoveable
//{
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public string Year { get; set; }

//    public void Move()
//    {
//        throw new NotImplementedException();
//    }
//}

//class Airplane : IMoveable
//{
//    public string Make { get; set; }
//    public string Model { get; set; }
//    public string Year { get; set; }

//    public void Move()
//    {
//        throw new NotImplementedException();
//    }
//}


#endregion

#region Part4 

Car a = new();

IMoveable b = a;

b.Move();


interface IMoveable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public void Move()
    {
        Console.WriteLine("Move");
    }
}

class Car : IMoveable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
}

class Airplane : IMoveable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
}


#endregion

