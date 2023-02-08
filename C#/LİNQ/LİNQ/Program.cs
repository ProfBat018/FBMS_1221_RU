#region ExtensionMethod
/*
// Extension method - метод расширение. 
// Extension method - это всего лишь синтактический сахар

var name = "Elvin";

bool res = name.isElvin();
//bool res = StringExtension.isElvin(name);

Console.WriteLine(res);


public static class StringExtension
{
    public static bool isElvin(this string text)
    {
        return text.ToLower() == "elvin";
    }
}
*/
#endregion

#region LINQ
// Language Integrated Query.
// LINQ to Objects. Это то что мы прхожим сейчас. 
// LINQ to SQL
// LINQ to Entity
// Parallel LINQ
// LINQ to DataSet

#region Built-in-Where

/*
var nums = new List<int>() { 1, 2, 3, 4, 5 };

var res = nums.Where(num => num % 2 == 0).ToList();

foreach (var item in res)
{
    Console.WriteLine(item);
}

*/


#endregion

#region MyWhere

/*
using System.Globalization;
using System.Linq.Expressions;

var nums = new List<int>() { 1, 2, 3, 4, 5 };

var res = nums.MyWhere(x => x % 2 == 0);

MyLINQExtensions.MyWhere(nums, x => x % 2 == 0);
*/

public static class MyLINQExtensions
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> collection, Predicate<T> predicate)
    {
        List<T> res = new();

        foreach (var item in collection)
        {
            if (predicate(item))
            {
                res.Add(item);
            }
        }
        return res;
    }
}

#endregion

#endregion