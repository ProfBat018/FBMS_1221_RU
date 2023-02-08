/*
    Exceptions - Исключения.
    
	Зачем нужны исключения ?

	Чтобы программа не падала и работала дальше. 
	Но не все так просто.

	Она также очень нужна разработчикам, чтобы понимать в чем проблема.
*/


#region Example1


//bool find_even(int number)
//{
//       return number % 2 == 0 ? true : throw new Exception($"{number} is not even");
//}

//try
//{
//    find_even(1);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Console.WriteLine("End of program");

#endregion

#region ApplicationVSSystem
/*
ArgumentException ex1 = new();

ApplicationException ex2 = new();

Exception ex = new();
*/

#endregion

#region StackTrace

/*
void foo()
{
    throw new Exception("From foo");
}

void foo2()
{
	try
	{
		foo();
	}
	catch (Exception)
	{
		throw;
	}
}


void foo3()
{
	try
	{
		foo2();
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
		Console.WriteLine(ex.StackTrace);
	}
}


foo3();

*/


#endregion


void foo()
{
	throw new Exception("Test");
}
try
{
	foo();
}
catch (Exception ex) when (ex.Message == "Test") // Exception filtering
{
	Console.WriteLine(ex.Message);
}


