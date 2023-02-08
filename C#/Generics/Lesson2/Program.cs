#region Example1

//FileService<Maga> service = new(new Maga());

//service.SaveToFile(@"C:\Users\elvin\Desktop\test2.txt");



//class Maga
//{
//    public override string ToString()
//    {
//		return "Maga";
//    }
//}



//class FileService<T>
//{
//	public T Data { get; private set; }

//	public FileService(T data)
//	{
//		Data = data;
//	}

//	public void SaveToFile(string path)
//	{
//		using FileStream fs = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
//		using StreamWriter sw = new(fs);

//		sw.Write(Data.ToString());
//	}


//}

#endregion

#region Example2

/*
MyClass a = new();


a.foo<Maga>();

class Maga { }

class MyClass
{
    public void foo<T>() where T : class, new()
    {
        Console.WriteLine("foo");
    }
}
*/
#endregion

