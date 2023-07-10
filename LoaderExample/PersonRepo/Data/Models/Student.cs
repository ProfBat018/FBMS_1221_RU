using System.Security.Cryptography;

namespace PersonRepo.Data.Models;

public class Student
{
    public int Id { get; set; }
    
    public int PersonId { get; set; }
    public int GroupId { get; set; }
    public double GPA { get; set; }
    public Person Person { get; set; }
    public Group Group { get; set; }
}