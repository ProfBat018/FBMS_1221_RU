using System.Threading.Channels;
using Lesson1;
using Microsoft.EntityFrameworkCore;

using StoreContext context = new();

#region WithoutProjection

//
// var stopWatch = new System.Diagnostics.Stopwatch();
// stopWatch.Start();
//
// var products = context.Product.ToList();
//
// Console.WriteLine(products.Count);
// stopWatch.Stop();
//
// Console.WriteLine(stopWatch.ElapsedMilliseconds);

#endregion
#region WithProjection

// var stopWatch = new System.Diagnostics.Stopwatch();
// stopWatch.Start();
//
// var products = context.Product.Select(x => x.Title);
//
// Console.WriteLine(products.Count);
//
// stopWatch.Stop();
//
// Console.WriteLine(stopWatch.ElapsedMilliseconds);

#endregion


#region WithProjectionAndAsNoTracking

var stopWatch = new System.Diagnostics.Stopwatch();
stopWatch.Start();

var products = context.Product
    .AsNoTracking()
    .Select(x => new {x.Title, x.ProductionDate, x.ExpirationTime });


foreach (var items in products)
{
    Console.WriteLine($"{items.Title}\t{items.ExpirationTime}\t{items.ProductionDate}");
}

stopWatch.Stop();

Console.WriteLine(stopWatch.ElapsedMilliseconds);

#endregion

// Iqueryable - это интерфейс, который реализует IQueryable<T> и IQueryable. По сути он хранит не список, а запрос, который мы можем дополнить



