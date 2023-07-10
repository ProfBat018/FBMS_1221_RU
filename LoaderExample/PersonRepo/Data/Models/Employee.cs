namespace PersonRepo.Data.Models;

public class Employee
{
    public int Id { get; set; }
    public int Salary { get; set; }
    public string Position { get; set; }
    
    public int PersonId { get; set; }
    public Person Person { get; set; }
}