#region WithoutSynchronization

/*
void Increment(object x)
{
    int j = (int)x;
    for (int i = 0; i < 10; i++)
    {
        j++;
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} - {j}");
    }
}

Thread th1 = new(Increment);
Thread th2 = new(Increment);

th1.Start(1);
th2.Start(10);
*/

#endregion

#region WithSynchronization
/*
object lockObject = new();

void Increment(object x)
{
    lock (lockObject)
    {
        int j = (int)x;

        for (int i = 0; i < 10; i++)
        {
            j++;
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} - {j}");
        }
    }
}

Thread th1 = new(Increment);
Thread th2 = new(Increment);

th1.Start(1);
th2.Start(10);
*/
#endregion

#region WithMutex
/*
void Increment(object x)
{
    Mutex mutex = new(false, "MyMutex");
    mutex.WaitOne();

    int j = (int)x;
    
    for (int i = 0; i < 10; i++)
    {
        j++;
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} - {j}");
    }
    mutex.ReleaseMutex();
}

Thread th1 = new(Increment);
Thread th2 = new(Increment);

th1.Start(1);
th2.Start(10);

*/

#endregion

#region WithSemaphore
/*
Semaphore semaphore = new(2, 4);

void Increment(object x)
{
    semaphore.WaitOne();

    int j = (int)x;

    for (int i = 0; i < 10; i++)
    {
        j++;
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} - {j}");
    }
    semaphore.Release();
}

Thread th1 = new(Increment);
Thread th2 = new(Increment);

th1.Start(1);
th2.Start(10);
*/
#endregion

