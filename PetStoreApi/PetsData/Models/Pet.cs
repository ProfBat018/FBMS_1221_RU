using System.ComponentModel.DataAnnotations;

namespace PetsData.Models;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }
    public PetCategory PetCategory { get; set; }
    public int PetCategoryId { get; set; }

    public Product Product { get; set; }
    public int ProductId { get; set; }
}