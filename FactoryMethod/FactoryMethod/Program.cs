using System.Threading.Channels;
using FactoryMethod;
using FactoryMethod.Factories.Classes;

IGroceryFactory groceryFactory = new GroceryFactory();

var p1 = groceryFactory.CreateProduct();


Console.WriteLine(p1.Name);