/*
	Обсуждение вопросов по сериализации...

	Task 1. Нужно сериализовать и десекриализовать класс, в котором есть список
 */


using Lesson2;

namespace Academy;

class Student : MySerializable
{
	private int age;
	private static int idCounter = 0;
	private int id;

	public string? Name { get; set; }
	public string? Surname { get; set; }

	public int Id { get => id; }

	public Student()
	{
		id = ++idCounter;
	}
	
	public int Age
	{
		get => age;
		set => age = ((value > 14 && value < 80) ? value : throw new ArgumentException("Age must be more than 14 and less than 80"));
	}


	public GRADE Grade { get; set; } = GRADE.FIRST;

	public override string ToString()
	{
		string? grade;
		switch (Grade)
		{
			case GRADE.FIRST:
				grade = "First";
				break;
			case GRADE.SECOND:
				grade = "Second";
				break;
			case GRADE.THIRD:
				grade = "Third";
				break;
			case GRADE.FOURTH:
				grade = "Fourth";
				break;
			default:
				grade = "First";
				break;
		}
		return
			$"\nId: {Id}\n" +
			$"Name: {Name}\n" +
			$"Surname: {Surname}\n" +
			$"Age: {Age}\n" +
			$"Grade: {grade}\n";
	}
}
