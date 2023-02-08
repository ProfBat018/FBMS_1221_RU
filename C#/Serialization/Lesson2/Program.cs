/*
	Обсуждение вопросов по сериализации...

	Task 1. Нужно сериализовать и десекриализовать класс, в котором есть список
 */

using Academy;
using Lesson2;

Student Maga = new()
{
	Name = "Maga",
	Surname = "Babayev",
	Age = 16,
	Grade = GRADE.FIRST
};

Student Ali = new()
{
	Name = "Ali",
	Surname = "Shirinov",
	Age = 16,
	Grade = GRADE.FIRST
};


Student Lala = new()
{
	Name = "Lala",
	Surname = "Mammadova",
	Age = 24,
	Grade = GRADE.FIRST
};

Student Laman = new()
{
	Name = "Laman",
	Surname = "Aliyeva",
	Age = 26,
	Grade = GRADE.FIRST
};


Group firstGroup = new()
{
	Students = new() { Maga, Ali, Lala, Laman },
	Name = "FBMS_1221_RU"
};

#region Serialize

//SerializeService service = new();

//var json = service.Serialize(firstGroup);

//using FileStream fs = new("data.json", FileMode.OpenOrCreate);
//using StreamWriter sw = new(fs);

//sw.Write(json);

#endregion


#region Deserialize

using FileStream fs = new("data.json", FileMode.OpenOrCreate);
using StreamReader sr = new(fs);

SerializeService service = new();
var obj = service.Deserialize<Group>(sr.ReadToEnd());

Console.WriteLine(obj);

#endregion



