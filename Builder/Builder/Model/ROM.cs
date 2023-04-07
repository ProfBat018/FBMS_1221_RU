namespace Builder;

public enum ROMType {SSD, HDD };

public class ROM : IPart
{
    public string Name { get; set; }
    public float Price { get; set; }
    public ROMType ROMType { get; set; }
}

