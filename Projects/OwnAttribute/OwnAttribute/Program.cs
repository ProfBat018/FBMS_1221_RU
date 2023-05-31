using System;
using System.ComponentModel.DataAnnotations;


Person p1 = new();

var props = p1.GetType().GetProperties().ToList();

var propsAttributes = props.Select(x => x.GetCustomAttributesData()).ToList();

foreach(var item in propsAttributes)
{
    foreach(var attr in item)
    {
        Console.WriteLine(attr);
    }
}

class Person
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
}


[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct | AttributeTargets.Method,
    AllowMultiple = true)]
class Aloha : Attribute
{
    public string Data { get; set; }
}



[Aloha(Data = "Class Aloha")]
class Test
{
    public Test()
    {
        Console.WriteLine("Test created");
    }

    [Aloha(Data = "Method Aloha")]
    public void foo()
    {
        Console.WriteLine("Foo");

        var classAttributes = this.GetType().GetCustomAttributesData().ToList();

        var methodAttributes = this.GetType().GetMethod("foo").GetCustomAttributesData().ToList();
        
        foreach (var item in classAttributes)
        {
            Console.WriteLine(item);
        }

        foreach (var item in methodAttributes)
        {
            Console.WriteLine(item);
        }
    }
}


