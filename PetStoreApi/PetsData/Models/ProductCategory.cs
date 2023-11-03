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
    public ProductCategoryType ProductCategoryType { get; set; }
    public int ProductCategoryTypeId { get; set; }

    public ICollection<Product> Products { get; set; }

    public ICollection<ProductSpecification> ProductSpecifications { get; set; }
}
