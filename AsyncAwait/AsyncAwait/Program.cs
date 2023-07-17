#region Part1
/*
Console.WriteLine($"This is code from main Thread: {Thread.CurrentThread.ManagedThreadId}");

var task = Task.Run(() =>
{
    Console.WriteLine($"This is code from Task 1: {Thread.CurrentThread.ManagedThreadId}");
    Enumerable.Range(1, 10).ToList().ForEach(i =>
    {
        Console.WriteLine($"Task 1: {i}");
        Thread.Sleep(100); // симуляция длительной операции
    });

    var task2 = Task.Run(() =>
    {
        Console.WriteLine($"This is code from Task 2: {Thread.CurrentThread.ManagedThreadId}");
        Enumerable.Range(1, 10).ToList().ForEach(i =>
        {
            Console.WriteLine($"Task 2: {i}");
            Thread.Sleep(100); // симуляция длительной операции
        });
    });
    task2.Wait();
});

task.Wait(); // Так как Main поток, завершится раньше чем Task, то мы должны дождаться завершения Task

// WaitAll() отличается от Wait() тем, что принимает массив Task и ждет завершения всех Task
*/
#endregion

#region Part2
/*

Task DoWork()
{
    Enumerable.Range(1, 10).ToList().ForEach(x =>
    {
        Console.WriteLine($"DoWork: {x}");
        Thread.Sleep(100);
    });
    return Task.CompletedTask;
}

Console.WriteLine("Main thread started");

// GetAwaiter() - возвращает объект, который позволяет отслеживать завершение Task

var res = DoWork().GetAwaiter();

res.OnCompleted(() =>
{
    Console.WriteLine("DoWork completed");
});

Console.WriteLine("Main thread completed");
*/
#endregion

#region Part3
/*
async Task DoWork()
{
    Enumerable.Range(1, 30).ToList().ForEach(x =>
    {
        Console.WriteLine($"DoWork: {x}");
        Thread.Sleep(100);
    });
}

async Task<List<int>> DoWork2()
{
    return Enumerable.Range(1, 30).ToList();
}

// Console.WriteLine("Main thread started");
// await DoWork(); // Подожди, пока DoWork завершится
// Console.WriteLine("Main thread completed");


// Console.WriteLine("Main thread started");
List<int> res = await DoWork2();
res.ForEach(x => Console.WriteLine(x));
*/
#endregion

#region Part4

/*
using System.Diagnostics;
Thread th1 = new(() =>
{
    Console.WriteLine("My own thread started");
    Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}" +
                      $"Is thread pool thread: {Thread.CurrentThread.IsThreadPoolThread}" +
                      $"Is background thread: {Thread.CurrentThread.IsBackground}");
});


th1.Start();

Thread.Sleep(1000);

ThreadPool.QueueUserWorkItem((state) =>
{
    Console.WriteLine("Threadpool thread started");
    Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}" +
                      $"Is thread pool thread: {Thread.CurrentThread.IsThreadPoolThread}" +
                      $"Is background thread: {Thread.CurrentThread.IsBackground}");
});

*/
#endregion


#region Part5


#endregion
