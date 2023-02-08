// Reflection 

// C# - OOP language
// Type - class

using System.Reflection; // Namespace, который реализует рефлексию
using System.Text;

#region Type

//Employee a = new();

//Type type = a.GetType();

/*
PropertyInfo[] props = type.GetProperties();

foreach (var item in props)
{
    Console.WriteLine(
        $"Name: {item.Name}\n" +
        $"Type: {item.PropertyType}\n" +
        $"Declaring type: {item.DeclaringType}\n");
}
*/

/*
MethodInfo[] methods = type.GetMethods();

foreach (var item in methods)
{
    Console.WriteLine(
        $"Name: {item.Name}\n" +
        $"Return Param: {item.ReturnParameter}\n");
}
*/

#endregion

#region Example
/*
Console.WriteLine("Enter name: ");
var name = Console.ReadLine();

Console.WriteLine("Enter Surname: ");
var surname = Console.ReadLine();

Console.WriteLine("Enter age: ");
var age = Convert.ToInt32(Console.ReadLine());

Person a = new()
{
    Name = name,
    Surname = surname,
    Age = age
};
*/

Person a = new();

foreach (var item in a.GetType().GetProperties())
{
    Console.WriteLine($"Enter {item.Name}: ");
    if (item.PropertyType == typeof(string))
    {
        a.GetType().GetProperty(item.Name).SetValue(a, Console.ReadLine());
    }
    else
    {
        a.GetType().GetProperty(item.Name).SetValue(a, Convert.ToInt32(Console.ReadLine()));
    }
}

Console.WriteLine(a);

#endregion


class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public override string ToString()
    {
        StringBuilder res = new();
        foreach (var item in this.GetType().GetProperties())
        {
            res.Append($"{item.Name}: {item.GetValue(this)}\n");
        }
        return res.ToString();
    }
}