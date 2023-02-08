// MulticastDelegate

Employee e1 = new()
{
    Name = "Elvin",
    Surname = "Azimov",
    Salary = 1000
};

Counter counter = new();

Console.WriteLine(counter.CountSalary(e1));