using Builder.Service.Interfaces;

namespace Builder.Service.Classes;

public class Director : IDirector
{
    public IBuilder Builder { get; set; } = new Builder();
    
    public void RunBuilder()
    {
        int choice;
        Console.WriteLine("Select first option to build a PC");
            
        Console.WriteLine("1. Build motherboard Firt");
        Console.WriteLine("2. Build motherboard components first");

        bool res = int.TryParse(Console.ReadLine(), out choice);
        if (res)
        {
            switch (choice)
            {
                case 1:
                    Builder.BuildMotherboard();
                    Builder.BuildMotherboardComponents(new {ramCount = 2, gpuCount = 1});
                    Builder.BuildCase();
                    break;
                case 2:
                    Builder.BuildCase();
                    Builder.BuildMotherboard();
                    Builder.BuildMotherboardComponents(new {ramCount = 2, gpuCount = 1});
                    break;
                default:
                    RunBuilder();   
                    break;
            }
        }
        else
        {
            RunBuilder();   
        }
    }
}