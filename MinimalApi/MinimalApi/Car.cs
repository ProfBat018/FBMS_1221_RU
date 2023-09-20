using System.ComponentModel.DataAnnotations;

public class Car
{
    [Key] public int Id { get; set; }
    
    [Required] public string Make { get; set; }

    [Required] public string Model { get; set; }

    [Required] public int Year { get; set; }
}