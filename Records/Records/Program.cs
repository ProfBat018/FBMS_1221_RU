
Person p1 = new("Elvin", "Azimov");


Student s1 = new()
{
    name = "Elvin",
    age = 20
};



public record Person(string FirstName, string LastName);

public record Student
{
    public string name;
    public int age;
}