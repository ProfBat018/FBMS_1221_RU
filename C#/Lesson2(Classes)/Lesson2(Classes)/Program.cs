#region Part1

// var person = new Person();

// Person person = new();

// Person person = new Person();



//var person = new Person()
//{
//    name = "Elvin",
//    surname = "Azimov",
//    age = 21
//};


//class Person
//{
//    public string name;
//    public string surname;
//    public int age;
//}

#endregion

#region Part2



//var a = new Person()
//{
//    Age = 21
//};

//class Person
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }

//    private int age;
//    public int Age 
//    {
//        get => age;
//        set 
//        {
//            if (value > 0)
//            {
//                age = value;
//            }
//            else
//            {
//                throw new InvalidOperationException();
//            }
//        }
//    }
//}

#endregion

#region lambda

//string name = "Elvin";

//char res = name.First(x => x == 'v');

//Console.WriteLine(res);

#endregion

#region Property types

//class Person
//{
//// auto property
//public int MyProperty { get; set; }

//// Full property

//private int myVar;
//public int MyProperty
//{
//	get { return myVar; }
//	set { myVar = value; }
//}
//}

#endregion

#region SettersandGetters


//Person a = new()
//{
//    Name = "Elvin",
//    Surname = "Azimov",
//    BirthDate = DateTime.Parse("11/16/2001")
//};

//Console.WriteLine(a);


//class Person
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public DateTime BirthDate { get; init; }
//    public int Age { get =>  DateTime.Now.Year - BirthDate.Year; }


//    public override string ToString()
//    {
//        return
//            $"Name: {Name}\n" +
//            $"Surname: {Surname}\n" +
//            $"Age: {Age}\n";
//    }
//}


#endregion



//var a = new Person();
//var b = new Person();
//var c = new Person();

//Console.WriteLine(a.Id);
//Console.WriteLine(b.Id);
//Console.WriteLine(c.Id);

//{
//    var d = new Person();
//    Console.WriteLine(d.Id);
//}
//var f = new Person();
//Console.WriteLine(f.Id);

//class Person
//{
//    private static int _id = 0;
//    public int Id { get; private set; }
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public DateTime BirthDate { get; init; }
//    public int Age { get => DateTime.Now.Year - BirthDate.Year; }

//    public Person()
//    {
//        Id = ++_id;
//    }

//    public override string ToString()
//    {
//        return
//            $"Id: {Id}\n" +
//            $"Name: {Name}\n" +
//            $"Surname: {Surname}\n" +
//            $"Age: {Age}\n";
//    }
//}



//A obj = new(10);

//Console.WriteLine(obj.b);

//class A
//{
//    public const int a = 1;

//    public readonly int b;

//    public A(int value)
//    {
//        b = value; 
//    }
//}


