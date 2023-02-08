// Serialization - конвертация объекта в поток из байтов для последующего использования. 

#region Binary

/*
 Pros:
    1. Binary serialization is very fast
 Cons:
    1. Binary serialization is working on one system.
    2. Binary serialization is not possible to read by person because of he doesn't consist understanable chars.
    3. We can't edit binary file. 
 */

#region Serialization

//using System.Runtime.Serialization.Formatters.Binary;

//Person p1 = new()
//{
//    Name = "Elvin",
//    Surname = "Azimov",
//    Age = 21
//};


//using FileStream fs = new("data.bin", FileMode.OpenOrCreate);

//BinaryFormatter formatter = new(); // Class for binary Serializing

//formatter.Serialize(fs, p1);

#endregion

#region DeSerialization

//using System.Runtime.Serialization.Formatters.Binary;

//using FileStream? fs = new("data.bin", FileMode.Open);

//BinaryFormatter? formatter = new();

//Person? person = formatter?.Deserialize(fs) as Person;

//Console.WriteLine(person);

#endregion

//// обязательный атрибут, для класса. Он нужен для бинарной сернриализации

/*
[Serializable]
class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return
            $"{Name}\n" +
            $"{Surname}\n" +
            $"{Age}\n";
    }
}
*/
#endregion

#region XML
//using System.Xml.Serialization;

/*
    XML serialization must have default constructor. 
    Serializable class must be public.

    Pros: 
        1. Readability.
        2. Editable
    Cons:
        There are no cons in my opinion :)
 */

#region Serialization

//Person p1 = new("Elvin", "Azimov", 21);

//using FileStream fs = new("data.xml", FileMode.OpenOrCreate);

////XmlSerializer xmlSerializer = new(typeof(Person));
//XmlSerializer xmlSerializer = new(p1.GetType());

//xmlSerializer.Serialize(fs, p1);

#endregion

#region DeSerialization

//using FileStream fs = new("data.xml", FileMode.OpenOrCreate);

//XmlSerializer xmlSerializer = new(typeof(Person));

//var person = xmlSerializer.Deserialize(fs) as Person;

//Console.WriteLine(person);

#endregion


//public class Person
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Age { get; set; }

//    public Person()
//    {

//    }
//    public Person(string? name, string? surname, int age)
//    {
//        Name = name;
//        Surname = surname;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return
//            $"{Name}\n" +
//            $"{Surname}\n" +
//            $"{Age}\n";
//    }
//}

#endregion

#region JSON
using System.Data;
using System.Text.Json;

// JSON - JavaScript Object Notation

/*
    JSON не может хранить больше 5миллионов строк данных.
    JSON самый популярный тип сериализации.
    
*/


#region Serialization


//Person p1 = new()
//{
//    Name = "Elvin",
//    Surname = "Azimov",
//    Age = 21
//};

//using FileStream fs = new("data.json", FileMode.OpenOrCreate);
//JsonSerializer.Serialize<Person>(fs);
////JsonSerializer.Serialize(fs, p1);

#endregion


#region Deserialization

//using FileStream fs = new("data.json", FileMode.Open);

////var person = JsonSerializer.Deserialize(fs, typeof(Person)) as Person;

//var person = JsonSerializer.Deserialize<Person>(fs); // лучший вариант 

//Console.WriteLine(person);



#endregion

//public class Person
//{
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Age { get; set; }
//    public override string ToString()
//    {
//        return
//            $"{Name}\n" +
//            $"{Surname}\n" +
//            $"{Age}\n";
//    }
//}

#endregion