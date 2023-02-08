//MyStruct a = new();

//a.num1 = 1;
//a.num2 = 2;

//Console.WriteLine(a.num1);
//Console.WriteLine(a.num2);

//struct MyStruct
//{
//    public int num1;
//    public int num2;
//}


//using System.ComponentModel.DataAnnotations;

//class MyClass
//{
//    //public int MyProperty { get; set; }

//    [Required] // Attribute
//    public string? name;
//
//}


//List<int> nums = new();

//nums.Add(1);    


#region NullableExample

//string name = null; // Implicit data type conversion to string? 

//string? name2 = null;


//// string and string? 

//// ? после типа данных - это nullable

//name ??= "Elvin";

//// If name == null, then name = "Elvin"

//Console.WriteLine(name);

#endregion


#region Part1

//A? aObj = null;

//Console.WriteLine(aObj.Name);

//Console.WriteLine(aObj.Age);

#endregion


void foo(params int[] nums)
{

}

#region Part2

// Если вопрос, стоит возле типа данных. В таком случе тип, может явно хранить null.
A? aObj = null; // 0x000000

aObj?.foo(); // if aObj != null : then call func foo

#endregion

class A
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void foo()
    {
        Console.WriteLine("Foo from A");
    }
}


