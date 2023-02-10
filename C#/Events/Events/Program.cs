#region Part1


//string nameChanged(string newName)
//{
//    Console.WriteLine($"Name changed to {newName}");
//    return newName;
//}

//Person a = new(nameChanged);

//a.Name = "Elvin";


//public delegate string NameDelegate(string newName);
//class Person
//{
//    public Person(NameDelegate? nameDelegate)
//    {
//        this.nameDelegate = nameDelegate;
//        NameHandler = nameDelegate;
//        NameHandler += (result) =>
//            {
//                Console.WriteLine("Second delegate");
//                return result;
//            };
//    }


//    private event NameDelegate? NameHandler;
//    private NameDelegate? nameDelegate;

//    private string name;
//    public string Name 
//    { 
//        get => name;
//        set
//        {
//            NameHandler?.Invoke(value);
//            name = value;
//        }
//    }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//}
#endregion


#region Part2

using System.Collections.ObjectModel;

ProcessBusinessLogic bl = new ProcessBusinessLogic();

bl.ProcessCompleted += bl_ProcessCompleted;

bl.StartProcess();

void bl_ProcessCompleted(object sender, bool IsSuccessful)
{
    Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed") + $"From {sender.GetType().Name}");
}

public class ProcessBusinessLogic
{
    public event EventHandler<bool> ProcessCompleted;
    public void StartProcess()
    {
        try
        {
            Console.WriteLine("Process Started!");

            OnProcessCompleted(true);
        }
        catch (Exception ex)
        {
            OnProcessCompleted(false);
        }
    }

    protected void OnProcessCompleted(bool IsSuccessful)
    {
        ProcessCompleted?.Invoke(this, IsSuccessful);
    }
}

#endregion

