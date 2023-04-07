using System.Reflection;

namespace Builder.Service.Interfaces;

public interface IBuilder
{
    public PC PcToBuild { get; set; }

    public PC GetPc();
    void BuildCase();
    void BuildMotherboard();
    void BuildMotherboardComponents(object configuration);
}