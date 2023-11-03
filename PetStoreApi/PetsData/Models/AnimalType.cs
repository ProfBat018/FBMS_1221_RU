using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace PetsData.Models;
public class AnimalType
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<PetCategory> PetCategories { get; set; }
}
