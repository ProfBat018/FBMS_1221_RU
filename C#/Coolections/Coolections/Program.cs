
//object[] arr = new object[4]
//    {
//        1, 
//        1.2f, 
//        2.3, 
//        new string("Elvin"),
//    };


// Types from System.Collections;

#region Arraylist

//using System.Collections;

//ArrayList arr = new() { 1, true, 1.2f, 1.2, "Elvin" };

//int number = (int)arr[0];

//object a = 5;

#endregion

#region GenericList

// Generic - is the same thing as Template in C++

//List<int> arr = new() { 1, 2, 3, 4, 5 };

#endregion

#region Indexer

//MyArr a = new();

//class MyArr
//{
//	public int this[uint index]
//	{
//		get { return this.arr[index]; }
//		set { throw new Exception("You can't change this array"); }
//	}
//    private int[] arr = new int[5] { 1, 2, 3, 4, 5 };
//}

#endregion

#region Ref&Out


#region Ref

// ref = reference
//void add(ref int num)
//{
//    num++;
//}

//int number = 10;

//Console.WriteLine(number);

//add(ref number);
//add(ref number);
//add(ref number);

//Console.WriteLine(number);
#endregion

#region Out

//void AgeEntry(out int age)
//{
//    age = Int32.Parse(Console.ReadLine());
//}

//int age;
//AgeEntry(out age);

//Console.WriteLine(age);

//int number;

//bool res = Int32.TryParse(Console.ReadLine(), out number);

//if (res)
//    Console.WriteLine(number);

#endregion


#endregion

#region StringBuilderPart1

//using System.Text;

////string name = "Elvin";
////name += "Azimov";

////Console.WriteLine(name);

//string name = "Elvin";

//StringBuilder builder = new(name);

//Console.WriteLine(builder.Capacity);

//builder.Append("Azimov");

//Console.WriteLine(builder.Capacity);

//builder.Append("Azimov");
//Console.WriteLine(builder.Capacity);


//string res = builder.ToString();
//Console.WriteLine(res);

#endregion

#region Stack


//List<int> nums = new() { 1, 2, 3, 4, 5 };

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


//Stack<int> ints = new (new int[] {1, 2, 3, 4, 5});

//Console.WriteLine(ints.Peek());
//Console.WriteLine(ints.Peek());
//Console.WriteLine(ints.Peek());

//int a;

//ints.TryPop(out a);

//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}

#endregion

#region Queue

//Queue<int> ints = new(new int[] { 1, 2, 3, 4, 5 });


//ints.Enqueue(6);

//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}

#endregion



