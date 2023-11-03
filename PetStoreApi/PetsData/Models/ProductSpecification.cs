using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsData.Models;

public class ProductSpecification
{
    public int Id { get; set; }

    public ProductCategory ProductCategory { get; set; }
    public int ProductCategoryId{ get; set; }
    public Specification Specification { get; set; }
    public int SpecificationId { get; set; }

    public string Value { get; set; }
}
