using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsData.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public float Price { get; set; }


    public ProductCategory ProductCategory { get; set; }
    public int ProductCategoryId { get; set; }

    public ICollection<Pet> Pets { get; set; }

}
