using ApplicationLayer.Storages.Classes.Abstractions;
using PetsData.DbContexts;
using PetsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Storages.Classes.Repos;

public class PetCategoryRepository : Repository<Product>
{
    private readonly PetDbContext _context;

    public PetCategoryRepository(PetDbContext context) : base(context)
    {
    }
}