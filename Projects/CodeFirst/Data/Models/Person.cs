using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Data.Models;



public class Person
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Surname { get; set; }

    [Required]
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name}\t{Surname}\t{Age}";
    }
}



