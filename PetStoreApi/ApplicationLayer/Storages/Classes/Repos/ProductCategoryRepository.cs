using ApplicationLayer.Storages.Classes.Abstractions;
using PetsData.DbContexts;
using PetsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Storages.Classes.Repos;

public class ProductCategoryRepository : Repository<ProductCategory>
{
    private readonly PetDbContext _context;

    public ProductCategoryRepository(PetDbContext context) : base(context)
    {
    }
}