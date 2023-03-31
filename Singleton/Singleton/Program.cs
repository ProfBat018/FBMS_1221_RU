using System.Threading.Channels;

var instance = MySingleton.GetInstance();
var instance2 = MySingleton.GetInstance();
var instance3 = MySingleton.GetInstance();

var instance4 = new MySingleton() { Name = "Other instance" };

    Console.WriteLine($"{instance.Name}\t {instance.GetHashCode()}");
    Console.WriteLine($"{instance2.Name}\t {instance2.GetHashCode()}");
    Console.WriteLine($"{instance3.Name}\t {instance3.GetHashCode()}");
    Console.WriteLine($"{instance4.Name}\t {instance4.GetHashCode()}");

public class MySingleton
{
    private static MySingleton? _instance;
    public string Name { get; set; }

    public static MySingleton GetInstance()
    {
        if (_instance == null)
            _instance = new MySingleton() { Name = "Hello"};
        return _instance;
    }
}


