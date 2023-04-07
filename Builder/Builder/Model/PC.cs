using System.Collections;

namespace Builder;

public class PC : IEnumerable<IPart>
{
    private List<IPart> Parts { get; set; } = new();

    public void Add(IPart part)
    {
        Parts.Add(part);
    }

    public IEnumerator<IPart> GetEnumerator()
    {
        for (int i = 0; i < Parts.Count; i++)
        {
            yield return Parts[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}