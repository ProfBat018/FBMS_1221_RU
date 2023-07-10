namespace PersonRepo.Data.Models;

public class Teacher
{
    public int Id { get; set; }
    
    public int GroupId { get; set; }
    public Group Group { get; set; }

    public Employee Employee { get; set; }
    public int EmployeeId { get; set; }
}


