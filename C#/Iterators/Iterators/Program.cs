/*
    Iterators - Итераторы.
    Итератор - Объект, который хранит в себе указатель на первый 
    объект коллекции и позволяет мне перемещаться по нему.
    
    Рассматриваемые интерфейсы: IEnumerable, Ienumerator
    Новые ключевые слова: yield return 
*/

/*
using System.Collections;


IntArray arr = new();

foreach (var item in arr)
{
    Console.WriteLine(item);
}

class IntArray : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return i + 1;
            if (i == 2)
            {
                yield break;
            }
        }
        Console.WriteLine();

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

*/



