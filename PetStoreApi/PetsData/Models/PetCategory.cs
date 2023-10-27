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
    public int AnimalTypeId { get; set; }
    public AnimalType AnimalType { get; set; }
}