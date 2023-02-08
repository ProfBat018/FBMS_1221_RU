using System.Text;
using Lesson3.Service;

namespace Lesson3.Model;
class Group : MySerializable
{
    private readonly SerializeService _serializeService = new();

    public List<Student>? Students { get; set; }
    public string? Name { get; set; }


    public override string ToString()
    {
        StringBuilder? res = new();

        res.Append($"Group name: {Name}\n");

        foreach (var item in Students)
        {
            res.Append(item.ToString());
        }
        return res.ToString();
    }

    public void AddStudent(Student? student)
    {
        var json = FileService.ReadFromFile("data2.json", FileMode.OpenOrCreate);

        if (json != null)
        {
            var group = SerializeService.Deserialize<Group>(json) as Group;
            group.Students.Add(student);
            
            var result = SerializeService.Serialize<Group>(group);
            FileService.WriteToFile(result, "data2.json", FileMode.Open);
        }
    }

}
