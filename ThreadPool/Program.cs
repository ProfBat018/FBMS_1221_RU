// ManualResetEvent resetEvent = new(false);
AutoResetEvent resetEvent = new(false);
using CountdownEvent countdownEvent = new(2); // InitialCount - это начальное значение счетчика
Semaphore semaphore = new(1, 1); // 2 - это максимальное количество потоков, 2 - это начальное значение счетчика

void Increment(object x)
{
    semaphore.WaitOne();
    int j = (int)x;
    Console.WriteLine($"IsBackground: {Thread.CurrentThread.IsBackground}\n" +
                      $"Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(10);
        Console.WriteLine(j);
        j++;
    }
    
    semaphore.Release();
    //// Уберите комментарии для проверки работы CountdownEvent
    countdownEvent.Signal(); // уменьшает счетчик на 1

    //// Уберите комментарии для проверки работы ManualResetEvent и AutoResetEvent
    // resetEvent.Set();
    // Если не вызвать метод Set, то главный поток будет ждать завершения работы потоков
}

// Работа с ThreadPool проходит через метод QueueUserWorkItem
// Тут надо сказать главному потоку что он должен ждать завершения работы потоков


#region FirstPart
// ThreadPool.QueueUserWorkItem(Increment, 5);
// Thread th1 = new(Increment);
// th1.Start(5);

//// Так делать костыльно, но работает
// Thread.Sleep(1000);

#endregion

#region SecondPart
/*
ThreadPool.QueueUserWorkItem(Increment, 5);
resetEvent.WaitOne();

resetEvent.Reset();

ThreadPool.QueueUserWorkItem(Increment, 20);
resetEvent.WaitOne();
*/
#endregion

#region ThirdPart

// CountdownEvent - это событие, которое срабатывает когда счетчик достигает нуля


ThreadPool.QueueUserWorkItem(Increment, 5);
ThreadPool.QueueUserWorkItem(Increment, 10);
countdownEvent.Wait();


// countdownEvent.Reset();
// ThreadPool.QueueUserWorkItem(Increment, 20);
// countdownEvent.Wait();


#endregion
