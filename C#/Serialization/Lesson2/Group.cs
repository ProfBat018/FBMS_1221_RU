/*
	Обсуждение вопросов по сериализации...

	Task 1. Нужно сериализовать и десекриализовать класс, в котором есть список
 */
using Lesson2;
using System.Text;

namespace Academy;
class Group : MySerializable
{
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
}
