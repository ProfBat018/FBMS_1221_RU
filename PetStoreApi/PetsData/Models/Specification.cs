using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsData.Models;

public class Specification
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProductSpecification> ProductSpecifications { get; set; }

}
