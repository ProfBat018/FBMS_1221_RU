#region ArrowFuncVsAnonym

//void Function() => Console.WriteLine("Hello"); // arrow function

//Action a = () => {
//    Console.WriteLine("Hello");
//};

#endregion

#region Part1

/*
void foo()
{
    Console.WriteLine("Hello");
}

MyDel a = foo;

a();

// Delegate - refrence data type;
public delegate void MyDel();
*/

#endregion

#region AnonymFunction

#region Part1
//MyDel a = delegate () { Console.WriteLine("Hello"); };

//MyDel a = () => Console.WriteLine("Hello");

//a();

//public delegate void MyDel();


#endregion

#region Part2

//MyDel a = delegate (int num1, int num2) { return num1 + num2; };

//MyDel a = (num1, num2) => num1 + num2; // implicit return 

//Console.WriteLine(a(1, 2));

//public delegate float MyDel(int num1, int num2);

#endregion

#endregion

#region Built-in-delegates

#region Action
// Void function without params
//Action a = () => Console.WriteLine("Hello");

#endregion

#region Func
// Always generic class
// First parameters is In parameter. 
// Last parameter is Out parameter. 

//Func<int, bool> a = (num1) => num1 % 2 == 0;
//Console.WriteLine(a(2));

//Func<int, int, int, float> b = (num1, num2, num3) => num1 * num2 * num3;

//var res = b(1, 2, 3);

//Console.WriteLine($"{res.ToString()} {res.GetType().Name}");


#endregion

#region Predicate

//Predicate<string> a = (string name) => name.ToLower() == "elvin";

//Console.WriteLine(a("ELVIN"));


#endregion
#endregion

#region MyPredicate

//MyPredicate<int> a = (int num) => num % 2 == 0;

//Console.WriteLine(a(5));

//delegate bool MyPredicate<in T>(T param);

#endregion

#region MyFunc


//delegate Ret MyFunc<out Ret>();
//delegate Ret MyFunc<in T, out Ret>(T param);
//delegate Ret MyFunc<in T1, in T2, out Ret>(T1 param1, T2 param2);
//delegate Ret MyFunc<in T1, in T2, in T3, out Ret>(T1 param1, T2 param2, T3 param3);


#endregion


//bool foo(string data)
//{
//    return true;
//}

//Func<string, bool> a = foo;
//Predicate<string> b = foo;


