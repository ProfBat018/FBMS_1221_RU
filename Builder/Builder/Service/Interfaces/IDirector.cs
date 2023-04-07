namespace Builder.Service.Interfaces;

public interface IDirector
{
    public IBuilder Builder { get; set; }
    
    public void RunBuilder();
    
    
}