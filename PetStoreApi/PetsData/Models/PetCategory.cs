using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsData.Models;

public class PetCategory
{
    public int Id { get; set; }
    public string Name { get; set; }

    public AnimalType AnimalType { get; set; }
    public int AnimalTypeID { get; set; }

    public ICollection<Pet> Pets { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; }
}