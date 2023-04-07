using Builder.Service.Interfaces;

namespace Builder.Service.Classes;

public class Builder : IBuilder
{
    public PC PcToBuild { get; set; } = new();

    public PC GetPc()
    {
        return PcToBuild;
    }

    public void BuildCase()
    {
        PcToBuild.Add(new Case() {Name = "Cooler Master"});
        Console.WriteLine("Building case...");
    }

    public void BuildMotherboard()
    {
        PcToBuild.Add(new Motherboard() {Name = "Asus"});
        Console.WriteLine("Building motherboard...");
    }

    public void BuildMotherboardComponents(object configuration)
    {
        foreach (var property in configuration.GetType().GetProperties())
        {
            // Button btn = new Button();
            // btn.Name = property.Name;
            // btn.Grid.Row = i
            // btn.Text = property.GetValue(configuration).ToString();
            
            Console.WriteLine($"{property.Name}\t {property.GetValue(configuration)}");
        }

        Console.WriteLine("Building motherboard components...");
    }
}