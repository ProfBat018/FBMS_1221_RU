using System.ComponentModel.DataAnnotations;

namespace PetsData.Models;


public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public float Price { get; set; }
    public ICollection<PetCategory> PetCategories { get; set; }
}