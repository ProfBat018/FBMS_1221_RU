using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsData.Models;
public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<AnimalType> AnimalTypes { get; set; }
    public ICollection<ProductType> ProductType { get; set; }
}
