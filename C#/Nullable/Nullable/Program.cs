/*
    Generic - Template in C++.
    Generic - Обобщения.
    Одна из главных причин обощений - это boxing & unboxing.

    ! - null-forgiving operator. Унарный оператор
        Если поставить перед объектом, то считается как not,
        Если поставить после объекта, то считается как not nullable

    ? - null condition operator. унарный оператор.
        используется в двух случаях. 
        1. После типа данных, когда я оюъявляю nullable type. 
        2. После объкта, когда я проверяю на null. 

    ?? and ??= - Null coleascing operator. Бинарный оператор  
    ??= в отличии от null conditional operator, данный оператор работает только в случае если элемент null.
    ?? если объект не null то работает правая сторона. 
 */


#region null-forgiving 

#region Part1

//MyClass? obj = new();

////Console.WriteLine(obj.Name!.Length);


//class MyClass
//{
//    public string? Name { get; set; }
//}

#endregion

#region Part2

//string? name = null;

//Console.WriteLine(name?.Length);

#endregion

#endregion

#region Null coleascing 

//string? name = null;

//Console.WriteLine(name ?? "Elvin");

//name ??= "Elvin";

//Console.WriteLine(name);

//int? a = null;

//Console.WriteLine(a ?? 3);
#endregion

#region Null-Condition

//MyClass? a = new() { };

////a.foo();
//Console.WriteLine(a.Name);
//a.Name?.Equals("Elvin");


//class MyClass 
//{
//    public string? Name { get; set; }
//    public void foo()
//    {
//        Console.WriteLine("Foo");
//    }
//}

#endregion

#region ParentalAndChild

//Person[] arr = new Person[2] {new Teacher(), new Student()};

//Teacher teacher = arr[0];


//class Person { }
//class Teacher : Person { }
//class Student : Person { }

#endregion
