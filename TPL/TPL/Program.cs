#region First

/*
Task.Run(() =>
{
    int a = 0;
    for (int i = 0; i < 1000; i++)
    {
        a++;
    }
    Console.WriteLine($"This is the first thread. {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine(a);
});
Console.WriteLine($"This is the main thread. {Thread.CurrentThread.ManagedThreadId}");
*/
/*
var task = Task.Run(() =>
{
    Console.WriteLine($"This is the first thread. {Thread.CurrentThread.ManagedThreadId}");
    Enumerable.Range(1, 10).ToList().ForEach(i =>
    {
        Console.WriteLine($"Task 1: {i}");
        Thread.Sleep(100); 
    });
});


Console.WriteLine($"This is the main thread. {Thread.CurrentThread.ManagedThreadId}");
*/

#endregion

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PersonRepo.Data.DbContexts;


    /*
using PeopleDbContext context = new();

var res = context.People.ToListAsync();

var people = res.GetAwaiter().GetResult();

people.ForEach(p => Console.WriteLine(p.Name));
*/

/*
HttpClient client = new();
var res= client.GetAsync("https://google.com");

HttpResponseMessage responseMessage = res.GetAwaiter().GetResult();

var content = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

Console.WriteLine(content);
*/


/*
HttpClient client = new();
var res = await client.GetAsync("https://google.com");
var content = await res.Content.ReadAsStringAsync();

Console.WriteLine(content);
*/




