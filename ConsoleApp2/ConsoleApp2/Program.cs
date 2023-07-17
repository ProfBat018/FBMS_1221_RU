//  async await => Task => Threadpool

using System;
using System.Threading;

for (int i = 0; i < 2; i++)
{
    ThreadPool.QueueUserWorkItem(x =>
    {
        Foo.foo();
    });
}

class Foo{

    public static int i = 0;
    public static void foo()
    {

        for (int j = 0; j < 100; j++)
        {
            Thread.Sleep(100);
            i++;
        }
        Console.WriteLine(i);
    }
}

