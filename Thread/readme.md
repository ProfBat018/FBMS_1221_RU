# Тема урока. Класс Process, Thread

### class Thread - это самый низкий уровень, на котором можно создать поток

его конструктор принимает два типа делегата, которые называются:
* ThreadStart
* ParameterizedThreadStart

## Минусы класса Thread

По сути я могу создать поток только под одну функцию.
Если я хочу поменять его функцию мне надо его пересоздать.
На это уходит много ресурсов.

```csharp
void sayHello()
{
    Console.WriteLine("Hello World!");
}

void sayBye()
{
    Console.WriteLine("Bye World!");
}

Thread th = new(sayHello);
th.Start();

th = new Thread(sayBye);
th.Start();

```

Хоть и переменная та же, но поток уже новый и он запускает другую функцию.
Это очень плохо с точки зрения ресурсов, но очень хорошо с точки зрения производительности самой программы.

