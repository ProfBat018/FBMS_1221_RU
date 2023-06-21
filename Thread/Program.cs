using System.Diagnostics;
using System.Threading.Channels;

#region ThreadStart

/*

void sayHello()
{
    Thread.Sleep(3000);
    Console.WriteLine("Hello World!");
}

// ThreadStart ts = new(sayHello);
// Thread th = new(ts);

Thread th = new(sayHello);
th.Start();

Console.WriteLine($"Name: {th.Name}");
Console.WriteLine($"Id: {th.ManagedThreadId}");
Console.WriteLine($"Priority: {th.Priority}");
Console.WriteLine($"State: {th.ThreadState}");
Console.WriteLine($"Status: {th.IsAlive}");
Console.WriteLine($"Status: {th.IsBackground}");
*/

#endregion

#region ParameterizedThreadStart

// void sayMyName(object name)
// {
//     Console.WriteLine($"{name}, you're god damn right!");
// }
//
//
// ParameterizedThreadStart pts = new(sayMyName);
// Thread th = new(pts);
// th.Start("Heisenberg");

#endregion

#region MaxStackSize

void sayHello()
{
    Console.WriteLine("Hello World!");
}

Thread th = new(sayHello, 4096);

// По умолчанию в C#, Stack весит 4 MB, если система 64 битная, и 1 MB, если 32 битная.
// Если вам нужно больше, то можно указать в конструкторе Thread.


#endregion