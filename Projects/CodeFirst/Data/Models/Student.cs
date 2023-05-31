using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Data.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Person")]
    public int PersonId { get; set; }
    public Person Person { get; set; }

    
    [ForeignKey("Group")]
    public int GroupId { get; set; }
    public Group Group { get; set; }

    public float GPA { get; set; }
}