using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Data.Models;

public class Teacher
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Person")]
    public int PersonId { get; set; }
    public Person Person { get; set; }

}