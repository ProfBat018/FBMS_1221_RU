using System.Threading.Channels;
using CodeFirst.Data.DbContexts;
using CodeFirst.Data.Models;

Console.WriteLine("Foo");


using var context = new AcademyDbContext();

List<Person> people = new List<Person>()
{
    new Person() { Name = "Elvin", Surname = "Azimov", Age = 21 },
    new Person() { Name = "Emil", Surname = "Moryakov", Age = 17 },
    new Person() { Name = "Magamed", Surname = "Babayev", Age = 16 },
    new Person() { Name = "Farhad", Surname = "Zulfuqarov", Age = 19 },
    new Person() { Name = "Murad", Surname = "Orucov", Age = 16},
    new Person() { Name = "Magomed", Surname = "Quluyev", Age = 22 },
    new Person() { Name = "Mamed", Surname = "Panahov", Age = 24 },
    new Person() { Name = "Lala", Surname = "Mamedova", Age = 24 },
    new Person() { Name = "Laman", Surname = "Aliyeva", Age = 26 }
};

// context.People.AddRange(people);
// context.SaveChanges();


//// Projection

// var peopleRes = context.People.Select(x => x.Name);
//
// foreach (var item in peopleRes)
// {
//     Console.WriteLine(item);
// }
//

// var p1 = context.People.FirstOrDefault(x => x.Name == "Elvin");


// var p2 = context.People.Where(x => x.Id > 3).Select(x => x.Name);

/*
    select Name from People where Id > 3 
*/

// foreach (var item in p2)
// {
//     Console.WriteLine(item);
// }


// var p3 = context.People.All(x => x.Id >= 1);
// var p4 = context.People.Select(x => new {x.Name, x.Surname, x.Age });

// var p3 = context.People.AsQueryable();

// foreach (var item in p3)
// {
    // Console.WriteLine(item);
// } 

// var p5 = context.People.Min(x => x.Age);
// var p6 = context.People.Where(x => x.Age == p5);
//
// foreach(var item in p6)
// {
//     Console.WriteLine(item);
// }


// var p7 = context.People.GroupBy(x => x.Age).Min(x => x.Key);
// Console.WriteLine(p7);

// var person = context.People.FirstOrDefault(x => x.Id == 1);
//
// var newPerson = new Person() { Name = person.Name, Surname = person.Surname, Age = person.Id };
//
// var p8 = context.People.Add(newPerson);
//
// context.SaveChanges();


foreach (var item in context.People.AsQueryable())
{
    Console.WriteLine(item);
}
